namespace Grocery_Shop_Management_System.Report
{
    partial class PrintInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable_InvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Grocery_Shop_Management_System.Report.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.inlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_InvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable_InvoiceBindingSource
            // 
            this.DataTable_InvoiceBindingSource.DataMember = "DataTable_Invoice";
            this.DataTable_InvoiceBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.DarkCyan;
            reportDataSource4.Name = "DataSet_Report";
            reportDataSource4.Value = this.DataTable_InvoiceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Grocery_Shop_Management_System.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(689, 405);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchtxt);
            this.panel1.Controls.Add(this.inlabel);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 44);
            this.panel1.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Yellow;
            this.searchBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(444, 7);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(88, 30);
            this.searchBtn.TabIndex = 137;
            this.searchBtn.TabStop = false;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.BackColor = System.Drawing.Color.DarkCyan;
            this.searchtxt.Font = new System.Drawing.Font("Cambria", 12F);
            this.searchtxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchtxt.Location = new System.Drawing.Point(239, 9);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(190, 26);
            this.searchtxt.TabIndex = 136;
            this.searchtxt.TabStop = false;
            // 
            // inlabel
            // 
            this.inlabel.AutoSize = true;
            this.inlabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.inlabel.ForeColor = System.Drawing.Color.Black;
            this.inlabel.Location = new System.Drawing.Point(141, 12);
            this.inlabel.Name = "inlabel";
            this.inlabel.Size = new System.Drawing.Size(90, 19);
            this.inlabel.TabIndex = 75;
            this.inlabel.Text = "Invoice No:";
            // 
            // PrintInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(590, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintInvoice";
            this.Load += new System.EventHandler(this.PrintInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_InvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label inlabel;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.BindingSource DataTable_InvoiceBindingSource;
        private DataSet1 DataSet1;
    }
}