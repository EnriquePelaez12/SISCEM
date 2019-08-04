namespace SISCEM
{
    partial class Consulta_Codigo_Venta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboleta_id = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.gvBoleta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvBoleta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boleta:";
            
            // 
            // txtboleta_id
            // 
            this.txtboleta_id.Location = new System.Drawing.Point(88, 33);
            this.txtboleta_id.Name = "txtboleta_id";
            this.txtboleta_id.Size = new System.Drawing.Size(100, 20);
            this.txtboleta_id.TabIndex = 1;
            
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(245, 31);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // gvBoleta
            // 
            this.gvBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBoleta.Location = new System.Drawing.Point(12, 84);
            this.gvBoleta.Name = "gvBoleta";
            this.gvBoleta.Size = new System.Drawing.Size(633, 281);
            this.gvBoleta.TabIndex = 3;
            
            // 
            // Consulta_Codigo_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 412);
            this.Controls.Add(this.gvBoleta);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtboleta_id);
            this.Controls.Add(this.label1);
            this.Name = "Consulta_Codigo_Venta";
            this.Text = "Consulta_Codigo_Venta";
            this.Load += new System.EventHandler(this.Consulta_Codigo_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBoleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboleta_id;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView gvBoleta;
    }
}