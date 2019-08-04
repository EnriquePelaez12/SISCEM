namespace SISCEM
{
    partial class Ventarpt
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
            this.SucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRESTODataSet = new SISCEM.PRESTODataSet();
            this.Desglose_BoletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Desglose_Boleta1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptventa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SucursalTableAdapter = new SISCEM.PRESTODataSetTableAdapters.SucursalTableAdapter();
            this.DesempenioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DesempenioTableAdapter = new SISCEM.PRESTODataSetTableAdapters.DesempenioTableAdapter();
            this.Desempenio_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Desempenio_DetalleTableAdapter = new SISCEM.PRESTODataSetTableAdapters.Desempenio_DetalleTableAdapter();
            this.Desglose_BoletaTableAdapter = new SISCEM.PRESTODataSetTableAdapters.Desglose_BoletaTableAdapter();
            this.ClienteTableAdapter = new SISCEM.PRESTODataSetTableAdapters.ClienteTableAdapter();
            this.Desglose_Boleta1TableAdapter = new SISCEM.PRESTODataSetTableAdapters.Desglose_Boleta1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Desglose_BoletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Desglose_Boleta1BindingSource)).BeginInit();
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
            // Desglose_BoletaBindingSource
            // 
            this.Desglose_BoletaBindingSource.DataMember = "Desglose_Boleta";
            this.Desglose_BoletaBindingSource.DataSource = this.PRESTODataSet;
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "Cliente";
            this.ClienteBindingSource.DataSource = this.PRESTODataSet;
            // 
            // Desglose_Boleta1BindingSource
            // 
            this.Desglose_Boleta1BindingSource.DataMember = "Desglose_Boleta1";
            this.Desglose_Boleta1BindingSource.DataSource = this.PRESTODataSet;
            // 
            // rptventa
            // 
            reportDataSource1.Name = "dsSucursal";
            reportDataSource1.Value = this.SucursalBindingSource;
            reportDataSource2.Name = "dsDesgloseBoleta";
            reportDataSource2.Value = this.Desglose_BoletaBindingSource;
            reportDataSource3.Name = "ds_Cliente";
            reportDataSource3.Value = this.ClienteBindingSource;
            reportDataSource4.Name = "ds_degloseboleta_codigo";
            reportDataSource4.Value = this.Desglose_Boleta1BindingSource;
            this.rptventa.LocalReport.DataSources.Add(reportDataSource1);
            this.rptventa.LocalReport.DataSources.Add(reportDataSource2);
            this.rptventa.LocalReport.DataSources.Add(reportDataSource3);
            this.rptventa.LocalReport.DataSources.Add(reportDataSource4);
            this.rptventa.LocalReport.ReportEmbeddedResource = "SISCEM.Venta.rdlc";
            this.rptventa.Location = new System.Drawing.Point(19, 12);
            this.rptventa.Name = "rptventa";
            this.rptventa.Size = new System.Drawing.Size(873, 440);
            this.rptventa.TabIndex = 0;
            // 
            // SucursalTableAdapter
            // 
            this.SucursalTableAdapter.ClearBeforeFill = true;
            // 
            // DesempenioBindingSource
            // 
            this.DesempenioBindingSource.DataMember = "Desempenio";
            this.DesempenioBindingSource.DataSource = this.PRESTODataSet;
            // 
            // DesempenioTableAdapter
            // 
            this.DesempenioTableAdapter.ClearBeforeFill = true;
            // 
            // Desempenio_DetalleBindingSource
            // 
            this.Desempenio_DetalleBindingSource.DataMember = "Desempenio_Detalle";
            this.Desempenio_DetalleBindingSource.DataSource = this.PRESTODataSet;
            // 
            // Desempenio_DetalleTableAdapter
            // 
            this.Desempenio_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // Desglose_BoletaTableAdapter
            // 
            this.Desglose_BoletaTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteTableAdapter
            // 
            this.ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // Desglose_Boleta1TableAdapter
            // 
            this.Desglose_Boleta1TableAdapter.ClearBeforeFill = true;
            // 
            // Ventarpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 465);
            this.Controls.Add(this.rptventa);
            this.Name = "Ventarpt";
            this.Text = "Venta de prenda";
            this.Load += new System.EventHandler(this.Ventarpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Desglose_BoletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Desglose_Boleta1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesempenioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Desempenio_DetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptventa;
        private System.Windows.Forms.BindingSource SucursalBindingSource;
        private PRESTODataSet PRESTODataSet;
        private PRESTODataSetTableAdapters.SucursalTableAdapter SucursalTableAdapter;
        private System.Windows.Forms.BindingSource DesempenioBindingSource;
        private System.Windows.Forms.BindingSource Desempenio_DetalleBindingSource;
        private PRESTODataSetTableAdapters.DesempenioTableAdapter DesempenioTableAdapter;
        private PRESTODataSetTableAdapters.Desempenio_DetalleTableAdapter Desempenio_DetalleTableAdapter;
        private System.Windows.Forms.BindingSource Desglose_BoletaBindingSource;
        private PRESTODataSetTableAdapters.Desglose_BoletaTableAdapter Desglose_BoletaTableAdapter;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private PRESTODataSetTableAdapters.ClienteTableAdapter ClienteTableAdapter;
        private System.Windows.Forms.BindingSource Desglose_Boleta1BindingSource;
        private PRESTODataSetTableAdapters.Desglose_Boleta1TableAdapter Desglose_Boleta1TableAdapter;
    }
}