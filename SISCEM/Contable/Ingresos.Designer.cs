namespace SISCEM
{
    partial class Ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresos));
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblconcepto = new System.Windows.Forms.Label();
            this.dgvconcepto = new System.Windows.Forms.DataGridView();
            this.txtconcepto = new System.Windows.Forms.TextBox();
            this.lblimporte = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblaeliminar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconcepto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnguardar.Location = new System.Drawing.Point(499, 79);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(138, 46);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncancelar.Location = new System.Drawing.Point(499, 128);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(138, 46);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btneliminar.Location = new System.Drawing.Point(679, 82);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(138, 46);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalir.Location = new System.Drawing.Point(679, 130);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(138, 46);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lblconcepto
            // 
            this.lblconcepto.AutoSize = true;
            this.lblconcepto.Location = new System.Drawing.Point(58, 82);
            this.lblconcepto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblconcepto.Name = "lblconcepto";
            this.lblconcepto.Size = new System.Drawing.Size(88, 19);
            this.lblconcepto.TabIndex = 4;
            this.lblconcepto.Text = "Concepto:";
            // 
            // dgvconcepto
            // 
            this.dgvconcepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconcepto.Location = new System.Drawing.Point(52, 228);
            this.dgvconcepto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvconcepto.Name = "dgvconcepto";
            this.dgvconcepto.Size = new System.Drawing.Size(771, 220);
            this.dgvconcepto.TabIndex = 6;
            this.dgvconcepto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvconcepto_CellMouseDoubleClick);
            // 
            // txtconcepto
            // 
            this.txtconcepto.Location = new System.Drawing.Point(162, 79);
            this.txtconcepto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtconcepto.Name = "txtconcepto";
            this.txtconcepto.Size = new System.Drawing.Size(223, 27);
            this.txtconcepto.TabIndex = 7;
            // 
            // lblimporte
            // 
            this.lblimporte.AutoSize = true;
            this.lblimporte.Location = new System.Drawing.Point(58, 143);
            this.lblimporte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblimporte.Name = "lblimporte";
            this.lblimporte.Size = new System.Drawing.Size(73, 19);
            this.lblimporte.TabIndex = 5;
            this.lblimporte.Text = "Importe:";
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(162, 133);
            this.txtimporte.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(223, 27);
            this.txtimporte.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Quitar linea:";
            // 
            // lblaeliminar
            // 
            this.lblaeliminar.AutoSize = true;
            this.lblaeliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaeliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblaeliminar.Location = new System.Drawing.Point(213, 189);
            this.lblaeliminar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblaeliminar.Name = "lblaeliminar";
            this.lblaeliminar.Size = new System.Drawing.Size(0, 20);
            this.lblaeliminar.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(-1, -1);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(898, 49);
            this.label13.TabIndex = 55;
            this.label13.Text = "Capruta de Ingresos";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(894, 505);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblaeliminar);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.txtconcepto);
            this.Controls.Add(this.dgvconcepto);
            this.Controls.Add(this.lblimporte);
            this.Controls.Add(this.lblconcepto);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Ingresos";
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.Ingresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconcepto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblconcepto;
        private System.Windows.Forms.DataGridView dgvconcepto;
        private System.Windows.Forms.TextBox txtconcepto;
        private System.Windows.Forms.Label lblimporte;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblaeliminar;
        internal System.Windows.Forms.Label label13;
    }
}