namespace Dan_Junkshop_Management_System
{
    partial class Orders
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
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnRemove = new OrganizationProfile.CustomButton();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Enabled = false;
            this.txtItemName.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtItemName.Location = new System.Drawing.Point(12, 13);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(135, 23);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.Text = "<ITEM NAME>";
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScale
            // 
            this.txtScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScale.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtScale.Location = new System.Drawing.Point(292, 11);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(87, 23);
            this.txtScale.TabIndex = 1;
            this.txtScale.Text = "0.00";
            this.txtScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtScale.TextChanged += new System.EventHandler(this.txtScale_TextChanged);
            this.txtScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScale_KeyPress);
            this.txtScale.Leave += new System.EventHandler(this.txtScale_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(167, 13);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(102, 23);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "PRICE/kg";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtSubtotal.Location = new System.Drawing.Point(401, 13);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(102, 23);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.Text = "0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemove.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnRemove.BorderColor = System.Drawing.Color.Transparent;
            this.btnRemove.BorderRadius = 29;
            this.btnRemove.BorderSize = 0;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemove.Image = global::Dan_Junkshop_Management_System.Properties.Resources.newCancel;
            this.btnRemove.Location = new System.Drawing.Point(533, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(29, 29);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.TextColor = System.Drawing.Color.Transparent;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtScale);
            this.Controls.Add(this.txtItemName);
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(586, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public OrganizationProfile.CustomButton btnRemove;
        public System.Windows.Forms.TextBox txtItemName;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtScale;
        public System.Windows.Forms.TextBox txtSubtotal;
    }
}
