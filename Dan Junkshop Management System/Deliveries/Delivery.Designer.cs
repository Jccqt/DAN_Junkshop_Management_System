namespace Dan_Junkshop_Management_System
{
    partial class Delivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridDeliverables = new System.Windows.Forms.DataGridView();
            this.gridVehicles = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddItem = new OrganizationProfile.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeliverables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deliverables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vehicles";
            // 
            // gridDeliverables
            // 
            this.gridDeliverables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDeliverables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDeliverables.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridDeliverables.BackgroundColor = System.Drawing.Color.White;
            this.gridDeliverables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDeliverables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridDeliverables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDeliverables.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridDeliverables.EnableHeadersVisualStyles = false;
            this.gridDeliverables.GridColor = System.Drawing.Color.Black;
            this.gridDeliverables.Location = new System.Drawing.Point(50, 82);
            this.gridDeliverables.Name = "gridDeliverables";
            this.gridDeliverables.RowHeadersVisible = false;
            this.gridDeliverables.Size = new System.Drawing.Size(839, 309);
            this.gridDeliverables.TabIndex = 5;
            // 
            // gridVehicles
            // 
            this.gridVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVehicles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridVehicles.BackgroundColor = System.Drawing.Color.White;
            this.gridVehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.gridVehicles.EnableHeadersVisualStyles = false;
            this.gridVehicles.GridColor = System.Drawing.Color.Black;
            this.gridVehicles.Location = new System.Drawing.Point(50, 482);
            this.gridVehicles.Name = "gridVehicles";
            this.gridVehicles.RowHeadersVisible = false;
            this.gridVehicles.Size = new System.Drawing.Size(839, 205);
            this.gridVehicles.TabIndex = 6;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Vehicle Type";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Plate Number";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Vehicle Scale";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Edit";
            this.Column9.Name = "Column9";
            this.Column9.Width = 43;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnAddItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnAddItem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddItem.BorderRadius = 37;
            this.btnAddItem.BorderSize = 0;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddItem.Image = global::Dan_Junkshop_Management_System.Properties.Resources.newAddCircle;
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.Location = new System.Drawing.Point(765, 442);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(124, 37);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "     Add Item";
            this.btnAddItem.TextColor = System.Drawing.Color.Transparent;
            this.btnAddItem.UseVisualStyleBackColor = false;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.gridVehicles);
            this.Controls.Add(this.gridDeliverables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Delivery";
            this.Size = new System.Drawing.Size(938, 736);
            this.Load += new System.EventHandler(this.Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDeliverables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridDeliverables;
        private System.Windows.Forms.DataGridView gridVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private OrganizationProfile.CustomButton btnAddItem;
    }
}
