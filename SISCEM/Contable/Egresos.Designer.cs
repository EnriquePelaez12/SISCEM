namespace SISCEM
{
    partial class Egresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Egresos));
            this.dgvconcepto = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblimporte = new System.Windows.Forms.Label();
            this.lblconcepto = new System.Windows.Forms.Label();
            this.txtconcepto = new System.Windows.Forms.TextBox();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblaeliminar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconcepto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvconcepto
            // 
            this.dgvconcepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconcepto.Location = new System.Drawing.Point(40, 253);
            this.dgvconcepto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvconcepto.Name = "dgvconcepto";
            this.dgvconcepto.Size = new System.Drawing.Size(771, 220);
            this.dgvconcepto.TabIndex = 11;
            this.dgvconcepto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvconcepto_CellMouseDoubleClick);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalir.Location = new System.Drawing.Point(668, 144);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(138, 46);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btneliminar.Location = new System.Drawing.Point(668, 97);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(138, 46);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncancelar.Location = new System.Drawing.Point(488, 142);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(138, 46);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnguardar.Location = new System.Drawing.Point(488, 93);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(138, 46);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblimporte
            // 
            this.lblimporte.AutoSize = true;
            this.lblimporte.Location = new System.Drawing.Point(51, 157);
            this.lblimporte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblimporte.Name = "lblimporte";
            this.lblimporte.Size = new System.Drawing.Size(73, 19);
            this.lblimporte.TabIndex = 13;
            this.lblimporte.Text = "Importe:";
            // 
            // lblconcepto
            // 
            this.lblconcepto.AutoSize = true;
            this.lblconcepto.Location = new System.Drawing.Point(51, 97);
            this.lblconcepto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblconcepto.Name = "lblconcepto";
            this.lblconcepto.Size = new System.Drawing.Size(88, 19);
            this.lblconcepto.TabIndex = 12;
            this.lblconcepto.Text = "Concepto:";
            // 
            // txtconcepto
            // 
            this.txtconcepto.Location = new System.Drawing.Point(156, 97);
            this.txtconcepto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtconcepto.Name = "txtconcepto";
            this.txtconcepto.Size = new System.Drawing.Size(215, 27);
            this.txtconcepto.TabIndex = 14;
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(156, 153);
            this.txtimporte.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(215, 27);
            this.txtimporte.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Quitar linea:";
            // 
            // lblaeliminar
            // 
            this.lblaeliminar.AutoSize = true;
            this.lblaeliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaeliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblaeliminar.Location = new System.Drawing.Point(206, 224);
            this.lblaeliminar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblaeliminar.Name = "lblaeliminar";
            this.lblaeliminar.Size = new System.Drawing.Size(0, 20);
            this.lblaeliminar.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(-1, -6);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(940, 58);
            this.label13.TabIndex = 57;
            this.label13.Text = "Captura de Egresos";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(939, 505);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblaeliminar);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.txtconcepto);
            this.Controls.Add(this.lblimporte);
            this.Controls.Add(this.lblconcepto);
            this.Controls.Add(this.dgvconcepto);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Egresos";
            this.Text = "Egresos";
            this.Load += new System.EventHandler(this.Egresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconcepto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvconcepto;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblimporte;
        private System.Windows.Forms.Label lblconcepto;
        private System.Windows.Forms.TextBox txtconcepto;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblaeliminar;
        internal System.Windows.Forms.Label label13;
    }
}