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
    public partial class AdminFrame : Form
    {
        public static string x;
        public AdminFrame()
        {
            InitializeComponent();
        }

        private void managerBtn_Click(object sender, EventArgs e)
        {
            ManageManager mm = new ManageManager();
            mm.Visible = true;
            this.Hide();
        }

        private void salesmanBtn_Click(object sender, EventArgs e)
        {
            ManageSalesman ms = new ManageSalesman();
            ms.Show(this);
            this.Hide();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ManageProduct mp = new ManageProduct();
            mp.Show(this);
            this.Hide();
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {

        }

        private void AdminFrame_Load(object sender, EventArgs e)
        {
            x = Login.a;

            DataAccess access = new DataAccess();

            string query = "Select * from Admin Where user_id = '" + x + "'";

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            logintxt.Text = dt.Rows[0]["name"].ToString();

            string query1 = "SELECT COUNT(user_Id) FROM Login where type = 'm'";

            access.Command = new OracleCommand(query1, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt1 = new DataTable();
            access.Adapter.Fill(dt1);

            managerTxt.Text = dt1.Rows[0][0].ToString();


            string query2 = "SELECT COUNT(user_Id) FROM Login where type = 's'";

            access.Command = new OracleCommand(query2, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt2 = new DataTable();
            access.Adapter.Fill(dt2);

            salesmanTxt.Text = dt2.Rows[0][0].ToString();


            string query3 = "SELECT COUNT(pid) FROM Product";

            access.Command = new OracleCommand(query3, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt3 = new DataTable();
            access.Adapter.Fill(dt3);

            productTxt.Text = dt3.Rows[0][0].ToString();


            string query4 = "SELECT Sum(sub_total) FROM Invoice";

            access.Command = new OracleCommand(query4, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt4 = new DataTable();
            access.Adapter.Fill(dt4);

            salesTxt.Text = dt4.Rows[0][0].ToString();
        }

        private void AdminFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login lf = new Login();
            lf.Visible = true;
            this.Hide();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile();
            ap.Visible = true;
            this.Hide();
        }
    }
}
