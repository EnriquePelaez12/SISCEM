namespace SISCEM
{
    partial class rptcortez
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
            this.rpvcortez = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvcortez
            // 
            this.rpvcortez.LocalReport.ReportEmbeddedResource = "SISCEM.CorteZ.rdlc";
            this.rpvcortez.Location = new System.Drawing.Point(-1, 1);
            this.rpvcortez.Name = "rpvcortez";
            this.rpvcortez.Size = new System.Drawing.Size(697, 421);
            this.rpvcortez.TabIndex = 0;
            // 
            // rptcortez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 423);
            this.Controls.Add(this.rpvcortez);
            this.Name = "rptcortez";
            this.Text = "rptcortez";
            this.Load += new System.EventHandler(this.rptcortez_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvcortez;
    }
}