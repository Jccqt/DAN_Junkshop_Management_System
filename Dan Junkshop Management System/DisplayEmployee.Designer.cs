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
            this.panelBorder1 = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.panelBorder2 = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.EmployeePicture = new Dan_Junkshop_Management_System.Components.RoundPictureBox();
            this.customButton1 = new OrganizationProfile.CustomButton();
            this.panelBorder1.SuspendLayout();
            this.panelBorder2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder1
            // 
            this.panelBorder1.BackColor = System.Drawing.Color.White;
            this.panelBorder1.BorderRadius = 50;
            this.panelBorder1.Color = System.Drawing.Color.BurlyWood;
            this.panelBorder1.Controls.Add(this.customButton1);
            this.panelBorder1.Controls.Add(this.panelBorder2);
            this.panelBorder1.Controls.Add(this.lblFullName);
            this.panelBorder1.Controls.Add(this.EmployeePicture);
            this.panelBorder1.ForeColor = System.Drawing.Color.Black;
            this.panelBorder1.Location = new System.Drawing.Point(8, 4);
            this.panelBorder1.Name = "panelBorder1";
            this.panelBorder1.Size = new System.Drawing.Size(225, 272);
            this.panelBorder1.TabIndex = 0;
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
            this.panelBorder2.Location = new System.Drawing.Point(8, 157);
            this.panelBorder2.Name = "panelBorder2";
            this.panelBorder2.Size = new System.Drawing.Size(208, 106);
            this.panelBorder2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Position:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Emp ID:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(76, 11);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(53, 14);
            this.lblEmployeeID.TabIndex = 4;
            this.lblEmployeeID.Text = "<EmpID>";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(74, 59);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(61, 14);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "<Contact>";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(74, 35);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(64, 14);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "<Position>";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(17, 104);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(62, 16);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "<Name>";
            // 
            // EmployeePicture
            // 
            this.EmployeePicture.BackColor = System.Drawing.SystemColors.Menu;
            this.EmployeePicture.Image = global::Dan_Junkshop_Management_System.Properties.Resources.new_Employee;
            this.EmployeePicture.Location = new System.Drawing.Point(10, 10);
            this.EmployeePicture.Name = "EmployeePicture";
            this.EmployeePicture.Size = new System.Drawing.Size(82, 81);
            this.EmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeePicture.TabIndex = 0;
            this.EmployeePicture.TabStop = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderRadius = 27;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.Transparent;
            this.customButton1.Image = global::Dan_Junkshop_Management_System.Properties.Resources.icon_park_solid_edit;
            this.customButton1.Location = new System.Drawing.Point(184, 12);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(30, 29);
            this.customButton1.TabIndex = 3;
            this.customButton1.TextColor = System.Drawing.Color.Transparent;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // DisplayEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelBorder1);
            this.Name = "DisplayEmployee";
            this.Size = new System.Drawing.Size(240, 281);

            this.panelBorder1.ResumeLayout(false);
            this.panelBorder1.PerformLayout();
            this.panelBorder2.ResumeLayout(false);
            this.panelBorder2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Components.RoundPictureBox EmployeePicture;
        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder2;
        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder1;
        public System.Windows.Forms.Label lblFullName;
        public System.Windows.Forms.Label lblEmployeeID;
        public System.Windows.Forms.Label lblPosition;
        public System.Windows.Forms.Label lblContact;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private OrganizationProfile.CustomButton customButton1;
    }
}
