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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonths = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.gridTopReports = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.cbYear);
            this.panel1.Controls.Add(this.cbMonths);
            this.panel1.Controls.Add(this.lblTable);
            this.panel1.Location = new System.Drawing.Point(31, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 34);
            this.panel1.TabIndex = 3;
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbYear.Location = new System.Drawing.Point(595, 5);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(117, 24);
            this.cbYear.TabIndex = 2;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // cbMonths
            // 
            this.cbMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonths.FormattingEnabled = true;
            this.cbMonths.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonths.Location = new System.Drawing.Point(428, 5);
            this.cbMonths.Name = "cbMonths";
            this.cbMonths.Size = new System.Drawing.Size(161, 24);
            this.cbMonths.TabIndex = 1;
            this.cbMonths.SelectedIndexChanged += new System.EventHandler(this.cbMonths_SelectedIndexChanged);
            // 
            // lblTable
            // 
            this.lblTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.White;
            this.lblTable.Location = new System.Drawing.Point(235, 8);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(187, 18);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "Top Sales for the month of";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridTopReports
            // 
            this.gridTopReports.AllowUserToAddRows = false;
            this.gridTopReports.AllowUserToDeleteRows = false;
            this.gridTopReports.AllowUserToResizeColumns = false;
            this.gridTopReports.AllowUserToResizeRows = false;
            this.gridTopReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTopReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTopReports.BackgroundColor = System.Drawing.Color.White;
            this.gridTopReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTopReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTopReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTopReports.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTopReports.EnableHeadersVisualStyles = false;
            this.gridTopReports.Location = new System.Drawing.Point(31, 107);
            this.gridTopReports.Margin = new System.Windows.Forms.Padding(2);
            this.gridTopReports.Name = "gridTopReports";
            this.gridTopReports.ReadOnly = true;
            this.gridTopReports.RowHeadersVisible = false;
            this.gridTopReports.RowHeadersWidth = 51;
            this.gridTopReports.RowTemplate.Height = 24;
            this.gridTopReports.Size = new System.Drawing.Size(873, 603);
            this.gridTopReports.TabIndex = 9;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.White;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(772, 44);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 23);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate Reports";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Sales_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gridTopReports);
            this.Controls.Add(this.panel1);
            this.Name = "Sales_Reports";
            this.Size = new System.Drawing.Size(934, 736);
            this.Load += new System.EventHandler(this.Sales_Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView gridTopReports;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cbMonths;
        private System.Windows.Forms.ComboBox cbYear;
    }
}
