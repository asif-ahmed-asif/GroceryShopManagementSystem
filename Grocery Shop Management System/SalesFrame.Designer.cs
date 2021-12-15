namespace Grocery_Shop_Management_System
{
    partial class SalesFrame
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartMostSoldProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMostBenefitProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMostSoldProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMostBenefitProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMostSoldProduct
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMostSoldProduct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMostSoldProduct.Legends.Add(legend1);
            this.chartMostSoldProduct.Location = new System.Drawing.Point(40, 105);
            this.chartMostSoldProduct.Name = "chartMostSoldProduct";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.chartMostSoldProduct.Series.Add(series1);
            this.chartMostSoldProduct.Size = new System.Drawing.Size(713, 404);
            this.chartMostSoldProduct.TabIndex = 0;
            this.chartMostSoldProduct.Text = "chartMostSoldProduct";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.Black;
            title1.Text = "Top sold Products";
            this.chartMostSoldProduct.Titles.Add(title1);
            // 
            // chartMostBenefitProduct
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMostBenefitProduct.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMostBenefitProduct.Legends.Add(legend2);
            this.chartMostBenefitProduct.Location = new System.Drawing.Point(777, 105);
            this.chartMostBenefitProduct.Name = "chartMostBenefitProduct";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Benefit";
            this.chartMostBenefitProduct.Series.Add(series2);
            this.chartMostBenefitProduct.Size = new System.Drawing.Size(735, 404);
            this.chartMostBenefitProduct.TabIndex = 1;
            this.chartMostBenefitProduct.Text = "chartMostBenefitProduct";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.ShadowColor = System.Drawing.Color.Black;
            title2.Text = "Top Benifited Products";
            this.chartMostBenefitProduct.Titles.Add(title2);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(655, 559);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(227, 66);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(402, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Today\'s Benefit : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(962, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last 30 Days Benefit : ";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToday.Location = new System.Drawing.Point(583, 37);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(59, 28);
            this.lblToday.TabIndex = 5;
            this.lblToday.Text = "0 TK";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMonth.Location = new System.Drawing.Point(1192, 37);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(59, 28);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "0 TK";
            // 
            // SalesFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1542, 641);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chartMostBenefitProduct);
            this.Controls.Add(this.chartMostSoldProduct);
            this.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SalesFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Frame";
            this.Load += new System.EventHandler(this.SalesFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMostSoldProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMostBenefitProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMostSoldProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMostBenefitProduct;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblMonth;
    }
}