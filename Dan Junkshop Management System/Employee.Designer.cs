namespace Dan_Junkshop_Management_System
{
    partial class Employee
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
            this.EmployeePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSwitchStatus = new WindowsFormsApp2.CustomButton.activeAndInactive();
            this.btnAddEmployee = new OrganizationProfile.CustomButton();
            this.SuspendLayout();
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.Location = new System.Drawing.Point(13, 114);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(911, 592);
            this.EmployeePanel.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(3, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(412, 56);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Active Employees";
            this.lblStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSwitchStatus
            // 
            this.btnSwitchStatus.BackColor = System.Drawing.Color.DimGray;
            this.btnSwitchStatus.Checked = true;
            this.btnSwitchStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSwitchStatus.ForeColor = System.Drawing.Color.Transparent;
            this.btnSwitchStatus.Location = new System.Drawing.Point(825, 42);
            this.btnSwitchStatus.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnSwitchStatus.Name = "btnSwitchStatus";
            this.btnSwitchStatus.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.btnSwitchStatus.OffToggleColor = System.Drawing.Color.White;
            this.btnSwitchStatus.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnSwitchStatus.OnToggleColor = System.Drawing.Color.White;
            this.btnSwitchStatus.Size = new System.Drawing.Size(99, 43);
            this.btnSwitchStatus.TabIndex = 3;
            this.btnSwitchStatus.Text = "activeAndInactive1";
            this.btnSwitchStatus.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnAddEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnAddEmployee.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.BorderRadius = 39;
            this.btnAddEmployee.BorderSize = 0;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Arial Black", 7.75F, System.Drawing.FontStyle.Bold);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.Image = global::Dan_Junkshop_Management_System.Properties.Resources.newAddCircle;
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(682, 42);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(136, 43);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "       Add Employee";
            this.btnAddEmployee.TextColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btnSwitchStatus);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.EmployeePanel);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(938, 736);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel EmployeePanel;
        private System.Windows.Forms.Label lblStatus;
        private OrganizationProfile.CustomButton btnAddEmployee;
        private WindowsFormsApp2.CustomButton.activeAndInactive btnSwitchStatus;
    }
}
