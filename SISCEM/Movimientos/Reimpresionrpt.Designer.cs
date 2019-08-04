namespace SISCEM
{
    partial class Reimpresionrpt
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PRESTODataSet = new SISCEM.PRESTODataSet();
            this.InteresesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InteresesTableAdapter = new SISCEM.PRESTODataSetTableAdapters.InteresesTableAdapter();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteTableAdapter = new SISCEM.PRESTODataSetTableAdapters.ClienteTableAdapter();
            this.SucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SucursalTableAdapter = new SISCEM.PRESTODataSetTableAdapters.SucursalTableAdapter();
            this.Boleta_EncabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Boleta_EncabezadoTableAdapter = new SISCEM.PRESTODataSetTableAdapters.Boleta_EncabezadoTableAdapter();
            this.Boleta_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Boleta_DetalleTableAdapter = new SISCEM.PRESTODataSetTableAdapters.Boleta_DetalleTableAdapter();
            this.ReimprimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReimprimeTableAdapter = new SISCEM.PRESTODataSetTableAdapters.ReimprimeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteresesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boleta_EncabezadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boleta_DetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReimprimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsIntereses";
            reportDataSource1.Value = this.InteresesBindingSource;
            reportDataSource2.Name = "dsCliente";
            reportDataSource2.Value = this.ClienteBindingSource;
            reportDataSource3.Name = "dsSucursal";
            reportDataSource3.Value = this.SucursalBindingSource;
            reportDataSource4.Name = "dsBoleta_Encabezado";
            reportDataSource4.Value = this.Boleta_EncabezadoBindingSource;
            reportDataSource5.Name = "dsBoletaDetalle";
            reportDataSource5.Value = this.Boleta_DetalleBindingSource;
            reportDataSource6.Name = "dsReimprime";
            reportDataSource6.Value = this.ReimprimeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.rptReimprime.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(760, 442);
            this.reportViewer1.TabIndex = 0;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InteresesBindingSource
            // 
            this.InteresesBindingSource.DataMember = "Intereses";
            this.InteresesBindingSource.DataSource = this.PRESTODataSet;
            // 
            // InteresesTableAdapter
            // 
            this.InteresesTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "Cliente";
            this.ClienteBindingSource.DataSource = this.PRESTODataSet;
            // 
            // ClienteTableAdapter
            // 
            this.ClienteTableAdapter.ClearBeforeFill = true;
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
            // Boleta_EncabezadoBindingSource
            // 
            this.Boleta_EncabezadoBindingSource.DataMember = "Boleta_Encabezado";
            this.Boleta_EncabezadoBindingSource.DataSource = this.PRESTODataSet;
            // 
            // Boleta_EncabezadoTableAdapter
            // 
            this.Boleta_EncabezadoTableAdapter.ClearBeforeFill = true;
            // 
            // Boleta_DetalleBindingSource
            // 
            this.Boleta_DetalleBindingSource.DataMember = "Boleta_Detalle";
            this.Boleta_DetalleBindingSource.DataSource = this.PRESTODataSet;
            // 
            // Boleta_DetalleTableAdapter
            // 
            this.Boleta_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // ReimprimeBindingSource
            // 
            this.ReimprimeBindingSource.DataMember = "Reimprime";
            this.ReimprimeBindingSource.DataSource = this.PRESTODataSet;
            // 
            // ReimprimeTableAdapter
            // 
            this.ReimprimeTableAdapter.ClearBeforeFill = true;
            // 
            // Reimpresionrpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 439);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reimpresionrpt";
            this.Text = "Reimpresionrpt";
            this.Load += new System.EventHandler(this.Reimpresionrpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteresesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boleta_EncabezadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boleta_DetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReimprimeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InteresesBindingSource;
        private PRESTODataSet PRESTODataSet;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private System.Windows.Forms.BindingSource SucursalBindingSource;
        private System.Windows.Forms.BindingSource Boleta_EncabezadoBindingSource;
        private System.Windows.Forms.BindingSource Boleta_DetalleBindingSource;
        private System.Windows.Forms.BindingSource ReimprimeBindingSource;
        private PRESTODataSetTableAdapters.InteresesTableAdapter InteresesTableAdapter;
        private PRESTODataSetTableAdapters.ClienteTableAdapter ClienteTableAdapter;
        private PRESTODataSetTableAdapters.SucursalTableAdapter SucursalTableAdapter;
        private PRESTODataSetTableAdapters.Boleta_EncabezadoTableAdapter Boleta_EncabezadoTableAdapter;
        private PRESTODataSetTableAdapters.Boleta_DetalleTableAdapter Boleta_DetalleTableAdapter;
        private PRESTODataSetTableAdapters.ReimprimeTableAdapter ReimprimeTableAdapter;
    }
}