namespace Dan_Junkshop_Management_System
{
    partial class frmEditEmployee
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.roundPictureBox1 = new Dan_Junkshop_Management_System.Components.RoundPictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSwitchStatus = new WindowsFormsApp2.CustomButton.activeAndInactive();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnUpdate = new OrganizationProfile.CustomButton();
            this.btnRestoreOriginal = new OrganizationProfile.CustomButton();
            this.btnCancel = new OrganizationProfile.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 41);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Employee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(704, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(707, 168);
            this.txtAge.Name = "txtAge";
            this.txtAge.ShortcutsEnabled = false;
            this.txtAge.Size = new System.Drawing.Size(86, 29);
            this.txtAge.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(456, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 63;
            this.label12.Text = "Position";
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.Enabled = false;
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier"});
            this.cbPosition.Location = new System.Drawing.Point(459, 169);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(224, 28);
            this.cbPosition.TabIndex = 45;
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.roundPictureBox1.Image = global::Dan_Junkshop_Management_System.Properties.Resources.new_Employee;
            this.roundPictureBox1.Location = new System.Drawing.Point(17, 50);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(143, 137);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox1.TabIndex = 62;
            this.roundPictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(456, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 61;
            this.label11.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(459, 330);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(224, 29);
            this.txtPassword.TabIndex = 49;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(194, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 60;
            this.label10.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(197, 330);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(228, 29);
            this.txtUsername.TabIndex = 48;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(540, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Gender";
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
            this.cbGender.TabIndex = 47;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(194, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Date of birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(704, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "M.I";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "First Name";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(197, 399);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(596, 84);
            this.txtAddress.TabIndex = 50;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtBirthDate.Location = new System.Drawing.Point(197, 249);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(274, 26);
            this.dtBirthDate.TabIndex = 46;
            this.dtBirthDate.ValueChanged += new System.EventHandler(this.dtBirthDate_ValueChanged);
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(197, 169);
            this.txtContact.Name = "txtContact";
            this.txtContact.ShortcutsEnabled = false;
            this.txtContact.Size = new System.Drawing.Size(228, 29);
            this.txtContact.TabIndex = 44;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(459, 92);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ShortcutsEnabled = false;
            this.txtLastName.Size = new System.Drawing.Size(224, 29);
            this.txtLastName.TabIndex = 42;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddleInitial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleInitial.Location = new System.Drawing.Point(707, 92);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.ShortcutsEnabled = false;
            this.txtMiddleInitial.Size = new System.Drawing.Size(86, 29);
            this.txtMiddleInitial.TabIndex = 43;
            this.txtMiddleInitial.TextChanged += new System.EventHandler(this.txtMiddleInitial_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(197, 92);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ShortcutsEnabled = false;
            this.txtFirstName.Size = new System.Drawing.Size(228, 29);
            this.txtFirstName.TabIndex = 41;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // btnSwitchStatus
            // 
            this.btnSwitchStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitchStatus.BackColor = System.Drawing.Color.DimGray;
            this.btnSwitchStatus.Checked = true;
            this.btnSwitchStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSwitchStatus.ForeColor = System.Drawing.Color.Transparent;
            this.btnSwitchStatus.Location = new System.Drawing.Point(716, 330);
            this.btnSwitchStatus.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnSwitchStatus.Name = "btnSwitchStatus";
            this.btnSwitchStatus.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.btnSwitchStatus.OffToggleColor = System.Drawing.Color.White;
            this.btnSwitchStatus.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnSwitchStatus.OnToggleColor = System.Drawing.Color.White;
            this.btnSwitchStatus.Size = new System.Drawing.Size(58, 27);
            this.btnSwitchStatus.TabIndex = 66;
            this.btnSwitchStatus.Text = "ActiveInactive";
            this.btnSwitchStatus.UseVisualStyleBackColor = false;
            this.btnSwitchStatus.Click += new System.EventHandler(this.btnSwitchStatus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(717, 311);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 16);
            this.lblStatus.TabIndex = 67;
            this.lblStatus.Text = "Active";
            this.lblStatus.TextChanged += new System.EventHandler(this.lblStatus_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 40;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Black", 7.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(30, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(119, 44);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.Transparent;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRestoreOriginal
            // 
            this.btnRestoreOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.btnRestoreOriginal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.btnRestoreOriginal.BorderColor = System.Drawing.Color.Transparent;
            this.btnRestoreOriginal.BorderRadius = 40;
            this.btnRestoreOriginal.BorderSize = 0;
            this.btnRestoreOriginal.FlatAppearance.BorderSize = 0;
            this.btnRestoreOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreOriginal.Font = new System.Drawing.Font("Arial Black", 7.75F, System.Drawing.FontStyle.Bold);
            this.btnRestoreOriginal.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestoreOriginal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoreOriginal.Location = new System.Drawing.Point(30, 389);
            this.btnRestoreOriginal.Name = "btnRestoreOriginal";
            this.btnRestoreOriginal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRestoreOriginal.Size = new System.Drawing.Size(119, 44);
            this.btnRestoreOriginal.TabIndex = 69;
            this.btnRestoreOriginal.Text = "Restore original details";
            this.btnRestoreOriginal.TextColor = System.Drawing.Color.Transparent;
            this.btnRestoreOriginal.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 40;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Black", 7.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(30, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 44);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Transparent;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(830, 504);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRestoreOriginal);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSwitchStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbPosition);
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
            this.Name = "frmEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditEmployee";
            this.Load += new System.EventHandler(this.frmEditEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbPosition;
        private Components.RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtFirstName;
        private WindowsFormsApp2.CustomButton.activeAndInactive btnSwitchStatus;
        private System.Windows.Forms.Label lblStatus;
        private OrganizationProfile.CustomButton btnUpdate;
        private OrganizationProfile.CustomButton btnRestoreOriginal;
        private OrganizationProfile.CustomButton btnCancel;
    }
}