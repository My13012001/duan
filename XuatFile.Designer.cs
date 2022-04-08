
namespace QL_GS25
{
    partial class XuatFile
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QL_GS25DataSet = new QL_GS25.QL_GS25DataSet();
            this.QLHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLHTableAdapter = new QL_GS25.QL_GS25DataSetTableAdapters.QLHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_GS25DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.QLHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_GS25.ReportHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // QL_GS25DataSet
            // 
            this.QL_GS25DataSet.DataSetName = "QL_GS25DataSet";
            this.QL_GS25DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QLHBindingSource
            // 
            this.QLHBindingSource.DataMember = "QLH";
            this.QLHBindingSource.DataSource = this.QL_GS25DataSet;
            // 
            // QLHTableAdapter
            // 
            this.QLHTableAdapter.ClearBeforeFill = true;
            // 
            // XuatFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "XuatFile";
            this.Text = "XuatFile";
            this.Load += new System.EventHandler(this.XuatFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_GS25DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource QLHBindingSource;
        private QL_GS25DataSet QL_GS25DataSet;
        private QL_GS25DataSetTableAdapters.QLHTableAdapter QLHTableAdapter;
    }
}