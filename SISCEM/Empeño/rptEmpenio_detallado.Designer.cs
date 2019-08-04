namespace SISCEM
{
    partial class rptEmpenio_detallado
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
            this.Empenio_DetalladoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRESTODataSet = new SISCEM.PRESTODataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Empenio_DetalladoTableAdapter = new SISCEM.PRESTODataSetTableAdapters.Empenio_DetalladoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Empenio_DetalladoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Empenio_DetalladoBindingSource
            // 
            this.Empenio_DetalladoBindingSource.DataMember = "Empenio_Detallado";
            this.Empenio_DetalladoBindingSource.DataSource = this.PRESTODataSet;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "detalle_empenio";
            reportDataSource1.Value = this.Empenio_DetalladoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.rptEmpenio_detallado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1215, 643);
            this.reportViewer1.TabIndex = 0;
            // 
            // Empenio_DetalladoTableAdapter
            // 
            this.Empenio_DetalladoTableAdapter.ClearBeforeFill = true;
            // 
            // rptEmpenio_detallado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 656);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptEmpenio_detallado";
            this.Text = "rptEmpenio_detallado";
            this.Load += new System.EventHandler(this.rptEmpenio_detallado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Empenio_DetalladoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Empenio_DetalladoBindingSource;
        private PRESTODataSet PRESTODataSet;
        private PRESTODataSetTableAdapters.Empenio_DetalladoTableAdapter Empenio_DetalladoTableAdapter;
    }
}