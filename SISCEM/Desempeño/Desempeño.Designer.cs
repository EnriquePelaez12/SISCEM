namespace SISCEM
{
    partial class Desempeño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desempeño));
            this.btnbuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtprestamo = new System.Windows.Forms.TextBox();
            this.txtinteres = new System.Windows.Forms.TextBox();
            this.txtalmacenaje = new System.Windows.Forms.TextBox();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.lblalmacenaje = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.lblprestamo = new System.Windows.Forms.Label();
            this.lblinteres = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btngenerar = new System.Windows.Forms.Button();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.txtboleta_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lbsemana = new System.Windows.Forms.Label();
            this.cbxsemana = new System.Windows.Forms.ComboBox();
            this.lbldesempenio = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbuscar.Location = new System.Drawing.Point(771, 115);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(138, 46);
            this.btnbuscar.TabIndex = 19;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.lbltotal);
            this.groupBox1.Controls.Add(this.txtprestamo);
            this.groupBox1.Controls.Add(this.txtinteres);
            this.groupBox1.Controls.Add(this.txtalmacenaje);
            this.groupBox1.Controls.Add(this.txtiva);
            this.groupBox1.Controls.Add(this.lblalmacenaje);
            this.groupBox1.Controls.Add(this.lbliva);
            this.groupBox1.Controls.Add(this.lblprestamo);
            this.groupBox1.Controls.Add(this.lblinteres);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 211);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(830, 249);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(540, 196);
            this.txttotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(244, 23);
            this.txttotal.TabIndex = 16;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(454, 196);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(50, 17);
            this.lbltotal.TabIndex = 15;
            this.lbltotal.Text = "Total:";
            // 
            // txtprestamo
            // 
            this.txtprestamo.Location = new System.Drawing.Point(204, 64);
            this.txtprestamo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtprestamo.Name = "txtprestamo";
            this.txtprestamo.ReadOnly = true;
            this.txtprestamo.Size = new System.Drawing.Size(164, 23);
            this.txtprestamo.TabIndex = 11;
            // 
            // txtinteres
            // 
            this.txtinteres.Location = new System.Drawing.Point(204, 102);
            this.txtinteres.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtinteres.Name = "txtinteres";
            this.txtinteres.ReadOnly = true;
            this.txtinteres.Size = new System.Drawing.Size(164, 23);
            this.txtinteres.TabIndex = 12;
            // 
            // txtalmacenaje
            // 
            this.txtalmacenaje.Location = new System.Drawing.Point(204, 150);
            this.txtalmacenaje.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtalmacenaje.Name = "txtalmacenaje";
            this.txtalmacenaje.ReadOnly = true;
            this.txtalmacenaje.Size = new System.Drawing.Size(164, 23);
            this.txtalmacenaje.TabIndex = 13;
            // 
            // txtiva
            // 
            this.txtiva.Location = new System.Drawing.Point(204, 196);
            this.txtiva.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtiva.Name = "txtiva";
            this.txtiva.ReadOnly = true;
            this.txtiva.Size = new System.Drawing.Size(164, 23);
            this.txtiva.TabIndex = 14;
            // 
            // lblalmacenaje
            // 
            this.lblalmacenaje.AutoSize = true;
            this.lblalmacenaje.Location = new System.Drawing.Point(41, 153);
            this.lblalmacenaje.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblalmacenaje.Name = "lblalmacenaje";
            this.lblalmacenaje.Size = new System.Drawing.Size(96, 17);
            this.lblalmacenaje.TabIndex = 8;
            this.lblalmacenaje.Text = "Almacenaje:";
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Location = new System.Drawing.Point(41, 196);
            this.lbliva.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(37, 17);
            this.lbliva.TabIndex = 9;
            this.lbliva.Text = "IVA:";
            // 
            // lblprestamo
            // 
            this.lblprestamo.AutoSize = true;
            this.lblprestamo.Location = new System.Drawing.Point(41, 75);
            this.lblprestamo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblprestamo.Name = "lblprestamo";
            this.lblprestamo.Size = new System.Drawing.Size(81, 17);
            this.lblprestamo.TabIndex = 6;
            this.lblprestamo.Text = "Prestamo:";
            // 
            // lblinteres
            // 
            this.lblinteres.AutoSize = true;
            this.lblinteres.Location = new System.Drawing.Point(41, 113);
            this.lblinteres.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblinteres.Name = "lblinteres";
            this.lblinteres.Size = new System.Drawing.Size(63, 17);
            this.lblinteres.TabIndex = 7;
            this.lblinteres.Text = "Interes:";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncancelar.Location = new System.Drawing.Point(485, 493);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(138, 46);
            this.btncancelar.TabIndex = 17;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btngenerar
            // 
            this.btngenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btngenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btngenerar.Location = new System.Drawing.Point(239, 493);
            this.btngenerar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(138, 46);
            this.btngenerar.TabIndex = 16;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = false;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(254, 173);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(640, 27);
            this.txtcliente.TabIndex = 15;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(61, 167);
            this.lblcliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(63, 17);
            this.lblcliente.TabIndex = 14;
            this.lblcliente.Text = "Cliente:";
            // 
            // txtboleta_id
            // 
            this.txtboleta_id.Location = new System.Drawing.Point(254, 120);
            this.txtboleta_id.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtboleta_id.Name = "txtboleta_id";
            this.txtboleta_id.Size = new System.Drawing.Size(123, 27);
            this.txtboleta_id.TabIndex = 13;
            this.txtboleta_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboleta_id_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numero de Boleta:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblusuario.Location = new System.Drawing.Point(520, 75);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(14, 20);
            this.lblusuario.TabIndex = 20;
            this.lblusuario.Text = ":";
            // 
            // lbsemana
            // 
            this.lbsemana.AutoSize = true;
            this.lbsemana.Location = new System.Drawing.Point(420, 126);
            this.lbsemana.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbsemana.Name = "lbsemana";
            this.lbsemana.Size = new System.Drawing.Size(76, 19);
            this.lbsemana.TabIndex = 42;
            this.lbsemana.Text = "Semana:";
            // 
            // cbxsemana
            // 
            this.cbxsemana.FormattingEnabled = true;
            this.cbxsemana.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbxsemana.Location = new System.Drawing.Point(525, 115);
            this.cbxsemana.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbxsemana.Name = "cbxsemana";
            this.cbxsemana.Size = new System.Drawing.Size(199, 27);
            this.cbxsemana.TabIndex = 41;
            // 
            // lbldesempenio
            // 
            this.lbldesempenio.AutoSize = true;
            this.lbldesempenio.Location = new System.Drawing.Point(249, 83);
            this.lbldesempenio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbldesempenio.Name = "lbldesempenio";
            this.lbldesempenio.Size = new System.Drawing.Size(0, 19);
            this.lbldesempenio.TabIndex = 43;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(61, 83);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(104, 19);
            this.lblnombre.TabIndex = 44;
            this.lblnombre.Text = "Desempenio";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(-2, -3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1108, 49);
            this.label2.TabIndex = 59;
            this.label2.Text = "Registro de Desempeño";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalir.Location = new System.Drawing.Point(712, 493);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(138, 46);
            this.btnsalir.TabIndex = 60;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Desempeño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1106, 572);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbldesempenio);
            this.Controls.Add(this.lbsemana);
            this.Controls.Add(this.cbxsemana);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.txtboleta_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Desempeño";
            this.Text = "Desempeño";
            this.Load += new System.EventHandler(this.Desempeño_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtprestamo;
        private System.Windows.Forms.TextBox txtinteres;
        private System.Windows.Forms.TextBox txtalmacenaje;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.Label lblalmacenaje;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label lblprestamo;
        private System.Windows.Forms.Label lblinteres;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TextBox txtboleta_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lbsemana;
        private System.Windows.Forms.ComboBox cbxsemana;
        private System.Windows.Forms.Label lbldesempenio;
        private System.Windows.Forms.Label lblnombre;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsalir;
    }
}