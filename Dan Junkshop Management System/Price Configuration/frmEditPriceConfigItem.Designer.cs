namespace Dan_Junkshop_Management_System
{
    partial class frmEditPriceConfigItem
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlantPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtItemClassname = new System.Windows.Forms.TextBox();
            this.btnCancel = new OrganizationProfile.CustomButton();
            this.btnUpdateItem = new OrganizationProfile.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 41);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Price Configuration Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(269, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Plant Price / kg";
            // 
            // txtPlantPrice
            // 
            this.txtPlantPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlantPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlantPrice.Location = new System.Drawing.Point(272, 89);
            this.txtPlantPrice.Name = "txtPlantPrice";
            this.txtPlantPrice.Size = new System.Drawing.Size(211, 26);
            this.txtPlantPrice.TabIndex = 45;
            this.txtPlantPrice.TextChanged += new System.EventHandler(this.txtPlantPrice_TextChanged);
            this.txtPlantPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlantPrice_KeyPress);
            this.txtPlantPrice.Leave += new System.EventHandler(this.txtPlantPrice_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(500, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Profit / kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Class Name";
            // 
            // txtProfit
            // 
            this.txtProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfit.Location = new System.Drawing.Point(503, 89);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(211, 26);
            this.txtProfit.TabIndex = 40;
            this.txtProfit.TextChanged += new System.EventHandler(this.txtProfit_TextChanged);
            this.txtProfit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfit_KeyPress);
            this.txtProfit.Leave += new System.EventHandler(this.txtProfit_Leave);
            // 
            // txtItemClassname
            // 
            this.txtItemClassname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemClassname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemClassname.Location = new System.Drawing.Point(43, 89);
            this.txtItemClassname.Name = "txtItemClassname";
            this.txtItemClassname.Size = new System.Drawing.Size(211, 26);
            this.txtItemClassname.TabIndex = 39;
            this.txtItemClassname.TextChanged += new System.EventHandler(this.txtItemClassname_TextChanged);
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
            this.btnCancel.Location = new System.Drawing.Point(578, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 44);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Transparent;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnUpdateItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(135)))), ((int)(((byte)(118)))));
            this.btnUpdateItem.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateItem.BorderRadius = 40;
            this.btnUpdateItem.BorderSize = 0;
            this.btnUpdateItem.FlatAppearance.BorderSize = 0;
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItem.Font = new System.Drawing.Font("Arial Black", 7.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateItem.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateItem.Location = new System.Drawing.Point(454, 146);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(119, 44);
            this.btnUpdateItem.TabIndex = 41;
            this.btnUpdateItem.Text = "Update";
            this.btnUpdateItem.TextColor = System.Drawing.Color.Transparent;
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // frmEditPriceConfigItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(749, 214);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlantPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.txtItemClassname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditPriceConfigItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditPriceConfigItem";
            this.Load += new System.EventHandler(this.frmEditPriceConfigItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlantPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private OrganizationProfile.CustomButton btnCancel;
        private OrganizationProfile.CustomButton btnUpdateItem;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtItemClassname;
    }
}