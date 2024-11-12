namespace Dan_Junkshop_Management_System
{
    partial class frmAddNewEmployee
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.roundPictureBox1 = new Dan_Junkshop_Management_System.Components.RoundPictureBox();
            this.btnSelectImage = new OrganizationProfile.CustomButton();
            this.label12 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.btnSave = new OrganizationProfile.CustomButton();
            this.btnClear = new OrganizationProfile.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 41);
            this.panel1.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.exit1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(798, 9);
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Employee";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(197, 92);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(228, 29);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddleInitial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleInitial.Location = new System.Drawing.Point(707, 92);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(86, 29);
            this.txtMiddleInitial.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(459, 92);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(224, 29);
            this.txtLastName.TabIndex = 2;
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(197, 169);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(228, 29);
            this.txtContact.TabIndex = 4;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtBirthDate.Location = new System.Drawing.Point(197, 249);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(274, 26);
            this.dtBirthDate.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(197, 399);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(596, 84);
            this.txtAddress.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(704, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "M.I";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Date of birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(194, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Address";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(543, 247);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(250, 28);
            this.cbGender.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(540, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(194, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(197, 330);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(192, 29);
            this.txtUsername.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(392, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(395, 330);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 29);
            this.txtPassword.TabIndex = 9;
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.roundPictureBox1.Location = new System.Drawing.Point(17, 50);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(143, 137);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox1.TabIndex = 35;
            this.roundPictureBox1.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnSelectImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnSelectImage.BorderColor = System.Drawing.Color.Transparent;
            this.btnSelectImage.BorderRadius = 20;
            this.btnSelectImage.BorderSize = 0;
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImage.ForeColor = System.Drawing.Color.Transparent;
            this.btnSelectImage.Location = new System.Drawing.Point(17, 203);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(143, 32);
            this.btnSelectImage.TabIndex = 11;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.TextColor = System.Drawing.Color.Transparent;
            this.btnSelectImage.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(456, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "Position";
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Cashier",
            "Manager",
            "Worker"});
            this.cbPosition.Location = new System.Drawing.Point(459, 169);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(204, 28);
            this.cbPosition.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(17, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.Transparent;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.btnClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.btnClear.BorderColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 20;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(17, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 32);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.Transparent;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(830, 504);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.roundPictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewEmployee";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewEmployee";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddNewEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassword;
        private Components.RoundPictureBox roundPictureBox1;
        private OrganizationProfile.CustomButton btnSelectImage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbPosition;
        private OrganizationProfile.CustomButton btnSave;
        private OrganizationProfile.CustomButton btnClear;
    }
}