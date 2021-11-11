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
    public partial class Customer_Reg : Form
    {
        private bool isNew = true;
        public Customer_Reg()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            isNew = true;

            nametxt.Text = "";
            phonetxt.Text = "";
            addresstxt.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string cname = this.nametxt.Text;
            string address = this.addresstxt.Text;
            string phone = this.phonetxt.Text;

            if (string.IsNullOrEmpty(cname) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Invalid/Insufficient information");
                return;
            }

            DataAccess access = new DataAccess();

            string query = "";

            if (isNew == true)
            {
                try
                {
                    query = "INSERT into Member(id, name, address, phone, amount) Values (Member_Seq.NEXTVAL, '" + cname + "', '" + address + "', '" + phone + "', NULL)";

                    access.Command = new OracleCommand(query, access.Connection);
                    access.Command.ExecuteNonQuery();

                    MessageBox.Show("Member Successfully Inserted");
                    this.Refresh();

                    access.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customer_Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
