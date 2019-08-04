namespace SISCEM
{
    partial class rptdesempenio_detallado
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
            this.Desempenio_detalladoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRESTODataSet = new SISCEM.PRESTODataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Desempenio_detalladoTableAdapter = new SISCEM.PRESTODataSetTableAdapters.Desempenio_detalladoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Desempenio_detalladoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Desempenio_detalladoBindingSource
            // 
            this.Desempenio_detalladoBindingSource.DataMember = "Desempenio_detallado";
            this.Desempenio_detalladoBindingSource.DataSource = this.PRESTODataSet;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "Detalle";
            reportDataSource1.Value = this.Desempenio_detalladoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.rptdesempenio_detallado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1262, 659);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Desempenio_detalladoTableAdapter
            // 
            this.Desempenio_detalladoTableAdapter.ClearBeforeFill = true;
            // 
            // rptdesempenio_detallado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1273, 602);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptdesempenio_detallado";
            this.Text = "rptdesempenio_detallado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptdesempenio_detallado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Desempenio_detalladoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Desempenio_detalladoBindingSource;
        private PRESTODataSet PRESTODataSet;
        private PRESTODataSetTableAdapters.Desempenio_detalladoTableAdapter Desempenio_detalladoTableAdapter;
    }
}