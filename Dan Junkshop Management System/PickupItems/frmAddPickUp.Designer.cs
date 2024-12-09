namespace Dan_Junkshop_Management_System
{
    partial class frmAddPickUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtScaleQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlantPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnCancel = new OrganizationProfile.CustomButton();
            this.btnProcess = new OrganizationProfile.CustomButton();
            this.lblPickupID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbSellableItems = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalOwned = new System.Windows.Forms.TextBox();
            this.cbPartners = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtItemClass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 46);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Item to Pick-up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pick-up ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sellable Item Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Partner:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Scale quantity to pickup:";
            // 
            // txtScaleQuantity
            // 
            this.txtScaleQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScaleQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScaleQuantity.Location = new System.Drawing.Point(52, 260);
            this.txtScaleQuantity.Name = "txtScaleQuantity";
            this.txtScaleQuantity.Size = new System.Drawing.Size(250, 26);
            this.txtScaleQuantity.TabIndex = 24;
            this.txtScaleQuantity.Text = "0.00";
            this.txtScaleQuantity.TextChanged += new System.EventHandler(this.txtScaleQuantity_TextChanged);
            this.txtScaleQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScaleQuantity_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Plant Price/kg:";
            // 
            // txtPlantPrice
            // 
            this.txtPlantPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlantPrice.Enabled = false;
            this.txtPlantPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlantPrice.Location = new System.Drawing.Point(411, 260);
            this.txtPlantPrice.Name = "txtPlantPrice";
            this.txtPlantPrice.Size = new System.Drawing.Size(250, 26);
            this.txtPlantPrice.TabIndex = 26;
            this.txtPlantPrice.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(411, 348);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(250, 26);
            this.txtTotalAmount.TabIndex = 28;
            this.txtTotalAmount.Text = "0.00";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 40;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Black", 7.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(592, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 44);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Transparent;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnProcess.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnProcess.BorderColor = System.Drawing.Color.Transparent;
            this.btnProcess.BorderRadius = 40;
            this.btnProcess.BorderSize = 0;
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Arial Black", 7.75F, System.Drawing.FontStyle.Bold);
            this.btnProcess.ForeColor = System.Drawing.Color.Transparent;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.Location = new System.Drawing.Point(449, 406);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(132, 44);
            this.btnProcess.TabIndex = 38;
            this.btnProcess.Text = "Process";
            this.btnProcess.TextColor = System.Drawing.Color.Transparent;
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblPickupID
            // 
            this.lblPickupID.AutoSize = true;
            this.lblPickupID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickupID.Location = new System.Drawing.Point(136, 63);
            this.lblPickupID.Name = "lblPickupID";
            this.lblPickupID.Size = new System.Drawing.Size(104, 19);
            this.lblPickupID.TabIndex = 40;
            this.lblPickupID.Text = "< PickupID >";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(136, 100);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 19);
            this.lblDate.TabIndex = 41;
            this.lblDate.Text = "< Date >";
            // 
            // cbSellableItems
            // 
            this.cbSellableItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSellableItems.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSellableItems.FormattingEnabled = true;
            this.cbSellableItems.Location = new System.Drawing.Point(52, 180);
            this.cbSellableItems.Name = "cbSellableItems";
            this.cbSellableItems.Size = new System.Drawing.Size(250, 26);
            this.cbSellableItems.TabIndex = 42;
            this.cbSellableItems.SelectedIndexChanged += new System.EventHandler(this.cbSellableItems_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "Total owned scale quantity:";
            // 
            // txtTotalOwned
            // 
            this.txtTotalOwned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalOwned.Enabled = false;
            this.txtTotalOwned.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOwned.Location = new System.Drawing.Point(52, 348);
            this.txtTotalOwned.Name = "txtTotalOwned";
            this.txtTotalOwned.Size = new System.Drawing.Size(250, 26);
            this.txtTotalOwned.TabIndex = 43;
            this.txtTotalOwned.Text = "0.00";
            // 
            // cbPartners
            // 
            this.cbPartners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartners.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPartners.FormattingEnabled = true;
            this.cbPartners.Location = new System.Drawing.Point(411, 85);
            this.cbPartners.Name = "cbPartners";
            this.cbPartners.Size = new System.Drawing.Size(313, 26);
            this.cbPartners.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(407, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "Item Class";
            // 
            // txtItemClass
            // 
            this.txtItemClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemClass.Enabled = false;
            this.txtItemClass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemClass.Location = new System.Drawing.Point(411, 175);
            this.txtItemClass.Name = "txtItemClass";
            this.txtItemClass.Size = new System.Drawing.Size(250, 26);
            this.txtItemClass.TabIndex = 46;
            // 
            // frmAddPickUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(753, 472);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtItemClass);
            this.Controls.Add(this.cbPartners);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalOwned);
            this.Controls.Add(this.cbSellableItems);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPickupID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlantPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtScaleQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddPickUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddPickUp";
            this.Load += new System.EventHandler(this.frmAddPickUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtScaleQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlantPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private OrganizationProfile.CustomButton btnCancel;
        private OrganizationProfile.CustomButton btnProcess;
        private System.Windows.Forms.Label lblPickupID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbSellableItems;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalOwned;
        private System.Windows.Forms.ComboBox cbPartners;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtItemClass;
    }
}