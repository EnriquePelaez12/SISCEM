namespace SISCEM
{
    partial class rptMovimientoCajero
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
            this.MovimientoCajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRESTODataSet = new SISCEM.PRESTODataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MovimientoCajeroTableAdapter = new SISCEM.PRESTODataSetTableAdapters.MovimientoCajeroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoCajeroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MovimientoCajeroBindingSource
            // 
            this.MovimientoCajeroBindingSource.DataMember = "MovimientoCajero";
            this.MovimientoCajeroBindingSource.DataSource = this.PRESTODataSet;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsMovimientos";
            reportDataSource1.Value = this.MovimientoCajeroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.rptMovCajero.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(789, 475);
            this.reportViewer1.TabIndex = 1;
            // 
            // MovimientoCajeroTableAdapter
            // 
            this.MovimientoCajeroTableAdapter.ClearBeforeFill = true;
            // 
            // rptMovimientoCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 475);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptMovimientoCajero";
            this.Text = "rptMovimientoCajero";
            this.Load += new System.EventHandler(this.rptMovimientoCajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoCajeroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MovimientoCajeroBindingSource;
        private PRESTODataSet PRESTODataSet;
        private PRESTODataSetTableAdapters.MovimientoCajeroTableAdapter MovimientoCajeroTableAdapter;
    }
}