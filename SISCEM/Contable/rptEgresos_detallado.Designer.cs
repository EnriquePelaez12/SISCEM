namespace SISCEM
{
    partial class rptEgresos_detallado
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
            this.Egresos_detalladoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Egresos_detalladoTableAdapter = new SISCEM.PRESTODataSetTableAdapters.Egresos_detalladoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Egresos_detalladoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Detalle_Egresos";
            reportDataSource1.Value = this.Egresos_detalladoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.rptEgresos_detallado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(785, 484);
            this.reportViewer1.TabIndex = 0;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Egresos_detalladoBindingSource
            // 
            this.Egresos_detalladoBindingSource.DataMember = "Egresos_detallado";
            this.Egresos_detalladoBindingSource.DataSource = this.PRESTODataSet;
            // 
            // Egresos_detalladoTableAdapter
            // 
            this.Egresos_detalladoTableAdapter.ClearBeforeFill = true;
            // 
            // rptEgresos_detallado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 487);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptEgresos_detallado";
            this.Text = "rptEgresos_detallado";
            this.Load += new System.EventHandler(this.rptEgresos_detallado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Egresos_detalladoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Egresos_detalladoBindingSource;
        private PRESTODataSet PRESTODataSet;
        private PRESTODataSetTableAdapters.Egresos_detalladoTableAdapter Egresos_detalladoTableAdapter;
    }
}