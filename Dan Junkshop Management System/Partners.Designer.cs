namespace Dan_Junkshop_Management_System
{
    partial class Partners
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
            this.activeAndInactive1 = new WindowsFormsApp2.CustomButton.activeAndInactive();
            this.btnAddPartners = new OrganizationProfile.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flpDisplayPartners = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
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
            this.activeAndInactive1.TabIndex = 6;
            this.activeAndInactive1.Text = "activeAndInactive1";
            this.activeAndInactive1.UseVisualStyleBackColor = false;
            // 
            // btnAddPartners
            // 
            this.btnAddPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnAddPartners.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnAddPartners.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddPartners.BorderRadius = 39;
            this.btnAddPartners.BorderSize = 0;
            this.btnAddPartners.FlatAppearance.BorderSize = 0;
            this.btnAddPartners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPartners.Font = new System.Drawing.Font("Arial Black", 7.75F, System.Drawing.FontStyle.Bold);
            this.btnAddPartners.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddPartners.Image = global::Dan_Junkshop_Management_System.Properties.Resources.newAddCircle;
            this.btnAddPartners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPartners.Location = new System.Drawing.Point(682, 42);
            this.btnAddPartners.Name = "btnAddPartners";
            this.btnAddPartners.Size = new System.Drawing.Size(136, 43);
            this.btnAddPartners.TabIndex = 5;
            this.btnAddPartners.Text = "       Add Partners";
            this.btnAddPartners.TextColor = System.Drawing.Color.Transparent;
            this.btnAddPartners.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Active";
            // 
            // flpDisplayPartners
            // 
            this.flpDisplayPartners.Location = new System.Drawing.Point(13, 114);
            this.flpDisplayPartners.Name = "flpDisplayPartners";
            this.flpDisplayPartners.Size = new System.Drawing.Size(911, 592);
            this.flpDisplayPartners.TabIndex = 7;
            // 
            // Partners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.flpDisplayPartners);
            this.Controls.Add(this.activeAndInactive1);
            this.Controls.Add(this.btnAddPartners);
            this.Controls.Add(this.label1);
            this.Name = "Partners";
            this.Size = new System.Drawing.Size(938, 736);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApp2.CustomButton.activeAndInactive activeAndInactive1;
        private OrganizationProfile.CustomButton btnAddPartners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpDisplayPartners;
    }
}
