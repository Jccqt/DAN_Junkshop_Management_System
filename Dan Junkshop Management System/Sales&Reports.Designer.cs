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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Reports));
            this.topSaleButton = new System.Windows.Forms.Button();
            this.transactionButton = new System.Windows.Forms.Button();
            this.deliveryButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panelBorder2 = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelBorder2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // topSaleButton
            // 
            this.topSaleButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topSaleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.topSaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.topSaleButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topSaleButton.ForeColor = System.Drawing.Color.White;
            this.topSaleButton.Location = new System.Drawing.Point(268, 27);
            this.topSaleButton.Name = "topSaleButton";
            this.topSaleButton.Size = new System.Drawing.Size(120, 37);
            this.topSaleButton.TabIndex = 0;
            this.topSaleButton.Text = "Top Sale";
            this.topSaleButton.UseVisualStyleBackColor = false;
            this.topSaleButton.Click += new System.EventHandler(this.topSaleButton_Click);
            // 
            // transactionButton
            // 
            this.transactionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.transactionButton.BackColor = System.Drawing.Color.White;
            this.transactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.transactionButton.Font = new System.Drawing.Font("Arial", 11.25F);
            this.transactionButton.Location = new System.Drawing.Point(390, 27);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(120, 37);
            this.transactionButton.TabIndex = 1;
            this.transactionButton.Text = "Transaction";
            this.transactionButton.UseVisualStyleBackColor = false;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // deliveryButton
            // 
            this.deliveryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deliveryButton.BackColor = System.Drawing.Color.White;
            this.deliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deliveryButton.Font = new System.Drawing.Font("Arial", 11.25F);
            this.deliveryButton.Location = new System.Drawing.Point(512, 27);
            this.deliveryButton.Name = "deliveryButton";
            this.deliveryButton.Size = new System.Drawing.Size(120, 37);
            this.deliveryButton.TabIndex = 2;
            this.deliveryButton.Text = "Delivery";
            this.deliveryButton.UseVisualStyleBackColor = false;
            this.deliveryButton.Click += new System.EventHandler(this.deliveryButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 34);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(385, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top Sale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 20.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(25, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 40);
            this.label9.TabIndex = 6;
            this.label9.Text = "Activity Log";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 282);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(32, 525);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(872, 209);
            this.dataGridView2.TabIndex = 10;
            // 
            // panelBorder2
            // 
            this.panelBorder2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorder2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBorder2.BackColor = System.Drawing.Color.White;
            this.panelBorder2.BorderRadius = 30;
            this.panelBorder2.Color = System.Drawing.Color.BurlyWood;
            this.panelBorder2.Controls.Add(this.pictureBox2);
            this.panelBorder2.Controls.Add(this.comboBox1);
            this.panelBorder2.ForeColor = System.Drawing.Color.Black;
            this.panelBorder2.Location = new System.Drawing.Point(733, 463);
            this.panelBorder2.Name = "panelBorder2";
            this.panelBorder2.Size = new System.Drawing.Size(172, 44);
            this.panelBorder2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(4, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 16F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Location = new System.Drawing.Point(41, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // Sales_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelBorder2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deliveryButton);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.topSaleButton);
            this.Name = "Sales_Reports";
            this.Size = new System.Drawing.Size(934, 736);
            this.Load += new System.EventHandler(this.Sales_Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelBorder2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topSaleButton;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.Button deliveryButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
