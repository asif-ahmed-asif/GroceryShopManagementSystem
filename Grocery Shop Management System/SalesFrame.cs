using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Grocery_Shop_Management_System
{
    public partial class SalesFrame : Form
    {
        public SalesFrame()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void SalesFrame_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void Refresh()
        {
            this.LoadTodaysBenefit();
            this.LoadMonthlyBenefit();
            this.LoadMostSales();
            this.LoadMostBenefit();
        }
        private void LoadTodaysBenefit()
        {
            DataAccess access = new DataAccess();

            string query = "SELECT SUM(sales.t_price-sales.quantity*product.p_price) AS todays_benefit FROM product INNER JOIN sales ON sales.pid = product.pid WHERE sales.s_date = TO_CHAR(SYSDATE, 'YYYY-MM-DD')";

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);
            var today = Convert.ToString(dt.Rows[0][0]);

            if (today == null)
                this.lblToday.Text = "0 Tk";
            else
                this.lblToday.Text = today + " tk";
        }

        private void LoadMonthlyBenefit()
        {
            DataAccess access = new DataAccess();

            string query = "SELECT SUM(sales.t_price-sales.quantity*product.p_price) AS todays_benefit FROM product INNER JOIN sales ON sales.pid = product.pid WHERE sales.s_date > TO_CHAR(SYSDATE - 30, 'YYYY-MM-DD') ";

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);
            var month = Convert.ToString(dt.Rows[0][0]);

            if (month == null)
                this.lblMonth.Text = "0 Tk";
            else
                this.lblMonth.Text = month + " tk";
        }
        private void LoadMostSales()
        {
            try
            {
                DataAccess access = new DataAccess();

                string query = "SELECT product.name, sales.t_price, sales.quantity, sales.s_date, sales.t_price-sales.quantity*product.p_price AS benefit FROM product INNER JOIN sales ON sales.pid = product.pid WHERE ROWNUM <= 5 ORDER BY quantity DESC, sales.s_date DESC";

                access.Command = new OracleCommand(query, access.Connection);
                access.Adapter = new OracleDataAdapter(access.Command);

                DataTable dt = new DataTable();
                access.Adapter.Fill(dt);

                int row = 0;
                while (row < dt.Rows.Count)
                {
                    this.chartMostSoldProduct.Series["Sales"].Points.AddXY(dt.Rows[row]["name"], Convert.ToInt32(dt.Rows[row]["quantity"]));
                    row++;
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            
        }

        private void LoadMostBenefit()
        {
            try
            {
                DataAccess access = new DataAccess();

                string query = "SELECT product.name, sales.t_price, sales.quantity, sales.s_date, sales.t_price-sales.quantity*product.p_price AS benefit FROM product INNER JOIN sales ON sales.pid = product.pid WHERE ROWNUM <= 5 ORDER BY benefit DESC, sales.s_date DESC";

                access.Command = new OracleCommand(query, access.Connection);
                access.Adapter = new OracleDataAdapter(access.Command);

                DataTable dt = new DataTable();
                access.Adapter.Fill(dt);

                int row = 0;
                while (row < dt.Rows.Count)
                {
                    this.chartMostBenefitProduct.Series["Benefit"].Points.AddXY(dt.Rows[row]["name"], Convert.ToInt32(dt.Rows[row]["benefit"]));
                    row++;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

    }
}
