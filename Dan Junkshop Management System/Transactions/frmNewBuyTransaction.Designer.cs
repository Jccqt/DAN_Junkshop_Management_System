namespace Dan_Junkshop_Management_System
{
    partial class frmNewBuyTransaction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.gridViewItems = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddItem = new OrganizationProfile.CustomButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelTransaction = new OrganizationProfile.CustomButton();
            this.btnProcessTransaction = new OrganizationProfile.CustomButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbWalkin = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1685, 62);
            this.panel1.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.Red;
            this.headerLabel.Location = new System.Drawing.Point(19, 9);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(339, 48);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "New Transaction";
            // 
            // gridViewItems
            // 
            this.gridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.gridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewItems.Location = new System.Drawing.Point(29, 254);
            this.gridViewItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridViewItems.Name = "gridViewItems";
            this.gridViewItems.RowHeadersWidth = 51;
            this.gridViewItems.Size = new System.Drawing.Size(793, 654);
            this.gridViewItems.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTotalPrice);
            this.panel4.Controls.Add(this.lblTotalItems);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(859, 657);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(781, 146);
            this.panel4.TabIndex = 8;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(489, 94);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(188, 32);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "< Total Price >";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(489, 25);
            this.lblTotalItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(194, 32);
            this.lblTotalItems.TabIndex = 2;
            this.lblTotalItems.Text = "< Total Items >";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Items";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel5.Controls.Add(this.btnAddItem);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(29, 204);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(793, 50);
            this.panel5.TabIndex = 7;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnAddItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnAddItem.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddItem.BorderRadius = 35;
            this.btnAddItem.BorderSize = 0;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddItem.Image = global::Dan_Junkshop_Management_System.Properties.Resources.newAddCircle;
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.Location = new System.Drawing.Point(599, 4);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(180, 43);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "      ADD NEW ITEM";
            this.btnAddItem.TextColor = System.Drawing.Color.Transparent;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(33, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "List of sellable items";
            // 
            // btnCancelTransaction
            // 
            this.btnCancelTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelTransaction.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelTransaction.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnCancelTransaction.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelTransaction.BorderRadius = 40;
            this.btnCancelTransaction.BorderSize = 0;
            this.btnCancelTransaction.FlatAppearance.BorderSize = 0;
            this.btnCancelTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTransaction.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTransaction.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelTransaction.Location = new System.Drawing.Point(1419, 828);
            this.btnCancelTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelTransaction.Name = "btnCancelTransaction";
            this.btnCancelTransaction.Size = new System.Drawing.Size(208, 66);
            this.btnCancelTransaction.TabIndex = 16;
            this.btnCancelTransaction.Text = "CANCEL TRANSACTION";
            this.btnCancelTransaction.TextColor = System.Drawing.Color.Transparent;
            this.btnCancelTransaction.UseVisualStyleBackColor = false;
            this.btnCancelTransaction.Click += new System.EventHandler(this.btnCancelTransaction_Click);
            // 
            // btnProcessTransaction
            // 
            this.btnProcessTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnProcessTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnProcessTransaction.BorderColor = System.Drawing.Color.Transparent;
            this.btnProcessTransaction.BorderRadius = 40;
            this.btnProcessTransaction.BorderSize = 0;
            this.btnProcessTransaction.FlatAppearance.BorderSize = 0;
            this.btnProcessTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessTransaction.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessTransaction.ForeColor = System.Drawing.Color.Transparent;
            this.btnProcessTransaction.Location = new System.Drawing.Point(1187, 828);
            this.btnProcessTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProcessTransaction.Name = "btnProcessTransaction";
            this.btnProcessTransaction.Size = new System.Drawing.Size(208, 66);
            this.btnProcessTransaction.TabIndex = 17;
            this.btnProcessTransaction.Text = " PROCESS TRANSACTION";
            this.btnProcessTransaction.TextColor = System.Drawing.Color.Transparent;
            this.btnProcessTransaction.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(859, 254);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(781, 328);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.lblCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(859, 204);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 50);
            this.panel2.TabIndex = 6;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(121, 12);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(99, 28);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "<count>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item -";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(859, 608);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 50);
            this.panel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Summary";
            // 
            // cbSupplier
            // 
            this.cbSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSupplier.AutoSize = true;
            this.cbSupplier.Font = new System.Drawing.Font("Arial", 12.25F);
            this.cbSupplier.Location = new System.Drawing.Point(560, 126);
            this.cbSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(117, 28);
            this.cbSupplier.TabIndex = 9;
            this.cbSupplier.Text = "Suppliers";
            this.cbSupplier.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Transaction ID:";
            // 
            // cbWalkin
            // 
            this.cbWalkin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbWalkin.AutoSize = true;
            this.cbWalkin.Checked = true;
            this.cbWalkin.Font = new System.Drawing.Font("Arial", 12.25F);
            this.cbWalkin.Location = new System.Drawing.Point(443, 126);
            this.cbWalkin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbWalkin.Name = "cbWalkin";
            this.cbWalkin.Size = new System.Drawing.Size(100, 28);
            this.cbWalkin.TabIndex = 11;
            this.cbWalkin.TabStop = true;
            this.cbWalkin.Text = "Walk-in";
            this.cbWalkin.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1272, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1272, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Time: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1353, 85);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(76, 23);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "<Date>";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1353, 128);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(76, 23);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "<Time>";
            // 
            // lblTransaction
            // 
            this.lblTransaction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.Location = new System.Drawing.Point(595, 85);
            this.lblTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(147, 23);
            this.lblTransaction.TabIndex = 18;
            this.lblTransaction.Text = "< Transaction >";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.reddanjunkshop1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, -20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 295);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmNewBuyTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1685, 937);
            this.ControlBox = false;
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.btnProcessTransaction);
            this.Controls.Add(this.btnCancelTransaction);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.cbWalkin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gridViewItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewBuyTransaction";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTransaction";
            this.Load += new System.EventHandler(this.NewBuyTransaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gridViewItems;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel5;
        private OrganizationProfile.CustomButton btnAddItem;
        private System.Windows.Forms.Label label8;
        private OrganizationProfile.CustomButton btnCancelTransaction;
        private OrganizationProfile.CustomButton btnProcessTransaction;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton cbSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton cbWalkin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalItems;
    }
}