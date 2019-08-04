namespace SISCEM
{
    partial class rptRefrendoExtemporaneo
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PRESTODataSet = new SISCEM.PRESTODataSet();
            this.SucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SucursalTableAdapter = new SISCEM.PRESTODataSetTableAdapters.SucursalTableAdapter();
            this.RefrendoextemporaneoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RefrendoextemporaneoTableAdapter = new SISCEM.PRESTODataSetTableAdapters.RefrendoextemporaneoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefrendoextemporaneoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ds_sucursal";
            reportDataSource1.Value = this.SucursalBindingSource;
            reportDataSource2.Name = "ds_refrendoextemporaneo";
            reportDataSource2.Value = this.RefrendoextemporaneoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.rptrefrendoexemporaneo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 407);
            this.reportViewer1.TabIndex = 0;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SucursalBindingSource
            // 
            this.SucursalBindingSource.DataMember = "Sucursal";
            this.SucursalBindingSource.DataSource = this.PRESTODataSet;
            // 
            // SucursalTableAdapter
            // 
            this.SucursalTableAdapter.ClearBeforeFill = true;
            // 
            // RefrendoextemporaneoBindingSource
            // 
            this.RefrendoextemporaneoBindingSource.DataMember = "Refrendoextemporaneo";
            this.RefrendoextemporaneoBindingSource.DataSource = this.PRESTODataSet;
            // 
            // RefrendoextemporaneoTableAdapter
            // 
            this.RefrendoextemporaneoTableAdapter.ClearBeforeFill = true;
            // 
            // rptRefrendoExtemporaneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 444);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptRefrendoExtemporaneo";
            this.Text = "rptRefrendoExtemporaneo";
            this.Load += new System.EventHandler(this.rptRefrendoExtemporaneo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefrendoextemporaneoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SucursalBindingSource;
        private PRESTODataSet PRESTODataSet;
        private System.Windows.Forms.BindingSource RefrendoextemporaneoBindingSource;
        private PRESTODataSetTableAdapters.SucursalTableAdapter SucursalTableAdapter;
        private PRESTODataSetTableAdapters.RefrendoextemporaneoTableAdapter RefrendoextemporaneoTableAdapter;
    }
}