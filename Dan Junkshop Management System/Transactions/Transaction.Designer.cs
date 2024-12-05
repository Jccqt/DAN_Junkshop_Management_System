namespace Dan_Junkshop_Management_System
{
    partial class Transaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridTransactions = new System.Windows.Forms.DataGridView();
            this.btnAddTransaction = new OrganizationProfile.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTransactions
            // 
            this.gridTransactions.AllowUserToAddRows = false;
            this.gridTransactions.AllowUserToDeleteRows = false;
            this.gridTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTransactions.BackgroundColor = System.Drawing.Color.White;
            this.gridTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTransactions.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridTransactions.EnableHeadersVisualStyles = false;
            this.gridTransactions.GridColor = System.Drawing.Color.Black;
            this.gridTransactions.Location = new System.Drawing.Point(6, 107);
            this.gridTransactions.Name = "gridTransactions";
            this.gridTransactions.ReadOnly = true;
            this.gridTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridTransactions.RowHeadersVisible = false;
            this.gridTransactions.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.gridTransactions.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridTransactions.Size = new System.Drawing.Size(920, 599);
            this.gridTransactions.TabIndex = 1;
            this.gridTransactions.Tag = "";
            this.gridTransactions.VirtualMode = true;
            this.gridTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTransactions_CellContentClick);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnAddTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnAddTransaction.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddTransaction.BorderRadius = 40;
            this.btnAddTransaction.BorderSize = 0;
            this.btnAddTransaction.FlatAppearance.BorderSize = 0;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Font = new System.Drawing.Font("Arial Black", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnAddTransaction.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddTransaction.Image = global::Dan_Junkshop_Management_System.Properties.Resources.newAddCircle;
            this.btnAddTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTransaction.Location = new System.Drawing.Point(758, 44);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(168, 45);
            this.btnAddTransaction.TabIndex = 0;
            this.btnAddTransaction.Text = "        Add Transaction";
            this.btnAddTransaction.TextColor = System.Drawing.Color.Transparent;
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gridTransactions);
            this.Controls.Add(this.btnAddTransaction);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(934, 736);
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OrganizationProfile.CustomButton btnAddTransaction;
        private System.Windows.Forms.DataGridView gridTransactions;
    }
}
