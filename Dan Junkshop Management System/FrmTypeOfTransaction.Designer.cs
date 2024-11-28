namespace Dan_Junkshop_Management_System
{
    partial class frmTypeOfTransaction
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
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewSellTransaction = new OrganizationProfile.CustomButton();
            this.btnNewBuyTransaction = new OrganizationProfile.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 41);
            this.panel1.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.exit1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(523, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 21);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of transaction";
            // 
            // btnNewSellTransaction
            // 
            this.btnNewSellTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.btnNewSellTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.btnNewSellTransaction.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewSellTransaction.BorderRadius = 40;
            this.btnNewSellTransaction.BorderSize = 0;
            this.btnNewSellTransaction.FlatAppearance.BorderSize = 0;
            this.btnNewSellTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSellTransaction.Font = new System.Drawing.Font("Arial Black", 7.75F, System.Drawing.FontStyle.Bold);
            this.btnNewSellTransaction.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewSellTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSellTransaction.Location = new System.Drawing.Point(299, 82);
            this.btnNewSellTransaction.Name = "btnNewSellTransaction";
            this.btnNewSellTransaction.Size = new System.Drawing.Size(140, 58);
            this.btnNewSellTransaction.TabIndex = 33;
            this.btnNewSellTransaction.Text = "New Transaction (SELL)";
            this.btnNewSellTransaction.TextColor = System.Drawing.Color.Transparent;
            this.btnNewSellTransaction.UseVisualStyleBackColor = false;
            // 
            // btnNewBuyTransaction
            // 
            this.btnNewBuyTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnNewBuyTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnNewBuyTransaction.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewBuyTransaction.BorderRadius = 40;
            this.btnNewBuyTransaction.BorderSize = 0;
            this.btnNewBuyTransaction.FlatAppearance.BorderSize = 0;
            this.btnNewBuyTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBuyTransaction.Font = new System.Drawing.Font("Arial Black", 7.75F, System.Drawing.FontStyle.Bold);
            this.btnNewBuyTransaction.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewBuyTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewBuyTransaction.Location = new System.Drawing.Point(116, 82);
            this.btnNewBuyTransaction.Name = "btnNewBuyTransaction";
            this.btnNewBuyTransaction.Size = new System.Drawing.Size(140, 58);
            this.btnNewBuyTransaction.TabIndex = 32;
            this.btnNewBuyTransaction.Text = "New Transaction (BUY)";
            this.btnNewBuyTransaction.TextColor = System.Drawing.Color.Transparent;
            this.btnNewBuyTransaction.UseVisualStyleBackColor = false;
            this.btnNewBuyTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // frmTypeOfTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(552, 188);
            this.Controls.Add(this.btnNewSellTransaction);
            this.Controls.Add(this.btnNewBuyTransaction);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTypeOfTransaction";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmTypeOfTransaction";
            this.Load += new System.EventHandler(this.frmTypeOfTransaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label1;
        private OrganizationProfile.CustomButton btnNewSellTransaction;
        private OrganizationProfile.CustomButton btnNewBuyTransaction;
    }
}