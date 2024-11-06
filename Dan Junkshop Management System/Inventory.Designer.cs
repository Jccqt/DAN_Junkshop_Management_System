namespace Dan_Junkshop_Management_System
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelBorder1 = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panelBorder2 = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelBorder3 = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.customButton1 = new OrganizationProfile.CustomButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBorder1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBorder2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBorder3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(353, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Available Scraps";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.panelBorder3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(7, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 47);
            this.panel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(924, 564);
            this.dataGridView1.TabIndex = 9;
            // 
            // panelBorder1
            // 
            this.panelBorder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorder1.BackColor = System.Drawing.Color.White;
            this.panelBorder1.BorderRadius = 35;
            this.panelBorder1.Color = System.Drawing.Color.White;
            this.panelBorder1.Controls.Add(this.pictureBox1);
            this.panelBorder1.Controls.Add(this.SearchBox);
            this.panelBorder1.ForeColor = System.Drawing.Color.Black;
            this.panelBorder1.Location = new System.Drawing.Point(165, 35);
            this.panelBorder1.Name = "panelBorder1";
            this.panelBorder1.Size = new System.Drawing.Size(445, 43);
            this.panelBorder1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Arial", 15.25F);
            this.SearchBox.Location = new System.Drawing.Point(25, 8);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(417, 24);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.Text = "Search";
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelBorder2
            // 
            this.panelBorder2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorder2.BackColor = System.Drawing.Color.White;
            this.panelBorder2.BorderRadius = 30;
            this.panelBorder2.Color = System.Drawing.Color.BurlyWood;
            this.panelBorder2.Controls.Add(this.pictureBox2);
            this.panelBorder2.Controls.Add(this.comboBox1);
            this.panelBorder2.ForeColor = System.Drawing.Color.Black;
            this.panelBorder2.Location = new System.Drawing.Point(616, 35);
            this.panelBorder2.Name = "panelBorder2";
            this.panelBorder2.Size = new System.Drawing.Size(169, 43);
            this.panelBorder2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 16F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Location = new System.Drawing.Point(42, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // panelBorder3
            // 
            this.panelBorder3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorder3.BackColor = System.Drawing.Color.Transparent;
            this.panelBorder3.BorderRadius = 30;
            this.panelBorder3.Color = System.Drawing.Color.BurlyWood;
            this.panelBorder3.Controls.Add(this.pictureBox3);
            this.panelBorder3.Controls.Add(this.customButton1);
            this.panelBorder3.ForeColor = System.Drawing.Color.Black;
            this.panelBorder3.Location = new System.Drawing.Point(773, 3);
            this.panelBorder3.Name = "panelBorder3";
            this.panelBorder3.Size = new System.Drawing.Size(138, 41);
            this.panelBorder3.TabIndex = 10;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 36;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Arial Black", 9.25F, System.Drawing.FontStyle.Bold);
            this.customButton1.ForeColor = System.Drawing.Color.Transparent;
            this.customButton1.Location = new System.Drawing.Point(0, 0);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(135, 39);
            this.customButton1.TabIndex = 11;
            this.customButton1.Text = "         Add Item";
            this.customButton1.TextColor = System.Drawing.Color.Transparent;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.pictureBox3.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.add_circle;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(14, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBorder1);
            this.Controls.Add(this.panelBorder2);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(1357, 736);
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBorder1.ResumeLayout(false);
            this.panelBorder1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBorder2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBorder3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder3;
        private OrganizationProfile.CustomButton customButton1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
