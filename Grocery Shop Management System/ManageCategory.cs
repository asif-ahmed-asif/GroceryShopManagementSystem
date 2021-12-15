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
    public partial class ManageCategory : Form
    {
        private bool isNew = true;
        public ManageCategory()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            isNew = true;

            idtxt.Text = "";
            nametxt.Text = "";

            categoryTable.ClearSelection();
        }
        private void LoadCategoryInfo()
        {
            DataAccess access = new DataAccess();

            string query = "Select * from Category";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Category.name like '%" + searchtxt.Text + "%'";
            }

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            categoryTable.AutoGenerateColumns = false;
            categoryTable.DataSource = dt;
            categoryTable.Refresh();
            categoryTable.ClearSelection();

            this.Refresh();
        }
        private void LoadSingleCategory()
        {
            DataAccess access = new DataAccess();

            string query = "Select * from Category Where cid = '" + idtxt.Text + "'";

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

            idtxt.Text = dt.Rows[0]["cid"].ToString();
            nametxt.Text = dt.Rows[0]["name"].ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            LoadCategoryInfo();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadCategoryInfo();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string id = this.idtxt.Text;
            string name = this.nametxt.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Invalid/Insufficient information");
                return;
            }

            DataAccess access = new DataAccess();

            string query = "";
            string insertCategoryQuery = "begin product_member_insert.AddCategory(:p1); end;";

            if (isNew == true)
            {
                try
                {
                    access.Command = new OracleCommand(insertCategoryQuery, access.Connection);
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = name;

                    access.Command.ExecuteNonQuery();

                    MessageBox.Show("Category Successfully Inserted");

                    this.LoadCategoryInfo();
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
                query = "UPDATE Category SET name = '" + name + "' WHERE cid = '" + idtxt.Text + "'";

                access.Command = new OracleCommand(query, access.Connection);

                try
                {
                    if (access.Command.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Category Update Failed");
                    }
                    else
                    {
                        MessageBox.Show("Category Successfully Updated");
                        this.LoadCategoryInfo();
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

            string query = "Delete from Category Where cid = :p1";

            DataAccess access = new DataAccess();
            access.Command = new OracleCommand(query, access.Connection);

            access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = idtxt.Text;
            try
            {
                if (access.Command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Category Deleted Successfully");
                    this.LoadCategoryInfo();
                    this.Refresh();
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

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            LoadCategoryInfo();
            //searchtxt.Text = "Search Here";
        }

        private void ManageCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void categoryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = categoryTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = id;
                this.LoadSingleCategory();
            }
        }
    }
}
