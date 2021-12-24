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
    public partial class Change_Password : Form
    {
        public static string x, y;
        public Change_Password()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!oldpasstxt.Text.Equals("") && !oldpasstxt.Text.Equals(null))
            {
                DataAccess access = new DataAccess();
                try
                {
                    if (oldpasstxt.Text.Equals(y))
                    {
                        if (!newpasstxt.Text.Equals("") && !newpasstxt.Text.Equals(null))
                        {
                            string query = "Update Login SET password = '" + newpasstxt.Text + "' WHERE user_id = '" + x + "'";

                            access.Command = new OracleCommand(query, access.Connection);

                            if (access.Command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Password changed successfully!!");

                                y = this.newpasstxt.Text;

                                this.oldpasstxt.Text = "";
                                this.newpasstxt.Text = "";

                                Login f = new Login();
                                this.Visible = false;
                                f.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Password changed failed");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please insert new password!!");
                            newpasstxt.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Old password doesnot match!!");
                        this.oldpasstxt.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Please insert old password!!");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login lf = new Login();
            lf.Visible = true;
            this.Hide();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            x = Login.a;
            y = Login.b;
        }

        private void Change_Password_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
