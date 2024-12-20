namespace Dan_Junkshop_Management_System.Transactions
{
    partial class TransactionReceiptPage
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.transactionReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.transactionReceiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionReceiptBindingSource
            // 
            this.transactionReceiptBindingSource.DataSource = typeof(Dan_Junkshop_Management_System.RLDC_Reports.TransactionReceipt);
            // 
            // transactionItemsBindingSource
            // 
            this.transactionItemsBindingSource.DataSource = typeof(Dan_Junkshop_Management_System.RLDC_Reports.TransactionItems);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.transactionReceiptBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.transactionItemsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dan_Junkshop_Management_System.RLDC Reports.TransactionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(34, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(658, 330);
            this.reportViewer1.TabIndex = 0;
            // 
            // TransactionReceiptPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 397);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TransactionReceiptPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionReceiptPage";
            this.Load += new System.EventHandler(this.TransactionReceiptPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionReceiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource transactionReceiptBindingSource;
        private System.Windows.Forms.BindingSource transactionItemsBindingSource;
    }
}