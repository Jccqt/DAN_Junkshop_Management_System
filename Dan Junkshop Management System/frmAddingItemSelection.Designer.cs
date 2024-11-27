namespace Dan_Junkshop_Management_System
{
    partial class frmAddingItemSelection
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
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnNewSellTransaction = new OrganizationProfile.CustomButton();
            this.btnNewTransaction = new OrganizationProfile.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 50);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Item";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.exit1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(697, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 26);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewSellTransaction
            // 
            this.btnNewSellTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnNewSellTransaction.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNewSellTransaction.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.game_icons_pay_money__1_;
            this.btnNewSellTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewSellTransaction.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewSellTransaction.BorderRadius = 40;
            this.btnNewSellTransaction.BorderSize = 0;
            this.btnNewSellTransaction.FlatAppearance.BorderSize = 0;
            this.btnNewSellTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSellTransaction.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNewSellTransaction.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewSellTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSellTransaction.Location = new System.Drawing.Point(409, 85);
            this.btnNewSellTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewSellTransaction.Name = "btnNewSellTransaction";
            this.btnNewSellTransaction.Size = new System.Drawing.Size(226, 162);
            this.btnNewSellTransaction.TabIndex = 36;
            this.btnNewSellTransaction.TextColor = System.Drawing.Color.Transparent;
            this.btnNewSellTransaction.UseVisualStyleBackColor = false;
            this.btnNewSellTransaction.Click += new System.EventHandler(this.btnNewSellTransaction_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTransaction.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNewTransaction.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.mdi_recycle;
            this.btnNewTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewTransaction.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewTransaction.BorderRadius = 20;
            this.btnNewTransaction.BorderSize = 1;
            this.btnNewTransaction.FlatAppearance.BorderSize = 0;
            this.btnNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTransaction.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNewTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewTransaction.Location = new System.Drawing.Point(91, 85);
            this.btnNewTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(226, 162);
            this.btnNewTransaction.TabIndex = 35;
            this.btnNewTransaction.TextColor = System.Drawing.SystemColors.ControlText;
            this.btnNewTransaction.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(438, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "New Sellable Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 28);
            this.label3.TabIndex = 38;
            this.label3.Text = "New Scrap Item";
            // 
            // frmAddingItemSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 356);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNewSellTransaction);
            this.Controls.Add(this.btnNewTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAddingItemSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddingItemSelection";
            this.Load += new System.EventHandler(this.frmAddingItemSelection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label1;
        private OrganizationProfile.CustomButton btnNewSellTransaction;
        private OrganizationProfile.CustomButton btnNewTransaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}