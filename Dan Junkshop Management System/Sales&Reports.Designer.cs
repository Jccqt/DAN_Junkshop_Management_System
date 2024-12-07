namespace Dan_Junkshop_Management_System
{
    partial class Sales_Reports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReport1 = new System.Windows.Forms.Button();
            this.btnReport2 = new System.Windows.Forms.Button();
            this.btnReport3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTable = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.gridTopReports = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopReports)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReport1
            // 
            this.btnReport1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReport1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.btnReport1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport1.ForeColor = System.Drawing.Color.White;
            this.btnReport1.Location = new System.Drawing.Point(269, 40);
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.Size = new System.Drawing.Size(120, 37);
            this.btnReport1.TabIndex = 0;
            this.btnReport1.Text = "Top Sale";
            this.btnReport1.UseVisualStyleBackColor = false;
            this.btnReport1.Click += new System.EventHandler(this.btnReport1_Click);
            // 
            // btnReport2
            // 
            this.btnReport2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReport2.BackColor = System.Drawing.Color.White;
            this.btnReport2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnReport2.Location = new System.Drawing.Point(390, 40);
            this.btnReport2.Name = "btnReport2";
            this.btnReport2.Size = new System.Drawing.Size(120, 37);
            this.btnReport2.TabIndex = 1;
            this.btnReport2.Text = "Top Items";
            this.btnReport2.UseVisualStyleBackColor = false;
            this.btnReport2.Click += new System.EventHandler(this.btnReport2_Click);
            // 
            // btnReport3
            // 
            this.btnReport3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReport3.BackColor = System.Drawing.Color.White;
            this.btnReport3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport3.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnReport3.Location = new System.Drawing.Point(511, 40);
            this.btnReport3.Name = "btnReport3";
            this.btnReport3.Size = new System.Drawing.Size(120, 37);
            this.btnReport3.TabIndex = 2;
            this.btnReport3.Text = "Top Partners";
            this.btnReport3.UseVisualStyleBackColor = false;
            this.btnReport3.Click += new System.EventHandler(this.btnReport3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.lblTable);
            this.panel1.Location = new System.Drawing.Point(31, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 34);
            this.panel1.TabIndex = 3;
            // 
            // lblTable
            // 
            this.lblTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.White;
            this.lblTable.Location = new System.Drawing.Point(385, 8);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(69, 18);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "Top Sale";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridTopReports
            // 
            this.gridTopReports.AllowUserToAddRows = false;
            this.gridTopReports.AllowUserToDeleteRows = false;
            this.gridTopReports.AllowUserToResizeColumns = false;
            this.gridTopReports.AllowUserToResizeRows = false;
            this.gridTopReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTopReports.BackgroundColor = System.Drawing.Color.White;
            this.gridTopReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTopReports.Location = new System.Drawing.Point(31, 188);
            this.gridTopReports.Margin = new System.Windows.Forms.Padding(2);
            this.gridTopReports.Name = "gridTopReports";
            this.gridTopReports.ReadOnly = true;
            this.gridTopReports.RowHeadersWidth = 51;
            this.gridTopReports.RowTemplate.Height = 24;
            this.gridTopReports.Size = new System.Drawing.Size(873, 454);
            this.gridTopReports.TabIndex = 9;
            this.gridTopReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Sales_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gridTopReports);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReport3);
            this.Controls.Add(this.btnReport2);
            this.Controls.Add(this.btnReport1);
            this.Name = "Sales_Reports";
            this.Size = new System.Drawing.Size(934, 736);
            this.Load += new System.EventHandler(this.Sales_Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReport1;
        private System.Windows.Forms.Button btnReport2;
        private System.Windows.Forms.Button btnReport3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView gridTopReports;
    }
}
