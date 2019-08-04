namespace SISCEM
{
    partial class Desempeniorpt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRESTODataSet = new SISCEM.PRESTODataSet();
            this.DesempenioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Desempenio_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptvdesempenio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SucursalTableAdapter = new SISCEM.PRESTODataSetTableAdapters.SucursalTableAdapter();
            this.DesempenioTableAdapter = new SISCEM.PRESTODataSetTableAdapters.DesempenioTableAdapter();
            this.Desempenio_DetalleTableAdapter = new SISCEM.PRESTODataSetTableAdapters.Desempenio_DetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesempenioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Desempenio_DetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SucursalBindingSource
            // 
            this.SucursalBindingSource.DataMember = "Sucursal";
            this.SucursalBindingSource.DataSource = this.PRESTODataSet;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DesempenioBindingSource
            // 
            this.DesempenioBindingSource.DataMember = "Desempenio";
            this.DesempenioBindingSource.DataSource = this.PRESTODataSet;
            // 
            // Desempenio_DetalleBindingSource
            // 
            this.Desempenio_DetalleBindingSource.DataMember = "Desempenio_Detalle";
            this.Desempenio_DetalleBindingSource.DataSource = this.PRESTODataSet;
            // 
            // rptvdesempenio
            // 
            reportDataSource1.Name = "dsSucursal";
            reportDataSource1.Value = this.SucursalBindingSource;
            reportDataSource2.Name = "dsEmpenio";
            reportDataSource2.Value = this.DesempenioBindingSource;
            reportDataSource3.Name = "dsDesempenio_Detalle";
            reportDataSource3.Value = this.Desempenio_DetalleBindingSource;
            this.rptvdesempenio.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvdesempenio.LocalReport.DataSources.Add(reportDataSource2);
            this.rptvdesempenio.LocalReport.DataSources.Add(reportDataSource3);
            this.rptvdesempenio.LocalReport.ReportEmbeddedResource = "SISCEM.Desempenio.rdlc";
            this.rptvdesempenio.Location = new System.Drawing.Point(1, 2);
            this.rptvdesempenio.Name = "rptvdesempenio";
            this.rptvdesempenio.Size = new System.Drawing.Size(941, 492);
            this.rptvdesempenio.TabIndex = 1;
            this.rptvdesempenio.Load += new System.EventHandler(this.rptvdesempenio_Load);
            // 
            // SucursalTableAdapter
            // 
            this.SucursalTableAdapter.ClearBeforeFill = true;
            // 
            // DesempenioTableAdapter
            // 
            this.DesempenioTableAdapter.ClearBeforeFill = true;
            // 
            // Desempenio_DetalleTableAdapter
            // 
            this.Desempenio_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // Desempeniorpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 579);
            this.Controls.Add(this.rptvdesempenio);
            this.Name = "Desempeniorpt";
            this.Text = "Desempeniorpt";
            this.Load += new System.EventHandler(this.Desempeniorpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesempenioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Desempenio_DetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvdesempenio;
        private System.Windows.Forms.BindingSource SucursalBindingSource;
        private PRESTODataSet PRESTODataSet;
        private System.Windows.Forms.BindingSource DesempenioBindingSource;
        private PRESTODataSetTableAdapters.SucursalTableAdapter SucursalTableAdapter;
        private PRESTODataSetTableAdapters.DesempenioTableAdapter DesempenioTableAdapter;
        private System.Windows.Forms.BindingSource Desempenio_DetalleBindingSource;
        private PRESTODataSetTableAdapters.Desempenio_DetalleTableAdapter Desempenio_DetalleTableAdapter;
    }
}