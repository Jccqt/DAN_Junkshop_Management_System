namespace Dan_Junkshop_Management_System
{
    partial class DashboardPanel
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Report3Panel = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.lblReport3Value = new System.Windows.Forms.Label();
            this.lblReport3 = new System.Windows.Forms.Label();
            this.DatePanel = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.label4 = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.Report2Panel = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.lblReport2Value = new System.Windows.Forms.Label();
            this.lblReport2 = new System.Windows.Forms.Label();
            this.ChartPanel = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.ChartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Report1Panel = new WindowsFormsApp2.CustomButton.PanelBorder();
            this.lblReport1Value = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReport1 = new System.Windows.Forms.Label();
            this.Report3Panel.SuspendLayout();
            this.DatePanel.SuspendLayout();
            this.Report2Panel.SuspendLayout();
            this.ChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Report1Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Report3Panel
            // 
            this.Report3Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Report3Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Report3Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.Report3Panel.BorderRadius = 30;
            this.Report3Panel.Color = System.Drawing.Color.BurlyWood;
            this.Report3Panel.Controls.Add(this.lblReport3Value);
            this.Report3Panel.Controls.Add(this.lblReport3);
            this.Report3Panel.ForeColor = System.Drawing.Color.Black;
            this.Report3Panel.Location = new System.Drawing.Point(454, 41);
            this.Report3Panel.Name = "Report3Panel";
            this.Report3Panel.Size = new System.Drawing.Size(212, 134);
            this.Report3Panel.TabIndex = 7;
            // 
            // lblReport3Value
            // 
            this.lblReport3Value.AutoSize = true;
            this.lblReport3Value.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblReport3Value.ForeColor = System.Drawing.Color.White;
            this.lblReport3Value.Location = new System.Drawing.Point(46, 45);
            this.lblReport3Value.Name = "lblReport3Value";
            this.lblReport3Value.Size = new System.Drawing.Size(35, 38);
            this.lblReport3Value.TabIndex = 2;
            this.lblReport3Value.Text = "0";
            // 
            // lblReport3
            // 
            this.lblReport3.AutoSize = true;
            this.lblReport3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport3.ForeColor = System.Drawing.Color.White;
            this.lblReport3.Location = new System.Drawing.Point(7, 97);
            this.lblReport3.Name = "lblReport3";
            this.lblReport3.Size = new System.Drawing.Size(154, 15);
            this.lblReport3.TabIndex = 0;
            this.lblReport3.Text = "Total pickup count today";
            // 
            // DatePanel
            // 
            this.DatePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DatePanel.BackColor = System.Drawing.Color.White;
            this.DatePanel.BorderRadius = 30;
            this.DatePanel.Color = System.Drawing.Color.BurlyWood;
            this.DatePanel.Controls.Add(this.label4);
            this.DatePanel.Controls.Add(this.Calendar);
            this.DatePanel.ForeColor = System.Drawing.Color.Black;
            this.DatePanel.Location = new System.Drawing.Point(684, 41);
            this.DatePanel.Name = "DatePanel";
            this.DatePanel.Size = new System.Drawing.Size(244, 224);
            this.DatePanel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(96, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(9, 45);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            // 
            // Report2Panel
            // 
            this.Report2Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Report2Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Report2Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.Report2Panel.BorderRadius = 30;
            this.Report2Panel.Color = System.Drawing.Color.BurlyWood;
            this.Report2Panel.Controls.Add(this.lblReport2Value);
            this.Report2Panel.Controls.Add(this.lblReport2);
            this.Report2Panel.ForeColor = System.Drawing.Color.Black;
            this.Report2Panel.Location = new System.Drawing.Point(227, 42);
            this.Report2Panel.Name = "Report2Panel";
            this.Report2Panel.Size = new System.Drawing.Size(212, 134);
            this.Report2Panel.TabIndex = 7;
            // 
            // lblReport2Value
            // 
            this.lblReport2Value.AutoSize = true;
            this.lblReport2Value.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblReport2Value.ForeColor = System.Drawing.Color.White;
            this.lblReport2Value.Location = new System.Drawing.Point(48, 45);
            this.lblReport2Value.Name = "lblReport2Value";
            this.lblReport2Value.Size = new System.Drawing.Size(35, 38);
            this.lblReport2Value.TabIndex = 2;
            this.lblReport2Value.Text = "0";
            // 
            // lblReport2
            // 
            this.lblReport2.AutoSize = true;
            this.lblReport2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport2.ForeColor = System.Drawing.Color.White;
            this.lblReport2.Location = new System.Drawing.Point(8, 97);
            this.lblReport2.Name = "lblReport2";
            this.lblReport2.Size = new System.Drawing.Size(190, 15);
            this.lblReport2.TabIndex = 0;
            this.lblReport2.Text = "Total transactions count today";
            // 
            // ChartPanel
            // 
            this.ChartPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChartPanel.BackColor = System.Drawing.Color.White;
            this.ChartPanel.BorderRadius = 30;
            this.ChartPanel.Color = System.Drawing.Color.BurlyWood;
            this.ChartPanel.Controls.Add(this.ChartReport);
            this.ChartPanel.Controls.Add(this.pictureBox4);
            this.ChartPanel.ForeColor = System.Drawing.Color.Black;
            this.ChartPanel.Location = new System.Drawing.Point(-1, 189);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(667, 499);
            this.ChartPanel.TabIndex = 11;
            // 
            // ChartReport
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartReport.Legends.Add(legend1);
            this.ChartReport.Location = new System.Drawing.Point(12, 39);
            this.ChartReport.Name = "ChartReport";
            this.ChartReport.Size = new System.Drawing.Size(644, 445);
            this.ChartReport.TabIndex = 10;
            this.ChartReport.Text = " ";
            title1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Top selling items today";
            this.ChartReport.Titles.Add(title1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Dan_Junkshop_Management_System.Properties.Resources.expand;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(785, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 31);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // Report1Panel
            // 
            this.Report1Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Report1Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Report1Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.Report1Panel.BorderRadius = 30;
            this.Report1Panel.Color = System.Drawing.Color.BurlyWood;
            this.Report1Panel.Controls.Add(this.lblReport1Value);
            this.Report1Panel.Controls.Add(this.label2);
            this.Report1Panel.Controls.Add(this.lblReport1);
            this.Report1Panel.ForeColor = System.Drawing.Color.Black;
            this.Report1Panel.Location = new System.Drawing.Point(0, 41);
            this.Report1Panel.Name = "Report1Panel";
            this.Report1Panel.Size = new System.Drawing.Size(212, 134);
            this.Report1Panel.TabIndex = 6;
            // 
            // lblReport1Value
            // 
            this.lblReport1Value.AutoSize = true;
            this.lblReport1Value.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblReport1Value.ForeColor = System.Drawing.Color.White;
            this.lblReport1Value.Location = new System.Drawing.Point(44, 45);
            this.lblReport1Value.Name = "lblReport1Value";
            this.lblReport1Value.Size = new System.Drawing.Size(80, 38);
            this.lblReport1Value.TabIndex = 2;
            this.lblReport1Value.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PhP";
            // 
            // lblReport1
            // 
            this.lblReport1.AutoSize = true;
            this.lblReport1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport1.ForeColor = System.Drawing.Color.White;
            this.lblReport1.Location = new System.Drawing.Point(7, 97);
            this.lblReport1.Name = "lblReport1";
            this.lblReport1.Size = new System.Drawing.Size(114, 15);
            this.lblReport1.TabIndex = 0;
            this.lblReport1.Text = "Total sales today ";
            // 
            // DashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Report3Panel);
            this.Controls.Add(this.DatePanel);
            this.Controls.Add(this.Report2Panel);
            this.Controls.Add(this.ChartPanel);
            this.Controls.Add(this.Report1Panel);
            this.Name = "DashboardPanel";
            this.Size = new System.Drawing.Size(937, 737);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Report3Panel.ResumeLayout(false);
            this.Report3Panel.PerformLayout();
            this.DatePanel.ResumeLayout(false);
            this.DatePanel.PerformLayout();
            this.Report2Panel.ResumeLayout(false);
            this.Report2Panel.PerformLayout();
            this.ChartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Report1Panel.ResumeLayout(false);
            this.Report1Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private WindowsFormsApp2.CustomButton.PanelBorder Report1Panel;
        private WindowsFormsApp2.CustomButton.PanelBorder ChartPanel;
        private System.Windows.Forms.Label lblReport1;
        private System.Windows.Forms.Label lblReport1Value;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApp2.CustomButton.PanelBorder DatePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private WindowsFormsApp2.CustomButton.PanelBorder Report2Panel;
        private System.Windows.Forms.Label lblReport2Value;
        private System.Windows.Forms.Label lblReport2;
        private WindowsFormsApp2.CustomButton.PanelBorder Report3Panel;
        private System.Windows.Forms.Label lblReport3Value;
        private System.Windows.Forms.Label lblReport3;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartReport;
    }
}
