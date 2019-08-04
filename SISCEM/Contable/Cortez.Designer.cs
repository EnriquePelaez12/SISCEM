namespace SISCEM
{
    partial class Cortez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cortez));
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnreporte = new System.Windows.Forms.Button();
            this.lblutilidad = new System.Windows.Forms.Label();
            this.txtutilidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblempeño = new System.Windows.Forms.Label();
            this.lblrefrendo = new System.Windows.Forms.Label();
            this.lbldesempeño = new System.Windows.Forms.Label();
            this.lblventas = new System.Windows.Forms.Label();
            this.txtempenio = new System.Windows.Forms.TextBox();
            this.txtdesempenio = new System.Windows.Forms.TextBox();
            this.txtrefrendo = new System.Windows.Forms.TextBox();
            this.txtventas = new System.Windows.Forms.TextBox();
            this.txtingresos = new System.Windows.Forms.TextBox();
            this.txtegresos = new System.Windows.Forms.TextBox();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblegresos = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(501, 64);
            this.dtpFecFin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(239, 27);
            this.dtpFecFin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Fin:";
            // 
            // dtpFecInicio
            // 
            this.dtpFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecInicio.Location = new System.Drawing.Point(139, 64);
            this.dtpFecInicio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpFecInicio.Name = "dtpFecInicio";
            this.dtpFecInicio.Size = new System.Drawing.Size(220, 27);
            this.dtpFecInicio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Inicio:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultar.Location = new System.Drawing.Point(44, 477);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(138, 46);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar Movimientos";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblutilidad);
            this.groupBox1.Controls.Add(this.txtutilidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFecFin);
            this.groupBox1.Controls.Add(this.dtpFecInicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(20, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(771, 188);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte de Movimientos Totales";
            // 
            // btnreporte
            // 
            this.btnreporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnreporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnreporte.Location = new System.Drawing.Point(340, 477);
            this.btnreporte.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(138, 46);
            this.btnreporte.TabIndex = 26;
            this.btnreporte.Text = "Generar Reporte";
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // lblutilidad
            // 
            this.lblutilidad.AutoSize = true;
            this.lblutilidad.Location = new System.Drawing.Point(20, 152);
            this.lblutilidad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblutilidad.Name = "lblutilidad";
            this.lblutilidad.Size = new System.Drawing.Size(70, 19);
            this.lblutilidad.TabIndex = 24;
            this.lblutilidad.Text = "Utilidad:";
            // 
            // txtutilidad
            // 
            this.txtutilidad.Location = new System.Drawing.Point(139, 147);
            this.txtutilidad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtutilidad.Name = "txtutilidad";
            this.txtutilidad.Size = new System.Drawing.Size(220, 27);
            this.txtutilidad.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 11;
            // 
            // lblempeño
            // 
            this.lblempeño.AutoSize = true;
            this.lblempeño.Location = new System.Drawing.Point(40, 290);
            this.lblempeño.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblempeño.Name = "lblempeño";
            this.lblempeño.Size = new System.Drawing.Size(77, 19);
            this.lblempeño.TabIndex = 12;
            this.lblempeño.Text = "Empeño:";
            // 
            // lblrefrendo
            // 
            this.lblrefrendo.AutoSize = true;
            this.lblrefrendo.Location = new System.Drawing.Point(416, 290);
            this.lblrefrendo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblrefrendo.Name = "lblrefrendo";
            this.lblrefrendo.Size = new System.Drawing.Size(85, 19);
            this.lblrefrendo.TabIndex = 13;
            this.lblrefrendo.Text = "Refrendo:";
            // 
            // lbldesempeño
            // 
            this.lbldesempeño.AutoSize = true;
            this.lbldesempeño.Location = new System.Drawing.Point(40, 352);
            this.lbldesempeño.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbldesempeño.Name = "lbldesempeño";
            this.lbldesempeño.Size = new System.Drawing.Size(105, 19);
            this.lbldesempeño.TabIndex = 14;
            this.lbldesempeño.Text = "Desempeño:";
            // 
            // lblventas
            // 
            this.lblventas.AutoSize = true;
            this.lblventas.Location = new System.Drawing.Point(416, 352);
            this.lblventas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblventas.Name = "lblventas";
            this.lblventas.Size = new System.Drawing.Size(66, 19);
            this.lblventas.TabIndex = 15;
            this.lblventas.Text = "Ventas:";
            // 
            // txtempenio
            // 
            this.txtempenio.Location = new System.Drawing.Point(159, 290);
            this.txtempenio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtempenio.Name = "txtempenio";
            this.txtempenio.Size = new System.Drawing.Size(220, 27);
            this.txtempenio.TabIndex = 16;
            // 
            // txtdesempenio
            // 
            this.txtdesempenio.Location = new System.Drawing.Point(159, 347);
            this.txtdesempenio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtdesempenio.Name = "txtdesempenio";
            this.txtdesempenio.Size = new System.Drawing.Size(220, 27);
            this.txtdesempenio.TabIndex = 17;
            // 
            // txtrefrendo
            // 
            this.txtrefrendo.Location = new System.Drawing.Point(521, 280);
            this.txtrefrendo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtrefrendo.Name = "txtrefrendo";
            this.txtrefrendo.Size = new System.Drawing.Size(220, 27);
            this.txtrefrendo.TabIndex = 18;
            // 
            // txtventas
            // 
            this.txtventas.Location = new System.Drawing.Point(521, 352);
            this.txtventas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtventas.Name = "txtventas";
            this.txtventas.Size = new System.Drawing.Size(220, 27);
            this.txtventas.TabIndex = 19;
            // 
            // txtingresos
            // 
            this.txtingresos.Location = new System.Drawing.Point(159, 406);
            this.txtingresos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtingresos.Name = "txtingresos";
            this.txtingresos.Size = new System.Drawing.Size(220, 27);
            this.txtingresos.TabIndex = 20;
            // 
            // txtegresos
            // 
            this.txtegresos.Location = new System.Drawing.Point(521, 406);
            this.txtegresos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtegresos.Name = "txtegresos";
            this.txtegresos.Size = new System.Drawing.Size(220, 27);
            this.txtegresos.TabIndex = 21;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(40, 416);
            this.lblIngresos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(82, 19);
            this.lblIngresos.TabIndex = 22;
            this.lblIngresos.Text = "Ingresos:";
            // 
            // lblegresos
            // 
            this.lblegresos.AutoSize = true;
            this.lblegresos.Location = new System.Drawing.Point(400, 416);
            this.lblegresos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblegresos.Name = "lblegresos";
            this.lblegresos.Size = new System.Drawing.Size(78, 19);
            this.lblegresos.TabIndex = 23;
            this.lblegresos.Text = "Egresos:";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(0, -1);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(796, 58);
            this.label13.TabIndex = 54;
            this.label13.Text = "Reporte de Utilidad en Sucursal";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalir.Location = new System.Drawing.Point(591, 477);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(138, 46);
            this.btnsalir.TabIndex = 27;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Cortez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(796, 602);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblegresos);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtegresos);
            this.Controls.Add(this.txtingresos);
            this.Controls.Add(this.txtventas);
            this.Controls.Add(this.txtrefrendo);
            this.Controls.Add(this.txtdesempenio);
            this.Controls.Add(this.txtempenio);
            this.Controls.Add(this.lblventas);
            this.Controls.Add(this.lbldesempeño);
            this.Controls.Add(this.lblrefrendo);
            this.Controls.Add(this.lblempeño);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Cortez";
            this.Text = "Cortez";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFecInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblutilidad;
        private System.Windows.Forms.TextBox txtutilidad;
        private System.Windows.Forms.Label lblempeño;
        private System.Windows.Forms.Label lblrefrendo;
        private System.Windows.Forms.Label lbldesempeño;
        private System.Windows.Forms.Label lblventas;
        private System.Windows.Forms.TextBox txtempenio;
        private System.Windows.Forms.TextBox txtdesempenio;
        private System.Windows.Forms.TextBox txtrefrendo;
        private System.Windows.Forms.TextBox txtventas;
        private System.Windows.Forms.TextBox txtingresos;
        private System.Windows.Forms.TextBox txtegresos;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblegresos;
        private System.Windows.Forms.Button btnreporte;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnsalir;
    }
}