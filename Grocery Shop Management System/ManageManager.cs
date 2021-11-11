﻿using System;
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
    public partial class ManageManager : Form
    {
        private bool isNew = true;
        public ManageManager()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            isNew = true;

            idtxt.Text = "";
            nametxt.Text = "";
            phonetxt.Text = "";
            emailtxt.Text = "";
            datetxt.Text = "";
            salarytxt.Text = "";
            addresstxt.Text = "";

            managerTable.ClearSelection();
        }
        private void LoadManagerInfo()
        {
            DataAccess access = new DataAccess();

            string query = "Select * from employee e, login l where l.user_id = e.user_id and type = 'm'";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " And name like '%" + searchtxt.Text + "%'";
            }

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            managerTable.AutoGenerateColumns = false;
            managerTable.DataSource = dt;
            managerTable.Refresh();
            managerTable.ClearSelection();

            this.Refresh();
        }
        private void LoadSingleManager()
        {
            DataAccess access = new DataAccess();

            string query = "Select * from Employee Where user_id = '" + idtxt.Text + "'";

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            isNew = false;

            idtxt.Text = dt.Rows[0]["user_id"].ToString();
            nametxt.Text = dt.Rows[0]["name"].ToString();
            phonetxt.Text = dt.Rows[0]["phone"].ToString();
            emailtxt.Text = dt.Rows[0]["email"].ToString();
            datetxt.Text = dt.Rows[0]["join_date"].ToString();
            salarytxt.Text = dt.Rows[0]["salary"].ToString();
            addresstxt.Text = dt.Rows[0]["address"].ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            LoadManagerInfo();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadManagerInfo();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string id = this.idtxt.Text;
            string name = this.nametxt.Text;
            string phone = this.phonetxt.Text;
            string email = this.emailtxt.Text;
            string date = this.datetxt.Text;
            string salary = Convert.ToString(this.salarytxt.Text);
            string address = this.addresstxt.Text;

            Random rd = new Random();
            int x = rd.Next(999) + 10000;

            string password = (x + "");

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(salary) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Invalid/Insufficient information");
                return;
            }

            DataAccess access = new DataAccess();

            string query = "";
            string query1 = "";

            if (isNew == true)
            {
                query1 = "INSERT into Login(user_id,password,type) Values (Login_Seq.NEXTVAL, '" + password + "', 'm')";

                access.Command = new OracleCommand(query1, access.Connection);

                if(access.Command.ExecuteNonQuery() == 1)
                {
                    query = "INSERT into Employee(id,user_id,name,phone,address,salary,join_date,email,mgr) Values (Employee_Seq.NEXTVAL, Login_Seq.CURRVAL, :p2, :p3, :p4, :p5, :p6, :p7, NULL)";
                    access.Command = new OracleCommand(query, access.Connection);

                    access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = nametxt.Text;
                    access.Command.Parameters.Add("p3", OracleDbType.Varchar2).Value = phonetxt.Text;
                    access.Command.Parameters.Add("p4", OracleDbType.Varchar2).Value = addresstxt.Text;
                    access.Command.Parameters.Add("p5", OracleDbType.Varchar2).Value = salarytxt.Text;
                    access.Command.Parameters.Add("p6", OracleDbType.Varchar2).Value = datetxt.Text;
                    access.Command.Parameters.Add("p7", OracleDbType.Varchar2).Value = emailtxt.Text;

                    try
                    {
                        access.Command.ExecuteNonQuery();
                        MessageBox.Show("Manager Successfully Inserted with Password: " + password);
                        
                        this.LoadManagerInfo();
                        this.Refresh();

                        access.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                query = "UPDATE Employee SET name = '" + name + "', phone = '" + phone + "', address = '" + address + "', salary = " + salary + ", join_date = '" + date + "', email = '" + email + "' WHERE user_id = '" + idtxt.Text + "'";

                access.Command = new OracleCommand(query, access.Connection);

                try
                {
                    if (access.Command.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Manager Update Failed");
                    }
                    else
                    {
                        MessageBox.Show("Manager Successfully Updated");
                        this.LoadManagerInfo();
                        this.Refresh();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (isNew == true)
            {
                MessageBox.Show("Please load existing data first");
                return;
            }

            DataAccess access = new DataAccess();

            string query = "Delete from Employee where user_id = '" + idtxt.Text + "'";

            access.Command = new OracleCommand(query, access.Connection);

            try
            {
                if (access.Command.ExecuteNonQuery() == 1)
                {
                    string query1 = "Delete from Login where user_id = '" + idtxt.Text + "'";

                    access.Command = new OracleCommand(query1, access.Connection);

                    access.Command.ExecuteNonQuery();
                    MessageBox.Show("Manager Deleted Successfully");

                    this.LoadManagerInfo();
                    this.Refresh();

                    access.Connection.Close();
                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void ManageManager_Load(object sender, EventArgs e)
        {
            LoadManagerInfo();
            searchtxt.Text = "Search Here";
        }

        private void ManageManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void managerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = managerTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = id;
                this.LoadSingleManager();
            }
        }

        private void searchtxt_Enter(object sender, EventArgs e)
        {
            if (searchtxt.Text == "Search Here")
            {
                searchtxt.Text = "";
            }
        }

        private void searchtxt_Leave(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                searchtxt.Text = "Search Here";
            }
        }
    }
}
