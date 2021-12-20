namespace Grocery_Shop_Management_System
{
    partial class ManageProduct
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvjdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cnametxt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctxt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.qttxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.spricetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ppricetxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 365);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchtxt);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 41);
            this.panel1.TabIndex = 0;
            // 
            // searchtxt
            // 
            this.searchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.searchtxt.Font = new System.Drawing.Font("Cambria", 12F);
            this.searchtxt.ForeColor = System.Drawing.Color.White;
            this.searchtxt.Location = new System.Drawing.Point(200, 6);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(218, 26);
            this.searchtxt.TabIndex = 11;
            this.searchtxt.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Yellow;
            this.searchBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.searchBtn.Location = new System.Drawing.Point(424, 2);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(88, 35);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.TabStop = false;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.refreshBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.refreshBtn.Location = new System.Drawing.Point(95, 2);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(99, 35);
            this.refreshBtn.TabIndex = 9;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(631, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 41);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(73, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "<< Product Details >> ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.productTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 308);
            this.panel3.TabIndex = 2;
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvmname,
            this.dgvjdate});
            this.productTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTable.GridColor = System.Drawing.Color.Maroon;
            this.productTable.Location = new System.Drawing.Point(0, 0);
            this.productTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productTable.Name = "productTable";
            this.productTable.ReadOnly = true;
            this.productTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productTable.Size = new System.Drawing.Size(622, 308);
            this.productTable.TabIndex = 0;
            this.productTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productTable_CellClick);
            // 
            // dgvid
            // 
            this.dgvid.DataPropertyName = "pid";
            this.dgvid.HeaderText = "ID";
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Width = 60;
            // 
            // dgvmname
            // 
            this.dgvmname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvmname.DataPropertyName = "name";
            this.dgvmname.FillWeight = 54.0146F;
            this.dgvmname.HeaderText = "Product Name";
            this.dgvmname.Name = "dgvmname";
            this.dgvmname.ReadOnly = true;
            // 
            // dgvjdate
            // 
            this.dgvjdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvjdate.DataPropertyName = "quantity";
            this.dgvjdate.FillWeight = 145.9854F;
            this.dgvjdate.HeaderText = "Quantity";
            this.dgvjdate.Name = "dgvjdate";
            this.dgvjdate.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cnametxt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.ctxt);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.delBtn);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.qttxt);
            this.panel4.Controls.Add(this.saveBtn);
            this.panel4.Controls.Add(this.logoutBtn);
            this.panel4.Controls.Add(this.backBtn);
            this.panel4.Controls.Add(this.spricetxt);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.ppricetxt);
            this.panel4.Controls.Add(this.nametxt);
            this.panel4.Controls.Add(this.idtxt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(631, 53);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 308);
            this.panel4.TabIndex = 3;
            // 
            // cnametxt
            // 
            this.cnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.cnametxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.cnametxt.ForeColor = System.Drawing.Color.White;
            this.cnametxt.FormattingEnabled = true;
            this.cnametxt.Location = new System.Drawing.Point(140, 198);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(213, 25);
            this.cnametxt.TabIndex = 112;
            this.cnametxt.Text = "Category Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 111;
            this.label4.Text = "Category Name:";
            // 
            // ctxt
            // 
            this.ctxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ctxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.ctxt.ForeColor = System.Drawing.Color.White;
            this.ctxt.FormattingEnabled = true;
            this.ctxt.Location = new System.Drawing.Point(140, 167);
            this.ctxt.Name = "ctxt";
            this.ctxt.Size = new System.Drawing.Size(213, 25);
            this.ctxt.TabIndex = 109;
            this.ctxt.Text = "Select Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 108;
            this.label7.Text = "Category ID:";
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.delBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(92, 268);
            this.delBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(90, 35);
            this.delBtn.TabIndex = 107;
            this.delBtn.TabStop = false;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(62, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 97;
            this.label10.Text = "Quantity:";
            // 
            // qttxt
            // 
            this.qttxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.qttxt.CausesValidation = false;
            this.qttxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.qttxt.ForeColor = System.Drawing.Color.White;
            this.qttxt.Location = new System.Drawing.Point(140, 135);
            this.qttxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.qttxt.Name = "qttxt";
            this.qttxt.Size = new System.Drawing.Size(213, 25);
            this.qttxt.TabIndex = 96;
            this.qttxt.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.saveBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(2, 268);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 35);
            this.saveBtn.TabIndex = 92;
            this.saveBtn.TabStop = false;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.logoutBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(276, 268);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(90, 35);
            this.logoutBtn.TabIndex = 91;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.backBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(185, 268);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(88, 35);
            this.backBtn.TabIndex = 90;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // spricetxt
            // 
            this.spricetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.spricetxt.CausesValidation = false;
            this.spricetxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.spricetxt.ForeColor = System.Drawing.Color.White;
            this.spricetxt.Location = new System.Drawing.Point(140, 104);
            this.spricetxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.spricetxt.Name = "spricetxt";
            this.spricetxt.Size = new System.Drawing.Size(213, 25);
            this.spricetxt.TabIndex = 84;
            this.spricetxt.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Selling Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 82;
            this.label2.Text = "Purchase Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Product Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "Product ID:";
            // 
            // ppricetxt
            // 
            this.ppricetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ppricetxt.CausesValidation = false;
            this.ppricetxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.ppricetxt.ForeColor = System.Drawing.Color.White;
            this.ppricetxt.Location = new System.Drawing.Point(140, 72);
            this.ppricetxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ppricetxt.Name = "ppricetxt";
            this.ppricetxt.Size = new System.Drawing.Size(213, 25);
            this.ppricetxt.TabIndex = 79;
            this.ppricetxt.TabStop = false;
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.nametxt.CausesValidation = false;
            this.nametxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.nametxt.ForeColor = System.Drawing.Color.White;
            this.nametxt.Location = new System.Drawing.Point(140, 40);
            this.nametxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(213, 25);
            this.nametxt.TabIndex = 78;
            this.nametxt.TabStop = false;
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.idtxt.CausesValidation = false;
            this.idtxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.idtxt.ForeColor = System.Drawing.Color.White;
            this.idtxt.Location = new System.Drawing.Point(140, 8);
            this.idtxt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(213, 25);
            this.idtxt.TabIndex = 77;
            this.idtxt.TabStop = false;
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1001, 365);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageProduct_FormClosed);
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox qttxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox spricetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ppricetxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.ComboBox ctxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvjdate;
        private System.Windows.Forms.ComboBox cnametxt;
        private System.Windows.Forms.Label label4;
    }
}