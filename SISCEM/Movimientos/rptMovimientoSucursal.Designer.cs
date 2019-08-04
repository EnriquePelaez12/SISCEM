namespace SISCEM
{
    partial class rptMovimientoSucursal
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
            this.MovimientoSucuralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MovimientoSucuralTableAdapter = new SISCEM.PRESTODataSetTableAdapters.MovimientoSucuralTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoSucuralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsMovimientoSucursal";
            reportDataSource1.Value = this.MovimientoSucuralBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.rptMovSucursal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(698, 417);
            this.reportViewer1.TabIndex = 0;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MovimientoSucuralBindingSource
            // 
            this.MovimientoSucuralBindingSource.DataMember = "MovimientoSucural";
            this.MovimientoSucuralBindingSource.DataSource = this.PRESTODataSet;
            // 
            // MovimientoSucuralTableAdapter
            // 
            this.MovimientoSucuralTableAdapter.ClearBeforeFill = true;
            // 
            // rptMovimientoSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 419);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptMovimientoSucursal";
            this.Text = "rptMovimientoSucursal";
            this.Load += new System.EventHandler(this.rptMovimientoSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoSucuralBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PRESTODataSetTableAdapters.MsuursalTableAdapter MsuursalTableAdapter;
        private System.Windows.Forms.BindingSource MovimientoSucuralBindingSource;
        private PRESTODataSet PRESTODataSet;
        private PRESTODataSetTableAdapters.MovimientoSucuralTableAdapter MovimientoSucuralTableAdapter;

    }
}