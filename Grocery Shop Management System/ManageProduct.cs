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
    public partial class ManageProduct : Form
    {
        private bool isNew = true;
        public ManageProduct()
        {
            InitializeComponent();
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            ManageCategory mc = new ManageCategory();
            mc.Visible = true;
            this.Hide();
        }
        private void Refresh()
        {
            isNew = true;

            idtxt.Text = "";
            nametxt.Text = "";
            ppricetxt.Text = "";
            spricetxt.Text = "";
            qttxt.Text = "";

            productTable.ClearSelection();
        }
        private void LoadCategory()
        {
            DataAccess access = new DataAccess();

            string query = "Select * from Category";

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            ctxt.DataSource = dt;
            ctxt.DisplayMember = "cid";
            ctxt.ValueMember = "cid";

            cnametxt.DataSource = dt;
            cnametxt.DisplayMember = "name";
            cnametxt.ValueMember = "name";
        }
        private void LoadProductInfo()
        {
            DataAccess access = new DataAccess();

            string query = "Select * from Product";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where name like '%" + searchtxt.Text + "%'";
            }

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            productTable.AutoGenerateColumns = false;
            productTable.DataSource = dt;
            productTable.Refresh();
            productTable.ClearSelection();

            this.Refresh();
        }
        private void LoadSingleProduct()
        {
            DataAccess access = new DataAccess();

            string query = "Select * from Product Where pid = '" + idtxt.Text + "'";

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

            idtxt.Text = dt.Rows[0]["pid"].ToString();
            nametxt.Text = dt.Rows[0]["name"].ToString();
            ppricetxt.Text = dt.Rows[0]["p_price"].ToString();
            spricetxt.Text = dt.Rows[0]["s_price"].ToString();
            qttxt.Text = dt.Rows[0]["quantity"].ToString();
            ctxt.Text = dt.Rows[0]["cid"].ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            LoadProductInfo();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadProductInfo();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string id = this.idtxt.Text;
            string name = this.nametxt.Text;
            string pprice = this.ppricetxt.Text;
            string sprice = this.spricetxt.Text;
            string quantity = this.qttxt.Text;
            string cid = this.ctxt.Text;
            string cname = this.cnametxt.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Invalid/Insufficient information");
                return;
            }

            DataAccess access = new DataAccess();

            string query = "";
            string insertProductQuery = "begin product_member_insert.AddProduct(:p1,:p2,:p3,:p4,:p5); end;";


            if (isNew == true)
            {
                try
                {
                    access.Command = new OracleCommand(insertProductQuery, access.Connection);
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = name;
                    access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = pprice;
                    access.Command.Parameters.Add("p3", OracleDbType.Varchar2).Value = sprice;
                    access.Command.Parameters.Add("p4", OracleDbType.Varchar2).Value = quantity;
                    access.Command.Parameters.Add("p5", OracleDbType.Varchar2).Value = cname;
                    access.Command.ExecuteNonQuery();

                    MessageBox.Show("Product Successfully Inserted");

                    this.LoadProductInfo();
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
                query = "UPDATE Product SET name = '" + name + "', p_price = " + pprice + ", s_price = " + sprice + ", quantity = " + quantity + ", cid = " + cid + " WHERE pid = '" + idtxt.Text + "'";

                access.Command = new OracleCommand(query, access.Connection);

                try
                {
                    if (access.Command.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Product Update Failed");
                    }
                    else
                    {
                        MessageBox.Show("Product Successfully Updated");
                        this.LoadProductInfo();
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

            string query = "Delete from Product Where pid = :p1";

            DataAccess access = new DataAccess();
            access.Command = new OracleCommand(query, access.Connection);

            access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = idtxt.Text;
            try
            {
                if (access.Command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Product Deleted Successfully");
                    this.LoadProductInfo();
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
            //this.Owner.Show();
            //this.Hide();
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

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            LoadProductInfo();
            LoadCategory();
            //searchtxt.Text = "Search Here";
        }

        private void ManageProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void productTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string pid = productTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = pid;
                this.LoadSingleProduct();
            }
        }
    }
}
