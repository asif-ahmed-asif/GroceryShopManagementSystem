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
    public partial class Login : Form
    {
        public static string a, b;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usertxt.Text = "Enter Username";
            passtxt.Text = "Enter Password";
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            a = usertxt.Text;
            b = passtxt.Text;

            string uid = this.usertxt.Text;
            string pass = this.passtxt.Text;

            if (string.IsNullOrEmpty(uid))
            {
                MessageBox.Show("UserID cannot be empty");
                return;
            }
            else if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Password cannot be empty");
                return;
            }
            else
            {
                try
                {
                    DataAccess access = new DataAccess();

                    string selectQuery = "select * from Login where USER_ID = :p1 and PASSWORD = :p2";

                    access.Command = new OracleCommand(selectQuery, access.Connection);

                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = usertxt.Text;
                    access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = passtxt.Text;

                    access.Adapter = new OracleDataAdapter(access.Command);
                    DataTable table = new DataTable();
                    access.Adapter.Fill(table);

                    if (table.Rows.Count == 1)
                    {
                        if (table.Rows[0]["TYPE"].ToString() == "a")
                        {
                            AdminFrame af = new AdminFrame();
                            af.Visible = true;
                            this.Hide();
                        }
                        else if (table.Rows[0]["TYPE"].ToString() == "m")
                        {
                            ManagerFrame mf = new ManagerFrame();
                            mf.Visible = true;
                            this.Hide();
                        }
                        else if (table.Rows[0]["TYPE"].ToString() == "s")
                        {
                            SalesmanFrame sf = new SalesmanFrame();
                            sf.Visible = true;
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invaild Id or Password");
                    }
                }

                catch (Exception exc)
                {
                    //MessageBox.Show(exc.ToString());
                    MessageBox.Show("Invaild Id or Password");
                }
            }
        }

        private void usertxt_Enter(object sender, EventArgs e)
        {
            if (usertxt.Text == "Enter Username")
            {
                usertxt.Text = "";
            }
        }

        private void usertxt_Leave(object sender, EventArgs e)
        {
            if (usertxt.Text == "")
            {
                usertxt.Text = "Enter Username";
            }
        }

        private void passtxt_Enter(object sender, EventArgs e)
        {
            if (passtxt.Text == "Enter Password")
            {
                passtxt.Text = "";
                passtxt.UseSystemPasswordChar = true;
            }
        }

        private void passtxt_Leave(object sender, EventArgs e)
        {
            if (passtxt.Text == "")
            {
                passtxt.Text = "Enter Password";
                passtxt.UseSystemPasswordChar = false;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
