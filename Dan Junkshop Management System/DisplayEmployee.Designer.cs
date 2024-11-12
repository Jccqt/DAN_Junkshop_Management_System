namespace Dan_Junkshop_Management_System
{
    partial class DisplayEmployee
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EmployeePicture = new Dan_Junkshop_Management_System.Components.RoundPictureBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.panelBorder2 = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.customButton3 = new OrganizationProfile.CustomButton();
            this.customButton2 = new OrganizationProfile.CustomButton();
            this.customButton1 = new OrganizationProfile.CustomButton();
            this.panelBorder1 = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.lblAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).BeginInit();
            this.panelBorder2.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.panelBorder1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EmployeePicture
            // 
            this.EmployeePicture.BackColor = System.Drawing.Color.Gray;
            this.EmployeePicture.Location = new System.Drawing.Point(10, 10);
            this.EmployeePicture.Name = "EmployeePicture";
            this.EmployeePicture.Size = new System.Drawing.Size(81, 77);
            this.EmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeePicture.TabIndex = 0;
            this.EmployeePicture.TabStop = false;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(17, 104);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 16);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "<Name>";
            // 
            // panelBorder2
            // 
            this.panelBorder2.BackColor = System.Drawing.Color.LightGray;
            this.panelBorder2.BorderRadius = 37;
            this.panelBorder2.Color = System.Drawing.Color.Transparent;
            this.panelBorder2.Controls.Add(this.lblAddress);
            this.panelBorder2.Controls.Add(this.lblContact);
            this.panelBorder2.Controls.Add(this.lblPosition);
            this.panelBorder2.ForeColor = System.Drawing.Color.Black;
            this.panelBorder2.Location = new System.Drawing.Point(8, 157);
            this.panelBorder2.Name = "panelBorder2";
            this.panelBorder2.Size = new System.Drawing.Size(208, 106);
            this.panelBorder2.TabIndex = 2;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(12, 34);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(61, 14);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "<Contact>";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(12, 10);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(64, 14);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "<Position>";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.customButton3);
            this.pnlSettings.Controls.Add(this.customButton2);
            this.pnlSettings.Controls.Add(this.customButton1);
            this.pnlSettings.Location = new System.Drawing.Point(97, 10);
            this.pnlSettings.MaximumSize = new System.Drawing.Size(122, 98);
            this.pnlSettings.MinimumSize = new System.Drawing.Size(122, 28);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(122, 31);
            this.pnlSettings.TabIndex = 1;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.White;
            this.customButton3.BackgroundColor = System.Drawing.Color.White;
            this.customButton3.BorderColor = System.Drawing.Color.Black;
            this.customButton3.BorderRadius = 0;
            this.customButton3.BorderSize = 1;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.Transparent;
            this.customButton3.Location = new System.Drawing.Point(3, 64);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(115, 32);
            this.customButton3.TabIndex = 2;
            this.customButton3.TextColor = System.Drawing.Color.Transparent;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.BorderColor = System.Drawing.Color.Black;
            this.customButton2.BorderRadius = 0;
            this.customButton2.BorderSize = 1;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.Transparent;
            this.customButton2.Location = new System.Drawing.Point(3, 33);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(115, 32);
            this.customButton2.TabIndex = 1;
            this.customButton2.TextColor = System.Drawing.Color.Transparent;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.White;
            this.customButton1.BackgroundColor = System.Drawing.Color.White;
            this.customButton1.BorderColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderRadius = 23;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.Transparent;
            this.customButton1.Image = global::Dan_Junkshop_Management_System.Properties.Resources.tabler_dots;
            this.customButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton1.Location = new System.Drawing.Point(72, 3);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(46, 24);
            this.customButton1.TabIndex = 0;
            this.customButton1.TextColor = System.Drawing.Color.Transparent;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panelBorder1
            // 
            this.panelBorder1.BackColor = System.Drawing.Color.White;
            this.panelBorder1.BorderRadius = 50;
            this.panelBorder1.Color = System.Drawing.Color.BurlyWood;
            this.panelBorder1.Controls.Add(this.pnlSettings);
            this.panelBorder1.Controls.Add(this.panelBorder2);
            this.panelBorder1.Controls.Add(this.lblFullName);
            this.panelBorder1.Controls.Add(this.EmployeePicture);
            this.panelBorder1.ForeColor = System.Drawing.Color.Black;
            this.panelBorder1.Location = new System.Drawing.Point(11, 4);
            this.panelBorder1.Name = "panelBorder1";
            this.panelBorder1.Size = new System.Drawing.Size(225, 272);
            this.panelBorder1.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(15, 57);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 14);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "<Address>";
            // 
            // DisplayEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelBorder1);
            this.Name = "DisplayEmployee";
            this.Size = new System.Drawing.Size(244, 281);
            this.Load += new System.EventHandler(this.DisplayEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).EndInit();
            this.panelBorder2.ResumeLayout(false);
            this.panelBorder2.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.panelBorder1.ResumeLayout(false);
            this.panelBorder1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Components.RoundPictureBox EmployeePicture;
        private System.Windows.Forms.Label lblFullName;
        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder2;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel pnlSettings;
        private OrganizationProfile.CustomButton customButton3;
        private OrganizationProfile.CustomButton customButton2;
        private OrganizationProfile.CustomButton customButton1;
        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder1;
        private System.Windows.Forms.Label lblAddress;
    }
}
