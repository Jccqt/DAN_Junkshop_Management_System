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
            this.flpDisplayEmp = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.activeAndInactive1 = new WindowsFormsApp2.CustomButton.activeAndInactive();
            this.customButton1 = new OrganizationProfile.CustomButton();
            this.SuspendLayout();
            // 
            // flpDisplayEmp
            // 
            this.flpDisplayEmp.Location = new System.Drawing.Point(13, 114);
            this.flpDisplayEmp.Name = "flpDisplayEmp";
            this.flpDisplayEmp.Size = new System.Drawing.Size(911, 592);
            this.flpDisplayEmp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // activeAndInactive1
            // 
            this.activeAndInactive1.BackColor = System.Drawing.Color.DimGray;
            this.activeAndInactive1.Checked = true;
            this.activeAndInactive1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeAndInactive1.ForeColor = System.Drawing.Color.Transparent;
            this.activeAndInactive1.Location = new System.Drawing.Point(825, 42);
            this.activeAndInactive1.MinimumSize = new System.Drawing.Size(45, 22);
            this.activeAndInactive1.Name = "activeAndInactive1";
            this.activeAndInactive1.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.activeAndInactive1.OffToggleColor = System.Drawing.Color.White;
            this.activeAndInactive1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.activeAndInactive1.OnToggleColor = System.Drawing.Color.White;
            this.activeAndInactive1.Size = new System.Drawing.Size(99, 43);
            this.activeAndInactive1.TabIndex = 3;
            this.activeAndInactive1.Text = "activeAndInactive1";
            this.activeAndInactive1.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.customButton1.BorderColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderRadius = 39;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Arial Black", 7.75F, System.Drawing.FontStyle.Bold);
            this.customButton1.ForeColor = System.Drawing.Color.Transparent;
            this.customButton1.Image = global::Dan_Junkshop_Management_System.Properties.Resources.newAddCircle;
            this.customButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton1.Location = new System.Drawing.Point(682, 42);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(136, 43);
            this.customButton1.TabIndex = 2;
            this.customButton1.Text = "       Add Employee";
            this.customButton1.TextColor = System.Drawing.Color.Transparent;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.activeAndInactive1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpDisplayEmp);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(938, 736);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpDisplayEmp;
        private System.Windows.Forms.Label label1;
        private OrganizationProfile.CustomButton customButton1;
        private WindowsFormsApp2.CustomButton.activeAndInactive activeAndInactive1;
    }
}
