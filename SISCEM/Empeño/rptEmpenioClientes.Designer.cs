﻿namespace SISCEM
{
    partial class rptEmpenioClientes
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
            this.ReporteEmpenioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRESTODataSet = new SISCEM.PRESTODataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteEmpenioTableAdapter = new SISCEM.PRESTODataSetTableAdapters.ReporteEmpenioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEmpenioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteEmpenioBindingSource
            // 
            this.ReporteEmpenioBindingSource.DataMember = "ReporteEmpenio";
            this.ReporteEmpenioBindingSource.DataSource = this.PRESTODataSet;
            // 
            // PRESTODataSet
            // 
            this.PRESTODataSet.DataSetName = "PRESTODataSet";
            this.PRESTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsEmpenios";
            reportDataSource1.Value = this.ReporteEmpenioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCEM.rptEmpenioClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(797, 410);
            this.reportViewer1.TabIndex = 1;
            
            // 
            // ReporteEmpenioTableAdapter
            // 
            this.ReporteEmpenioTableAdapter.ClearBeforeFill = true;
            // 
            // rptEmpenioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 410);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptEmpenioClientes";
            this.Text = "rptEmpenioClientes";
            this.Load += new System.EventHandler(this.rptEmpenioClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEmpenioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRESTODataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteEmpenioBindingSource;
        private PRESTODataSet PRESTODataSet;
        private PRESTODataSetTableAdapters.ReporteEmpenioTableAdapter ReporteEmpenioTableAdapter;
    }
}