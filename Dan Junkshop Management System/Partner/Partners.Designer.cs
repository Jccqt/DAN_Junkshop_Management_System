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
            this.btnStatusSwitch = new WindowsFormsApp2.CustomButton.activeAndInactive();
            this.btnAddPartners = new OrganizationProfile.CustomButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.PartnersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnStatusSwitch
            // 
            this.btnStatusSwitch.BackColor = System.Drawing.Color.DimGray;
            this.btnStatusSwitch.Checked = true;
            this.btnStatusSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnStatusSwitch.ForeColor = System.Drawing.Color.Transparent;
            this.btnStatusSwitch.Location = new System.Drawing.Point(825, 42);
            this.btnStatusSwitch.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnStatusSwitch.Name = "btnStatusSwitch";
            this.btnStatusSwitch.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.btnStatusSwitch.OffToggleColor = System.Drawing.Color.White;
            this.btnStatusSwitch.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnStatusSwitch.OnToggleColor = System.Drawing.Color.White;
            this.btnStatusSwitch.Size = new System.Drawing.Size(99, 43);
            this.btnStatusSwitch.TabIndex = 6;
            this.btnStatusSwitch.Text = "activeAndInactive1";
            this.btnStatusSwitch.UseVisualStyleBackColor = false;
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
            this.btnAddPartners.Click += new System.EventHandler(this.btnAddPartners_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(3, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(365, 56);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Active partners";
            // 
            // PartnersPanel
            // 
            this.PartnersPanel.Location = new System.Drawing.Point(13, 114);
            this.PartnersPanel.Name = "PartnersPanel";
            this.PartnersPanel.Size = new System.Drawing.Size(911, 592);
            this.PartnersPanel.TabIndex = 7;
            // 
            // Partners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.PartnersPanel);
            this.Controls.Add(this.btnStatusSwitch);
            this.Controls.Add(this.btnAddPartners);
            this.Controls.Add(this.lblStatus);
            this.Name = "Partners";
            this.Size = new System.Drawing.Size(938, 736);
            this.Load += new System.EventHandler(this.Partners_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApp2.CustomButton.activeAndInactive btnStatusSwitch;
        private OrganizationProfile.CustomButton btnAddPartners;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.FlowLayoutPanel PartnersPanel;
    }
}
