namespace Dan_Junkshop_Management_System
{
    partial class ToPickUp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddPickup = new OrganizationProfile.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gridPickups = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPickups)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.btnAddPickup);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(39, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 49);
            this.panel2.TabIndex = 10;
            // 
            // btnAddPickup
            // 
            this.btnAddPickup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPickup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnAddPickup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnAddPickup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddPickup.BorderRadius = 37;
            this.btnAddPickup.BorderSize = 0;
            this.btnAddPickup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPickup.FlatAppearance.BorderSize = 0;
            this.btnAddPickup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPickup.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPickup.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddPickup.Image = global::Dan_Junkshop_Management_System.Properties.Resources.newAddCircle;
            this.btnAddPickup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPickup.Location = new System.Drawing.Point(685, 8);
            this.btnAddPickup.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPickup.Name = "btnAddPickup";
            this.btnAddPickup.Size = new System.Drawing.Size(143, 37);
            this.btnAddPickup.TabIndex = 8;
            this.btnAddPickup.Text = "     Add Pick-up";
            this.btnAddPickup.TextColor = System.Drawing.Color.Transparent;
            this.btnAddPickup.UseVisualStyleBackColor = false;
            this.btnAddPickup.Click += new System.EventHandler(this.btnAddPickup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pickups";
            // 
            // gridPickups
            // 
            this.gridPickups.AllowUserToAddRows = false;
            this.gridPickups.AllowUserToDeleteRows = false;
            this.gridPickups.AllowUserToResizeColumns = false;
            this.gridPickups.AllowUserToResizeRows = false;
            this.gridPickups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPickups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPickups.BackgroundColor = System.Drawing.Color.White;
            this.gridPickups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPickups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPickups.ColumnHeadersHeight = 29;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPickups.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridPickups.EnableHeadersVisualStyles = false;
            this.gridPickups.GridColor = System.Drawing.Color.Black;
            this.gridPickups.Location = new System.Drawing.Point(39, 113);
            this.gridPickups.Name = "gridPickups";
            this.gridPickups.ReadOnly = true;
            this.gridPickups.RowHeadersVisible = false;
            this.gridPickups.RowHeadersWidth = 51;
            this.gridPickups.Size = new System.Drawing.Size(839, 547);
            this.gridPickups.TabIndex = 9;
            // 
            // ToPickUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridPickups);
            this.Name = "ToPickUp";
            this.Size = new System.Drawing.Size(938, 727);
            this.Load += new System.EventHandler(this.ToPickUp_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPickups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private OrganizationProfile.CustomButton btnAddPickup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridPickups;
    }
}
