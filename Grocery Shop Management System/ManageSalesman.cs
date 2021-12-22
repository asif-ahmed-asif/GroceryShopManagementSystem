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
    public partial class ManageSalesman : Form
    {
        public static string x;
        private bool isNew = true;
        public ManageSalesman()
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

            salesmanTable.ClearSelection();
        }
        private void LoadMgr()
        {
            this.datetxt.MaxDate = DateTime.Now;
            DataAccess access = new DataAccess();

            string query = "Select * from employee e, login l where l.user_id = e.user_id and type = 'm'";

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            mgrtxt.DataSource = dt;
            mgrtxt.DisplayMember = "user_id";
            mgrtxt.ValueMember = "user_id";
        }
        private void LoadSalesmanInfo()
        {
            DataAccess access = new DataAccess();

            string query = "Select * from employee e, login l where l.user_id = e.user_id and type = 's' order by id ASC";
            //string query = "Select * from employee e, login l where l.user_id = e.user_id and type = 's'";

            /*if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = "Select * from employee e, login l where l.user_id = e.user_id and type = 's' And name like '%" + searchtxt.Text + "%'";
            }*/

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            salesmanTable.AutoGenerateColumns = false;
            salesmanTable.DataSource = dt;
            salesmanTable.Refresh();
            salesmanTable.ClearSelection();

            this.Refresh();
        }
        private void LoadSingleSalesman()
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
            mgrtxt.Text = dt.Rows[0]["mgr"].ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            LoadSalesmanInfo();
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
            string mgr = Convert.ToString(this.mgrtxt.Text);

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
            string insertEmpQuery = "begin emp_sales_insert.AddEmployee(:p1,:p2,:p3,:p4,:p5,:p6,:p7,:p8,:p9); end;";

            if (isNew == true)
            {
                    try
                    {
                       access.Command = new OracleCommand(insertEmpQuery, access.Connection);
                       access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = name;
                       access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = phone;
                       access.Command.Parameters.Add("p3", OracleDbType.Varchar2).Value = address;
                       access.Command.Parameters.Add("p4", OracleDbType.Varchar2).Value = salary;
                       access.Command.Parameters.Add("p5", OracleDbType.Varchar2).Value = date;
                       access.Command.Parameters.Add("p6", OracleDbType.Varchar2).Value = email;
                       access.Command.Parameters.Add("p7", OracleDbType.Varchar2).Value = mgr;
                       access.Command.Parameters.Add("p8", OracleDbType.Varchar2).Value = password;
                       access.Command.Parameters.Add("p9", OracleDbType.Varchar2).Value = "s";
                       access.Command.ExecuteNonQuery();
                        MessageBox.Show("Salesman Successfully Inserted with Password: " + password);

                        this.LoadSalesmanInfo();
                        this.Refresh();

                        access.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
            }
            else
            {
                string updateEmpQuery = "begin UpdateEmployee(:p1,:p2,:p3,:p4,:p5,:p6,:p7,:p8); end;";

                access.Command = new OracleCommand(updateEmpQuery, access.Connection);

                try
                {
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = name;
                    access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = phone;
                    access.Command.Parameters.Add("p3", OracleDbType.Varchar2).Value = address;
                    access.Command.Parameters.Add("p4", OracleDbType.Varchar2).Value = salary;
                    access.Command.Parameters.Add("p5", OracleDbType.Varchar2).Value = date;
                    access.Command.Parameters.Add("p6", OracleDbType.Varchar2).Value = email;
                    access.Command.Parameters.Add("p7", OracleDbType.Varchar2).Value = mgr;
                    access.Command.Parameters.Add("p8", OracleDbType.Varchar2).Value = id;
                    if (access.Command.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Salesman Update Failed");
                    }
                    else
                    {
                        MessageBox.Show("Salesman Successfully Updated");
                        this.LoadSalesmanInfo();
                        this.Refresh();
                    }
                }
                catch (Exception ex)
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

                    this.LoadSalesmanInfo();
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
            this.Owner.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login lf = new Login();
            lf.Visible = true;
            this.Hide();
        }

        private void ManageSalesman_Load(object sender, EventArgs e)
        {
            x = Login.a;
            LoadSalesmanInfo();
            LoadMgr();
        }

        private void ManageSalesman_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void salesmanTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = salesmanTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = id;
                this.LoadSingleSalesman();
            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            DataAccess access = new DataAccess();

            string query = "Select * from employee e, login l where l.user_id = e.user_id and type = 's' And name like '" + searchtxt.Text + "%' order by id ASC";
            
            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            salesmanTable.AutoGenerateColumns = false;
            salesmanTable.DataSource = dt;
            salesmanTable.Refresh();
            salesmanTable.ClearSelection();
        }
    }
}
