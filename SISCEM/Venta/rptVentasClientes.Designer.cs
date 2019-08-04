namespace SISCEM
{
    partial class rptVentasClientes
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
            this.PRESTODataSet = new SISCEM.PRESTODataSet();
            this.ReporteVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteVentaTableAdapter = new SISCEM.PRESTODataSetTableAdapters.ReporteVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsVentas";
            reportDataSource1.Value = this.ReporteVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.rptVentasClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(756, 417);
            this.reportViewer1.TabIndex = 1;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteVentaBindingSource
            // 
            this.ReporteVentaBindingSource.DataMember = "ReporteVenta";
            this.ReporteVentaBindingSource.DataSource = this.PRESTODataSet;
            // 
            // ReporteVentaTableAdapter
            // 
            this.ReporteVentaTableAdapter.ClearBeforeFill = true;
            // 
            // rptVentasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 417);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptVentasClientes";
            this.Text = "rptVentasClientes";
            this.Load += new System.EventHandler(this.rptVentasClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteVentaBindingSource;
        private PRESTODataSet PRESTODataSet;
        private PRESTODataSetTableAdapters.ReporteVentaTableAdapter ReporteVentaTableAdapter;
    }
}