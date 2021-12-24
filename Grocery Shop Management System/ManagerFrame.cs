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
    public partial class ManagerFrame : Form
    {
        public static string x;
        public ManagerFrame()
        {
            InitializeComponent();
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
            //mp.categoryBtn.Visible = false;
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            SalesFrame sf = new SalesFrame();
            sf.Show(this);
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login lf = new Login();
            lf.Visible = true;
            this.Hide();
        }

        private void ManagerFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ManagerFrame_Load(object sender, EventArgs e)
        {
            x = Login.a;

            DataAccess access = new DataAccess();

            string query = "Select * from Employee Where user_id = '" + x + "'";

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            logintxt.Text = dt.Rows[0]["name"].ToString();
        }

        private void passBtn_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password();
            cp.Show(this);
            this.Hide();
        }
    }
}
