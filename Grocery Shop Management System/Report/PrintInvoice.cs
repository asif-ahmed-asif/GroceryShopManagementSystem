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
using Microsoft.Reporting.WinForms;

namespace Grocery_Shop_Management_System.Report
{
    public partial class PrintInvoice : Form
    {
        public PrintInvoice()
        {
            InitializeComponent();
        }

        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            OracleDataAdapter sda = new OracleDataAdapter("SELECT * from Print_Invoice Where id = '" + searchtxt.Text + "'", "Data Source=Mustafiz; User ID=Adms; Password=fahim;");

            DataSet1 ds = new DataSet1();
            sda.Fill(ds, "DataTable_Invoice");

            ReportDataSource rds = new ReportDataSource("DataSet_Report", ds.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
