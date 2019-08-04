namespace SISCEM
{
    partial class Empeniorpt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRESTODataSet = new SISCEM.PRESTODataSet();
            this.Boleta_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InteresesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Boleta_EncabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PagosTableAdapter = new SISCEM.PRESTODataSetTableAdapters.PagosTableAdapter();
            this.Boleta_DetalleTableAdapter = new SISCEM.PRESTODataSetTableAdapters.Boleta_DetalleTableAdapter();
            this.InteresesTableAdapter = new SISCEM.PRESTODataSetTableAdapters.InteresesTableAdapter();
            this.ClienteTableAdapter = new SISCEM.PRESTODataSetTableAdapters.ClienteTableAdapter();
            this.SucursalTableAdapter = new SISCEM.PRESTODataSetTableAdapters.SucursalTableAdapter();
            this.interes = new SISCEM.interes();
            this.Boleta_EncabezadoTableAdapter = new SISCEM.PRESTODataSetTableAdapters.Boleta_EncabezadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boleta_DetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteresesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boleta_EncabezadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interes)).BeginInit();
            this.SuspendLayout();
            // 
            // PagosBindingSource
            // 
            this.PagosBindingSource.DataMember = "Pagos";
            this.PagosBindingSource.DataSource = this.PRESTODataSet;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Boleta_DetalleBindingSource
            // 
            this.Boleta_DetalleBindingSource.DataMember = "Boleta_Detalle";
            this.Boleta_DetalleBindingSource.DataSource = this.PRESTODataSet;
            // 
            // InteresesBindingSource
            // 
            this.InteresesBindingSource.DataMember = "Intereses";
            this.InteresesBindingSource.DataSource = this.PRESTODataSet;
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "Cliente";
            this.ClienteBindingSource.DataSource = this.PRESTODataSet;
            // 
            // SucursalBindingSource
            // 
            this.SucursalBindingSource.DataMember = "Sucursal";
            this.SucursalBindingSource.DataSource = this.PRESTODataSet;
            // 
            // Boleta_EncabezadoBindingSource
            // 
            this.Boleta_EncabezadoBindingSource.DataMember = "Boleta_Encabezado";
            this.Boleta_EncabezadoBindingSource.DataSource = this.PRESTODataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "dsEmpenio";
            reportDataSource1.Value = this.PagosBindingSource;
            reportDataSource2.Name = "dsBoletaDetalle";
            reportDataSource2.Value = this.Boleta_DetalleBindingSource;
            reportDataSource3.Name = "dsIntereses";
            reportDataSource3.Value = this.InteresesBindingSource;
            reportDataSource4.Name = "dsCliente";
            reportDataSource4.Value = this.ClienteBindingSource;
            reportDataSource5.Name = "dsSucursal";
            reportDataSource5.Value = this.SucursalBindingSource;
            reportDataSource6.Name = "dsBoleta_Encabezado";
            reportDataSource6.Value = this.Boleta_EncabezadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.rptEmpenio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1235, 659);
            this.reportViewer1.TabIndex = 0;
            // 
            // PagosTableAdapter
            // 
            this.PagosTableAdapter.ClearBeforeFill = true;
            // 
            // Boleta_DetalleTableAdapter
            // 
            this.Boleta_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // InteresesTableAdapter
            // 
            this.InteresesTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteTableAdapter
            // 
            this.ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // SucursalTableAdapter
            // 
            this.SucursalTableAdapter.ClearBeforeFill = true;
            // 
            // interes
            // 
            this.interes.DataSetName = "interes";
            this.interes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Boleta_EncabezadoTableAdapter
            // 
            this.Boleta_EncabezadoTableAdapter.ClearBeforeFill = true;
            // 
            // Empeniorpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 674);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Empeniorpt";
            this.Text = "Empeniorpt";
            this.Load += new System.EventHandler(this.Empeniorpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boleta_DetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteresesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boleta_EncabezadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PagosBindingSource;
        private PRESTODataSet PRESTODataSet;
        private PRESTODataSetTableAdapters.PagosTableAdapter PagosTableAdapter;
        private System.Windows.Forms.BindingSource Boleta_DetalleBindingSource;
        private PRESTODataSetTableAdapters.Boleta_DetalleTableAdapter Boleta_DetalleTableAdapter;
        private System.Windows.Forms.BindingSource InteresesBindingSource;
        private PRESTODataSetTableAdapters.InteresesTableAdapter InteresesTableAdapter;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private PRESTODataSetTableAdapters.ClienteTableAdapter ClienteTableAdapter;
        private System.Windows.Forms.BindingSource SucursalBindingSource;
        private PRESTODataSetTableAdapters.SucursalTableAdapter SucursalTableAdapter;
        private interes interes;
        private System.Windows.Forms.BindingSource Boleta_EncabezadoBindingSource;
        private PRESTODataSetTableAdapters.Boleta_EncabezadoTableAdapter Boleta_EncabezadoTableAdapter;
    }
}