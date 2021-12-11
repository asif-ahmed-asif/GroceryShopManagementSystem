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
    public partial class AdminProfile : Form
    {
        private bool isNew = true;
        public static string x;
        public AdminProfile()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            isNew = true;

            nametxt.Text = "";
            addresstxt.Text = "";
            emailtxt.Text = "";
            addresstxt.Text = "";
            phonetxt.Text = "";
        }
        public void LoadAdmin()
        {
            DataAccess access = new DataAccess();

            string query = "Select * from Admin Where user_id = '" + x + "'";

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid ID!");
                return;
            }

            idtxt.Text = dt.Rows[0]["user_id"].ToString();
            nametxt.Text = dt.Rows[0]["name"].ToString();
            emailtxt.Text = dt.Rows[0]["email"].ToString();
            addresstxt.Text = dt.Rows[0]["address"].ToString();
            phonetxt.Text = dt.Rows[0]["phone"].ToString();
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            x = Login.a;
            LoadAdmin();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = this.nametxt.Text;
            string phone = this.phonetxt.Text;
            string email = this.emailtxt.Text;
            string address = this.addresstxt.Text;

            DataAccess access = new DataAccess();

            string updateManagerQuery = "begin UpdateAdmin(:p1,:p2,:p3,:p4,:p5); end;";

            if (isNew == true)
            {  
                access.Command = new OracleCommand(updateManagerQuery, access.Connection);

                try
                {
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = name;
                    access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = phone;
                    access.Command.Parameters.Add("p3", OracleDbType.Varchar2).Value = email;
                    access.Command.Parameters.Add("p4", OracleDbType.Varchar2).Value = address;
                    access.Command.Parameters.Add("p5", OracleDbType.Varchar2).Value = idtxt.Text;
                    if (access.Command.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Admin Update Failed");
                    }
                    else
                    {
                        MessageBox.Show("Admin Successfully Updated");
                        this.LoadAdmin();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Load Existing data");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminFrame af = new AdminFrame();
            af.Visible = true;
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login lf = new Login();
            lf.Visible = true;
            this.Hide();
        }

        private void AdminProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}