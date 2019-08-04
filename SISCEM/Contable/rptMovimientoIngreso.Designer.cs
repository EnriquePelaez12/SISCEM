namespace SISCEM
{
    partial class rptMovimientoIngreso
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
            this.IngresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IngresosTableAdapter = new SISCEM.PRESTODataSetTableAdapters.IngresosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngresosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsMovimientoIngresos";
            reportDataSource1.Value = this.IngresosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.rptMovIngresos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(28, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(783, 402);
            this.reportViewer1.TabIndex = 0;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IngresosBindingSource
            // 
            this.IngresosBindingSource.DataMember = "Ingresos";
            this.IngresosBindingSource.DataSource = this.PRESTODataSet;
            // 
            // IngresosTableAdapter
            // 
            this.IngresosTableAdapter.ClearBeforeFill = true;
            // 
            // rptMovimientoIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 512);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptMovimientoIngreso";
            this.Text = "rptMovimientoIngreso";
            this.Load += new System.EventHandler(this.rptMovimientoIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngresosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IngresosBindingSource;
        private PRESTODataSet PRESTODataSet;
        private PRESTODataSetTableAdapters.IngresosTableAdapter IngresosTableAdapter;



    }
}