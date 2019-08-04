namespace SISCEM
{
    partial class rptMovimientoEgreso
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
            this.EgresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EgresosTableAdapter = new SISCEM.PRESTODataSetTableAdapters.EgresosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EgresosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsMovEgresos";
            reportDataSource1.Value = this.EgresosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.MovEgresos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(793, 421);
            this.reportViewer1.TabIndex = 0;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EgresosBindingSource
            // 
            this.EgresosBindingSource.DataMember = "Egresos";
            this.EgresosBindingSource.DataSource = this.PRESTODataSet;
            // 
            // EgresosTableAdapter
            // 
            this.EgresosTableAdapter.ClearBeforeFill = true;
            // 
            // rptMovimientoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 424);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptMovimientoEgreso";
            this.Text = "rptMovimientoEgreso";
            this.Load += new System.EventHandler(this.rptMovimientoEgreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EgresosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EgresosBindingSource;
        private PRESTODataSet PRESTODataSet;
        private PRESTODataSetTableAdapters.EgresosTableAdapter EgresosTableAdapter;
    }
}