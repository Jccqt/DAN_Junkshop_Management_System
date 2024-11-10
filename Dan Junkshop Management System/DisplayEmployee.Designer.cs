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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.roundPictureBox1 = new Dan_Junkshop_Management_System.Components.RoundPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBorder2 = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.customButton3 = new OrganizationProfile.CustomButton();
            this.customButton2 = new OrganizationProfile.CustomButton();
            this.customButton1 = new OrganizationProfile.CustomButton();
            this.panelBorder1 = new WindowsFormsApp2.CustomButton.PanelBorder();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.panelBorder2.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.panelBorder1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.BackColor = System.Drawing.Color.Gray;
            this.roundPictureBox1.Location = new System.Drawing.Point(10, 10);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(81, 77);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox1.TabIndex = 0;
            this.roundPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "<Name>";
            // 
            // panelBorder2
            // 
            this.panelBorder2.BackColor = System.Drawing.Color.LightGray;
            this.panelBorder2.BorderRadius = 37;
            this.panelBorder2.Color = System.Drawing.Color.Transparent;
            this.panelBorder2.Controls.Add(this.label5);
            this.panelBorder2.Controls.Add(this.label4);
            this.panelBorder2.Controls.Add(this.label3);
            this.panelBorder2.Controls.Add(this.label2);
            this.panelBorder2.ForeColor = System.Drawing.Color.Black;
            this.panelBorder2.Location = new System.Drawing.Point(8, 157);
            this.panelBorder2.Name = "panelBorder2";
            this.panelBorder2.Size = new System.Drawing.Size(208, 106);
            this.panelBorder2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "<Contact>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "<Email>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "<HiredDate>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "<Position>";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.customButton3);
            this.pnlSettings.Controls.Add(this.customButton2);
            this.pnlSettings.Controls.Add(this.customButton1);
            this.pnlSettings.Location = new System.Drawing.Point(97, 10);
            this.pnlSettings.MaximumSize = new System.Drawing.Size(122, 98);
            this.pnlSettings.MinimumSize = new System.Drawing.Size(122, 28);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(122, 31);
            this.pnlSettings.TabIndex = 1;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.White;
            this.customButton3.BackgroundColor = System.Drawing.Color.White;
            this.customButton3.BorderColor = System.Drawing.Color.Black;
            this.customButton3.BorderRadius = 0;
            this.customButton3.BorderSize = 1;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.Transparent;
            this.customButton3.Location = new System.Drawing.Point(3, 64);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(115, 32);
            this.customButton3.TabIndex = 2;
            this.customButton3.TextColor = System.Drawing.Color.Transparent;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.BorderColor = System.Drawing.Color.Black;
            this.customButton2.BorderRadius = 0;
            this.customButton2.BorderSize = 1;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.Transparent;
            this.customButton2.Location = new System.Drawing.Point(3, 33);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(115, 32);
            this.customButton2.TabIndex = 1;
            this.customButton2.TextColor = System.Drawing.Color.Transparent;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.White;
            this.customButton1.BackgroundColor = System.Drawing.Color.White;
            this.customButton1.BorderColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderRadius = 23;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.Transparent;
            this.customButton1.Image = global::Dan_Junkshop_Management_System.Properties.Resources.tabler_dots;
            this.customButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton1.Location = new System.Drawing.Point(72, 3);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(46, 24);
            this.customButton1.TabIndex = 0;
            this.customButton1.TextColor = System.Drawing.Color.Transparent;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panelBorder1
            // 
            this.panelBorder1.BackColor = System.Drawing.Color.White;
            this.panelBorder1.BorderRadius = 50;
            this.panelBorder1.Color = System.Drawing.Color.BurlyWood;
            this.panelBorder1.Controls.Add(this.pnlSettings);
            this.panelBorder1.Controls.Add(this.panelBorder2);
            this.panelBorder1.Controls.Add(this.label1);
            this.panelBorder1.Controls.Add(this.roundPictureBox1);
            this.panelBorder1.ForeColor = System.Drawing.Color.Black;
            this.panelBorder1.Location = new System.Drawing.Point(11, 4);
            this.panelBorder1.Name = "panelBorder1";
            this.panelBorder1.Size = new System.Drawing.Size(225, 272);
            this.panelBorder1.TabIndex = 0;
            // 
            // DisplayEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelBorder1);
            this.Name = "DisplayEmployee";
            this.Size = new System.Drawing.Size(244, 281);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.panelBorder2.ResumeLayout(false);
            this.panelBorder2.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.panelBorder1.ResumeLayout(false);
            this.panelBorder1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Components.RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSettings;
        private OrganizationProfile.CustomButton customButton3;
        private OrganizationProfile.CustomButton customButton2;
        private OrganizationProfile.CustomButton customButton1;
        private WindowsFormsApp2.CustomButton.PanelBorder panelBorder1;
    }
}
