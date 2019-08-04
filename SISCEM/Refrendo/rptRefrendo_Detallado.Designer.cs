namespace SISCEM
{
    partial class rptRefrendo_Detallado
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
            this.Refrendo_DetalladoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRESTODataSet = new SISCEM.PRESTODataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Refrendo_DetalladoTableAdapter = new SISCEM.PRESTODataSetTableAdapters.Refrendo_DetalladoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Refrendo_DetalladoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Refrendo_DetalladoBindingSource
            // 
            this.Refrendo_DetalladoBindingSource.DataMember = "Refrendo_Detallado";
            this.Refrendo_DetalladoBindingSource.DataSource = this.PRESTODataSet;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "Detalle_Refrendo";
            reportDataSource1.Value = this.Refrendo_DetalladoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.rptrefrendo_detallado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1125, 460);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Refrendo_DetalladoTableAdapter
            // 
            this.Refrendo_DetalladoTableAdapter.ClearBeforeFill = true;
            // 
            // rptRefrendo_Detallado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1137, 463);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptRefrendo_Detallado";
            this.Text = "rptRefrendo_Detallado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptRefrendo_Detallado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Refrendo_DetalladoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Refrendo_DetalladoBindingSource;
        private PRESTODataSet PRESTODataSet;
        private PRESTODataSetTableAdapters.Refrendo_DetalladoTableAdapter Refrendo_DetalladoTableAdapter;
    }
}