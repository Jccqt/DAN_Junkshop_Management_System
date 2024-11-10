namespace Dan_Junkshop_Management_System
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.ContentsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPageHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnWindowSize = new System.Windows.Forms.PictureBox();
            this.btnLogout = new OrganizationProfile.CustomButton();
            this.btnDelivery = new OrganizationProfile.CustomButton();
            this.btnPartners = new OrganizationProfile.CustomButton();
            this.btnInventory = new OrganizationProfile.CustomButton();
            this.btnPriceSetup = new OrganizationProfile.CustomButton();
            this.btnTransaction = new OrganizationProfile.CustomButton();
            this.btnEmployee = new OrganizationProfile.CustomButton();
            this.btnSales = new OrganizationProfile.CustomButton();
            this.btnHome = new OrganizationProfile.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWindowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentsPanel
            // 
            this.ContentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentsPanel.Location = new System.Drawing.Point(337, 55);
            this.ContentsPanel.Name = "ContentsPanel";
            this.ContentsPanel.Size = new System.Drawing.Size(933, 736);
            this.ContentsPanel.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDelivery);
            this.panel1.Controls.Add(this.btnPartners);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnPriceSetup);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 1025);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(952, 756);
            this.panel4.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnWindowSize);
            this.panel2.Controls.Add(this.lblPageHeader);
            this.panel2.Location = new System.Drawing.Point(328, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 47);
            this.panel2.TabIndex = 23;
            // 
            // lblPageHeader
            // 
            this.lblPageHeader.AutoSize = true;
            this.lblPageHeader.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPageHeader.ForeColor = System.Drawing.Color.Red;
            this.lblPageHeader.Location = new System.Drawing.Point(12, 5);
            this.lblPageHeader.Name = "lblPageHeader";
            this.lblPageHeader.Size = new System.Drawing.Size(176, 38);
            this.lblPageHeader.TabIndex = 0;
            this.lblPageHeader.Text = "Dashboard";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(909, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 21);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.hide;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Location = new System.Drawing.Point(815, 13);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 21);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnWindowSize
            // 
            this.btnWindowSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowSize.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.minimizetab;
            this.btnWindowSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWindowSize.Location = new System.Drawing.Point(863, 13);
            this.btnWindowSize.Name = "btnWindowSize";
            this.btnWindowSize.Size = new System.Drawing.Size(20, 21);
            this.btnWindowSize.TabIndex = 1;
            this.btnWindowSize.TabStop = false;
            this.btnWindowSize.Click += new System.EventHandler(this.btnWindowSize_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnLogout.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 40;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Image = global::Dan_Junkshop_Management_System.Properties.Resources.newLogOut;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(27, 725);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(302, 62);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextColor = System.Drawing.Color.Transparent;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnDelivery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnDelivery.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelivery.BorderRadius = 40;
            this.btnDelivery.BorderSize = 0;
            this.btnDelivery.FlatAppearance.BorderSize = 0;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelivery.Image = global::Dan_Junkshop_Management_System.Properties.Resources.NewDelivery;
            this.btnDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelivery.Location = new System.Drawing.Point(29, 585);
            this.btnDelivery.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(302, 62);
            this.btnDelivery.TabIndex = 27;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.TextColor = System.Drawing.Color.Transparent;
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnPartners
            // 
            this.btnPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnPartners.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnPartners.BorderColor = System.Drawing.Color.Transparent;
            this.btnPartners.BorderRadius = 40;
            this.btnPartners.BorderSize = 0;
            this.btnPartners.FlatAppearance.BorderSize = 0;
            this.btnPartners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartners.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartners.ForeColor = System.Drawing.Color.Transparent;
            this.btnPartners.Image = global::Dan_Junkshop_Management_System.Properties.Resources.NewPartners;
            this.btnPartners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartners.Location = new System.Drawing.Point(28, 517);
            this.btnPartners.Margin = new System.Windows.Forms.Padding(5);
            this.btnPartners.Name = "btnPartners";
            this.btnPartners.Size = new System.Drawing.Size(302, 62);
            this.btnPartners.TabIndex = 26;
            this.btnPartners.Text = "Partners";
            this.btnPartners.TextColor = System.Drawing.Color.Transparent;
            this.btnPartners.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnInventory.BorderColor = System.Drawing.Color.Transparent;
            this.btnInventory.BorderRadius = 40;
            this.btnInventory.BorderSize = 0;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.Transparent;
            this.btnInventory.Image = global::Dan_Junkshop_Management_System.Properties.Resources.NewInventory;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(29, 449);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(5);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(302, 62);
            this.btnInventory.TabIndex = 25;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextColor = System.Drawing.Color.Transparent;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnPriceSetup
            // 
            this.btnPriceSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnPriceSetup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnPriceSetup.BorderColor = System.Drawing.Color.Transparent;
            this.btnPriceSetup.BorderRadius = 40;
            this.btnPriceSetup.BorderSize = 0;
            this.btnPriceSetup.FlatAppearance.BorderSize = 0;
            this.btnPriceSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceSetup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriceSetup.ForeColor = System.Drawing.Color.Transparent;
            this.btnPriceSetup.Image = global::Dan_Junkshop_Management_System.Properties.Resources.NewPriceSetup;
            this.btnPriceSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPriceSetup.Location = new System.Drawing.Point(29, 381);
            this.btnPriceSetup.Margin = new System.Windows.Forms.Padding(5);
            this.btnPriceSetup.Name = "btnPriceSetup";
            this.btnPriceSetup.Size = new System.Drawing.Size(302, 62);
            this.btnPriceSetup.TabIndex = 24;
            this.btnPriceSetup.Text = "Price Setup";
            this.btnPriceSetup.TextColor = System.Drawing.Color.Transparent;
            this.btnPriceSetup.UseVisualStyleBackColor = false;
            this.btnPriceSetup.Click += new System.EventHandler(this.btnPriceSetup_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnTransaction.BorderColor = System.Drawing.Color.Transparent;
            this.btnTransaction.BorderRadius = 40;
            this.btnTransaction.BorderSize = 0;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.Transparent;
            this.btnTransaction.Image = global::Dan_Junkshop_Management_System.Properties.Resources.NewTransaction;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(28, 313);
            this.btnTransaction.Margin = new System.Windows.Forms.Padding(5);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(302, 62);
            this.btnTransaction.TabIndex = 23;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.TextColor = System.Drawing.Color.Transparent;
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnEmployee.BorderColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BorderRadius = 40;
            this.btnEmployee.BorderSize = 0;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Image = global::Dan_Junkshop_Management_System.Properties.Resources.NewEmployee;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(28, 245);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(302, 62);
            this.btnEmployee.TabIndex = 22;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextColor = System.Drawing.Color.Transparent;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnSales.BorderColor = System.Drawing.Color.Transparent;
            this.btnSales.BorderRadius = 40;
            this.btnSales.BorderSize = 0;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.Transparent;
            this.btnSales.Image = global::Dan_Junkshop_Management_System.Properties.Resources.NewSales;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(28, 177);
            this.btnSales.Margin = new System.Windows.Forms.Padding(5);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(302, 62);
            this.btnSales.TabIndex = 21;
            this.btnSales.Text = "Sales";
            this.btnSales.TextColor = System.Drawing.Color.Transparent;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 40;
            this.btnHome.BorderSize = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = global::Dan_Junkshop_Management_System.Properties.Resources.newRedHome;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(28, 109);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(302, 62);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Home";
            this.btnHome.TextColor = System.Drawing.Color.Transparent;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(90, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 108);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContentsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWindowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel ContentsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnWindowSize;
        private System.Windows.Forms.Label lblPageHeader;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMinimize;
        private OrganizationProfile.CustomButton btnHome;
        private OrganizationProfile.CustomButton btnSales;
        private OrganizationProfile.CustomButton btnEmployee;
        private OrganizationProfile.CustomButton btnTransaction;
        private OrganizationProfile.CustomButton btnPriceSetup;
        private OrganizationProfile.CustomButton btnInventory;
        private OrganizationProfile.CustomButton btnPartners;
        private OrganizationProfile.CustomButton btnDelivery;
        private OrganizationProfile.CustomButton btnLogout;
    }
}

