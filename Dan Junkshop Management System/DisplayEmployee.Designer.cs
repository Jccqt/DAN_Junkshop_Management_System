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
            this.panelBorder1 = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.customButton3 = new OrganizationProfile.CustomButton();
            this.customButton2 = new OrganizationProfile.CustomButton();
            this.btnMenu = new OrganizationProfile.CustomButton();
            this.panelBorder2 = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.EmployeePicture = new Dan_Junkshop_Management_System.Components.RoundPictureBox();
            this.panelBorder1.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.panelBorder2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.panelBorder1.Location = new System.Drawing.Point(10, 5);
            this.panelBorder1.Margin = new System.Windows.Forms.Padding(4);
            this.panelBorder1.Name = "panelBorder1";
            this.panelBorder1.Size = new System.Drawing.Size(300, 335);
            this.panelBorder1.TabIndex = 0;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.customButton3);
            this.pnlSettings.Controls.Add(this.customButton2);
            this.pnlSettings.Controls.Add(this.btnMenu);
            this.pnlSettings.Location = new System.Drawing.Point(129, 12);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSettings.MaximumSize = new System.Drawing.Size(163, 121);
            this.pnlSettings.MinimumSize = new System.Drawing.Size(163, 34);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(163, 39);
            this.pnlSettings.TabIndex = 1;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.IndianRed;
            this.customButton3.BackgroundColor = System.Drawing.Color.IndianRed;
            this.customButton3.BorderColor = System.Drawing.Color.Black;
            this.customButton3.BorderRadius = 0;
            this.customButton3.BorderSize = 1;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(4, 79);
            this.customButton3.Margin = new System.Windows.Forms.Padding(4);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(153, 39);
            this.customButton3.TabIndex = 2;
            this.customButton3.Text = "Archive";
            this.customButton3.TextColor = System.Drawing.Color.White;
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
            this.customButton2.Location = new System.Drawing.Point(4, 41);
            this.customButton2.Margin = new System.Windows.Forms.Padding(4);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(153, 39);
            this.customButton2.TabIndex = 1;
            this.customButton2.TextColor = System.Drawing.Color.Transparent;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.BackgroundColor = System.Drawing.Color.White;
            this.btnMenu.BorderColor = System.Drawing.Color.Transparent;
            this.btnMenu.BorderRadius = 23;
            this.btnMenu.BorderSize = 0;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btnMenu.Image = global::Dan_Junkshop_Management_System.Properties.Resources.tabler_dots;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.Location = new System.Drawing.Point(96, 4);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(61, 30);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TextColor = System.Drawing.Color.Transparent;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelBorder2
            // 
            this.panelBorder2.BackColor = System.Drawing.Color.LightGray;
            this.panelBorder2.BorderRadius = 37;
            this.panelBorder2.Color = System.Drawing.Color.Transparent;
            this.panelBorder2.Controls.Add(this.label3);
            this.panelBorder2.Controls.Add(this.label2);
            this.panelBorder2.Controls.Add(this.label1);
            this.panelBorder2.Controls.Add(this.lblEmployeeID);
            this.panelBorder2.Controls.Add(this.lblContact);
            this.panelBorder2.Controls.Add(this.lblPosition);
            this.panelBorder2.ForeColor = System.Drawing.Color.Black;
            this.panelBorder2.Location = new System.Drawing.Point(11, 193);
            this.panelBorder2.Margin = new System.Windows.Forms.Padding(4);
            this.panelBorder2.Name = "panelBorder2";
            this.panelBorder2.Size = new System.Drawing.Size(277, 130);
            this.panelBorder2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Position:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Emp ID:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(102, 14);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 16);
            this.lblEmployeeID.TabIndex = 4;
            this.lblEmployeeID.Text = "<EmpID>";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(98, 73);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(77, 16);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "<Contact>";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(98, 41);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(80, 16);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "<Position>";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(23, 128);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(73, 19);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "<Name>";
            // 
            // EmployeePicture
            // 
            this.EmployeePicture.BackColor = System.Drawing.SystemColors.Menu;
            this.EmployeePicture.Image = global::Dan_Junkshop_Management_System.Properties.Resources.defaultEmployeeIcon;
            this.EmployeePicture.Location = new System.Drawing.Point(13, 12);
            this.EmployeePicture.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeePicture.Name = "EmployeePicture";
            this.EmployeePicture.Size = new System.Drawing.Size(100, 100);
            this.EmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeePicture.TabIndex = 0;
            this.EmployeePicture.TabStop = false;
            // 
            // DisplayEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelBorder1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisplayEmployee";
            this.Size = new System.Drawing.Size(320, 346);
            this.Load += new System.EventHandler(this.DisplayEmployee_Load);
            this.panelBorder1.ResumeLayout(false);
            this.panelBorder1.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.panelBorder2.ResumeLayout(false);
            this.panelBorder2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Components.RoundPictureBox EmployeePicture;
        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder2;
        private System.Windows.Forms.Panel pnlSettings;
        private OrganizationProfile.CustomButton customButton3;
        private OrganizationProfile.CustomButton customButton2;
        private OrganizationProfile.CustomButton btnMenu;
        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder1;
        public System.Windows.Forms.Label lblFullName;
        public System.Windows.Forms.Label lblEmployeeID;
        public System.Windows.Forms.Label lblPosition;
        public System.Windows.Forms.Label lblContact;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
    }
}
