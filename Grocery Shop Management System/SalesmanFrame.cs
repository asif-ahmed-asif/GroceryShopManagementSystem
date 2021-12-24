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
    public partial class SalesmanFrame : Form
    {
        public static string x;

        private bool isNew = true;
        public SalesmanFrame()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            isNew = true;

            idtxt.Text = "";
            nametxt.Text = "";
            ppricetxt.Text = "";

            cidtxt.Text = "";
            cnametxt.Text = "";
            phonetxt.Text = "";
            addresstxt.Text = "";

            dtxt.Text = "";
            qtxt.Text = "";
            totaltxt.Text = "";

            searchtxt.Text = "";
            csearchtxt.Text = "";

            nettxt.Text = "";

            sellTable.ClearSelection();
            memberTable.ClearSelection();
        }
        private void LoadOrder()
        {
            DataAccess access = new DataAccess();

            string query = "Select * from Product";

            /*if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where name like '%" + searchtxt.Text + "%'";
            }*/

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            sellTable.AutoGenerateColumns = false;
            sellTable.DataSource = dt;
            sellTable.Refresh();
            sellTable.ClearSelection();

            this.Refresh();
        }
        private void LoadCustomer()
        {
            DataAccess access = new DataAccess();

            string query = "Select * from Member";

            /*if (string.IsNullOrEmpty(csearchtxt.Text) == false)
            {
                query = query + " Where name like '%" + csearchtxt.Text + "%'";
            }*/

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            memberTable.AutoGenerateColumns = false;
            memberTable.DataSource = dt;
            memberTable.Refresh();
            memberTable.ClearSelection();

            this.Refresh();
        }
        private void LoadSingleOrder()
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
            ppricetxt.Text = dt.Rows[0]["s_price"].ToString();
        }
        private void LoadSingleCustomer()
        {
            DataAccess access = new DataAccess();

            string query = "Select * from Member Where id = '" + cidtxt.Text + "'";

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

            cidtxt.Text = dt.Rows[0]["id"].ToString();
            cnametxt.Text = dt.Rows[0]["name"].ToString();
            addresstxt.Text = dt.Rows[0]["address"].ToString();
            phonetxt.Text = dt.Rows[0]["phone"].ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadOrder();
            LoadCustomer();
        }
        private void Check()
        {
            for (int i = orderView.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = orderView.Items[i];

                if (item.SubItems[2].Text == "0")
                {
                    item.Remove();
                }
            }
        }
        private bool checkCustomer()
        {
            DataAccess access = new DataAccess();

            string query = ("Select id from Member where phone = '" + phonetxt.Text + "' AND amount IS NULL");

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string cname = this.cnametxt.Text;
            string address = this.addresstxt.Text;
            string phone = this.phonetxt.Text;
            string total = this.nettxt.Text;

            if (string.IsNullOrEmpty(total))
            {
                MessageBox.Show("Count total amount to complete order");
                return;
            }

            if (string.IsNullOrEmpty(cname) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Successfully Completed Order");
                this.Refresh();
                orderView.Items.Clear();

                if (MessageBox.Show("Do you want to become registered Customer?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                else
                {
                    Customer_Reg cr = new Customer_Reg();
                    cr.Visible = true;
                    this.Hide();
                }
            }
            else
            {
                if(orderView.Items.Count > 0)
                {
                    string subTotal = this.nettxt.Text;
                    string pid = this.idtxt.Text;
                    string quantity = this.qtxt.Text;
                    string t_price = this.totaltxt.Text;
                    string date = this.dtxt.Text;
                    string cid = this.cidtxt.Text;

                    if (string.IsNullOrEmpty(subTotal))
                    {
                        MessageBox.Show("Invalid/Insufficient information");
                        return;
                    }

                    try
                    {
                        DataAccess access = new DataAccess();

                        string query = "";
                        string query1 = "";
                        string query2 = "";

                        query = "INSERT into Invoice(id,s_date,sub_total) Values (Invoice_Seq.NEXTVAL, '" + date + "', " + subTotal + ")";

                        access.Command = new OracleCommand(query, access.Connection);
                        access.Command.ExecuteNonQuery();

                        if (checkCustomer())
                        {
                            query1 = "Update Member set amount = " + subTotal + " WHERE id = '" + cidtxt.Text + "'";

                            access.Command = new OracleCommand(query1, access.Connection);
                            access.Command.ExecuteNonQuery();
                        }
                        else
                        {
                            query1 = "UPDATE Member SET amount = CASE when amount > 500 then (amount + " + Convert.ToInt32(nettxt.Text) + " * 0.5) else (amount + " + Convert.ToInt32(nettxt.Text) + ") end WHERE id = '" + cidtxt.Text + "'";

                            access.Command = new OracleCommand(query1, access.Connection);
                            access.Command.ExecuteNonQuery();
                        }

                        string constr = "Data Source=Mustafiz; User ID=Adms; Password=fahim;";
                        OracleConnection con = new OracleConnection(constr);
                        con.Open();

                        OracleCommand cmd = new OracleCommand("Select id from Invoice where rownum <= 1 order by id DESC", con);

                        string invoiceId = cmd.ExecuteScalar().ToString();

                        foreach (ListViewItem ListItem in orderView.Items)
                        {
                            query2 = "INSERT into Sales(s_id, invoice_id, member_id, user_id, pid, s_date, quantity, t_price) Values (Sales_Seq.NEXTVAL, Invoice_Seq.CURRVAL, '"+ cid +"', " + x + ", '" + ListItem.SubItems[0].Text + "', '" + date + "', '" + ListItem.SubItems[2].Text + "', '" + ListItem.SubItems[3].Text + "')";

                            access.Command = new OracleCommand(query2, access.Connection);
                            access.Command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Invoice Successfully Inserted with InvoiceID: " + invoiceId);
                        //MessageBox.Show("Invoice Successfully Inserted");

                        new Report.PrintInvoice(invoiceId).Show();

                        cmd.Dispose();
                        con.Dispose();

                        this.LoadOrder();
                        this.LoadCustomer();
                        this.Refresh();
                        orderView.Items.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login lf = new Login();
            lf.Visible = true;
            this.Hide();
        }

        private void SalesmanFrame_Load(object sender, EventArgs e)
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

            LoadOrder();
            LoadCustomer();
            Refresh();
        }

        private void SalesmanFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sellTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string pid = sellTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = pid;
                this.LoadSingleOrder();
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (qtxt.Text == "")
            {
                MessageBox.Show("Enter Quantity");
                qtxt.Focus();
                return;
            }
            else if (isNew == true)
            {
                MessageBox.Show("Choose any Item");
                return;
            }

            string[] ar = new string[4];
            ar[0] = idtxt.Text;
            ar[1] = ppricetxt.Text;
            ar[2] = qtxt.Text;
            ar[3] = totaltxt.Text;

            ListViewItem lvi = new ListViewItem(ar);

            for (int i = orderView.Items.Count - 1; i >= 0; i--)
            {
                if (orderView.Items[i].ToString().ToLower().Contains(nametxt.Text.ToLower()))
                {
                    orderView.Items[i].SubItems[2].Text = (Convert.ToInt32(orderView.Items[i].SubItems[2].Text) + Convert.ToInt32(qtxt.Text)).ToString();
                    orderView.Items[i].SubItems[3].Text = (Convert.ToInt32(orderView.Items[i].SubItems[2].Text) * Convert.ToInt32(ppricetxt.Text)).ToString();
                    Refresh();
                    return;
                }
            }
            orderView.Items.Add(lvi);
            Refresh();
        }

        private void decreaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderView.SelectedItems != null)
                {
                    ListViewItem item = orderView.SelectedItems[0];

                    if (item.SubItems[2].Text == "0")
                    {
                        item.SubItems[2].Text = "0";
                        return;
                    }
                    item.SubItems[2].Text = (Convert.ToInt32(item.SubItems[2].Text) - Convert.ToInt32(1)).ToString();
                    item.SubItems[3].Text = (Convert.ToInt32(item.SubItems[1].Text) * Convert.ToInt32(item.SubItems[2].Text)).ToString();

                    orderView.SelectedItems.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void increaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderView.SelectedItems != null)
                {
                    ListViewItem item = orderView.SelectedItems[0];
                    item.SubItems[2].Text = (Convert.ToInt32(item.SubItems[2].Text) + Convert.ToInt32(1)).ToString();
                    item.SubItems[3].Text = (Convert.ToInt32(item.SubItems[1].Text) * Convert.ToInt32(item.SubItems[2].Text)).ToString();

                    orderView.SelectedItems.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void remBtn_Click(object sender, EventArgs e)
        {
            if (orderView.SelectedItems.Count > 0)
            {
                for (int i = 0; i < orderView.Items.Count; i++)
                {
                    if (orderView.Items[i].Selected)
                    {
                        orderView.Items[i].Remove();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
            orderView.Items.Clear();
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            Check();

            if (orderView.Items.Count > 0)
            {
                double sum = 0;
                foreach (ListViewItem lstItem in orderView.Items)
                {
                    sum += double.Parse(lstItem.SubItems[3].Text);
                    nettxt.Text = sum.ToString();
                }
            }
            else
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void qtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (qtxt.Text.Length > 0)
                {
                    totaltxt.Text = (Convert.ToInt32(ppricetxt.Text) * Convert.ToInt32(qtxt.Text)).ToString();
                    sellTable.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Integer Only!");
                qtxt.Text = "";
                qtxt.Focus();
            }
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {
            qtxt.Text = "";
            qtxt.Focus();
        }

        private void memberTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = memberTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                cidtxt.Text = id;
                this.LoadSingleCustomer();
            }
        }

        private void invoiceBtn_Click(object sender, EventArgs e)
        {
            new Report.PrintInvoice().Show();
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            DataAccess access = new DataAccess();

            string query = "Select * from Product Where name like '" + searchtxt.Text + "%'";

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            sellTable.AutoGenerateColumns = false;
            sellTable.DataSource = dt;
            sellTable.Refresh();
            sellTable.ClearSelection();
        }

        private void csearchtxt_TextChanged(object sender, EventArgs e)
        {
            DataAccess access = new DataAccess();

            string query = "Select * from Member Where name like '" + csearchtxt.Text + "%'";

            access.Command = new OracleCommand(query, access.Connection);
            access.Adapter = new OracleDataAdapter(access.Command);

            DataTable dt = new DataTable();
            access.Adapter.Fill(dt);

            if (dt == null)
                return;

            memberTable.AutoGenerateColumns = false;
            memberTable.DataSource = dt;
            memberTable.Refresh();
            memberTable.ClearSelection();
        }

        private void passBtn_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password();
            cp.Show(this);
            this.Hide();
        }
    }
}
