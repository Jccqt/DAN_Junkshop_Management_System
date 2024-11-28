namespace Dan_Junkshop_Management_System
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBorder1 = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.btnPasswordVisible = new OrganizationProfile.CustomButton();
            this.btnLogin = new OrganizationProfile.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBorder1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 35);
            this.panel1.TabIndex = 2;
            // 
            // btExit
            // 
            this.btExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExit.BackgroundImage")));
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.Location = new System.Drawing.Point(994, 7);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(23, 22);
            this.btExit.TabIndex = 2;
            this.btExit.TabStop = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Location = new System.Drawing.Point(952, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(19, 22);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.reddanjunkshop1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(483, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 397);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelBorder1
            // 
            this.panelBorder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panelBorder1.BorderRadius = 30;
            this.panelBorder1.Color = System.Drawing.Color.BurlyWood;
            this.panelBorder1.Controls.Add(this.btnPasswordVisible);
            this.panelBorder1.Controls.Add(this.btnLogin);
            this.panelBorder1.Controls.Add(this.label2);
            this.panelBorder1.Controls.Add(this.label1);
            this.panelBorder1.Controls.Add(this.txtPassword);
            this.panelBorder1.Controls.Add(this.txtUsername);
            this.panelBorder1.ForeColor = System.Drawing.Color.Black;
            this.panelBorder1.Location = new System.Drawing.Point(34, 68);
            this.panelBorder1.Name = "panelBorder1";
            this.panelBorder1.Size = new System.Drawing.Size(416, 510);
            this.panelBorder1.TabIndex = 0;
            // 
            // btnPasswordVisible
            // 
            this.btnPasswordVisible.BackColor = System.Drawing.Color.White;
            this.btnPasswordVisible.BackgroundColor = System.Drawing.Color.White;
            this.btnPasswordVisible.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPasswordVisible.BorderRadius = 0;
            this.btnPasswordVisible.BorderSize = 0;
            this.btnPasswordVisible.FlatAppearance.BorderSize = 0;
            this.btnPasswordVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordVisible.ForeColor = System.Drawing.Color.Transparent;
            this.btnPasswordVisible.Image = global::Dan_Junkshop_Management_System.Properties.Resources.weui_eyes_off_filled;
            this.btnPasswordVisible.Location = new System.Drawing.Point(330, 262);
            this.btnPasswordVisible.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasswordVisible.Name = "btnPasswordVisible";
            this.btnPasswordVisible.Size = new System.Drawing.Size(27, 20);
            this.btnPasswordVisible.TabIndex = 5;
            this.btnPasswordVisible.TextColor = System.Drawing.Color.Transparent;
            this.btnPasswordVisible.UseVisualStyleBackColor = false;
            this.btnPasswordVisible.Click += new System.EventHandler(this.btnPasswordVisible_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 40;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(116, 350);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 49);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log in";
            this.btnLogin.TextColor = System.Drawing.Color.Transparent;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(48, 253);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(316, 41);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(48, 157);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(316, 41);
            this.txtUsername.TabIndex = 0;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1040, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelBorder1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBorder1.ResumeLayout(false);
            this.panelBorder1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private OrganizationProfile.CustomButton btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btExit;
        private OrganizationProfile.CustomButton btnPasswordVisible;
    }
}