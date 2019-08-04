namespace SISCEM
{
    partial class Refrendo_Ilimitado
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
            this.lblrefrendo = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblrefrendo
            // 
            this.lblrefrendo.AutoSize = true;
            this.lblrefrendo.Location = new System.Drawing.Point(468, 21);
            this.lblrefrendo.Name = "lblrefrendo";
            this.lblrefrendo.Size = new System.Drawing.Size(0, 13);
            this.lblrefrendo.TabIndex = 55;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblusuario.Location = new System.Drawing.Point(345, 45);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(53, 17);
            this.lblusuario.TabIndex = 52;
            this.lblusuario.Text = "Cajero:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbuscar.Location = new System.Drawing.Point(261, 44);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 51;
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
            this.groupBox1.Location = new System.Drawing.Point(24, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 171);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(324, 134);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(148, 20);
            this.txttotal.TabIndex = 16;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(272, 134);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(40, 13);
            this.lbltotal.TabIndex = 15;
            this.lbltotal.Text = "Total:";
            // 
            // txtprestamo
            // 
            this.txtprestamo.Location = new System.Drawing.Point(122, 44);
            this.txtprestamo.Name = "txtprestamo";
            this.txtprestamo.ReadOnly = true;
            this.txtprestamo.Size = new System.Drawing.Size(100, 20);
            this.txtprestamo.TabIndex = 11;
            // 
            // txtinteres
            // 
            this.txtinteres.Location = new System.Drawing.Point(122, 70);
            this.txtinteres.Name = "txtinteres";
            this.txtinteres.ReadOnly = true;
            this.txtinteres.Size = new System.Drawing.Size(100, 20);
            this.txtinteres.TabIndex = 12;
            // 
            // txtalmacenaje
            // 
            this.txtalmacenaje.Location = new System.Drawing.Point(122, 102);
            this.txtalmacenaje.Name = "txtalmacenaje";
            this.txtalmacenaje.ReadOnly = true;
            this.txtalmacenaje.Size = new System.Drawing.Size(100, 20);
            this.txtalmacenaje.TabIndex = 13;
            // 
            // txtiva
            // 
            this.txtiva.Location = new System.Drawing.Point(122, 134);
            this.txtiva.Name = "txtiva";
            this.txtiva.ReadOnly = true;
            this.txtiva.Size = new System.Drawing.Size(100, 20);
            this.txtiva.TabIndex = 14;
            // 
            // lblalmacenaje
            // 
            this.lblalmacenaje.AutoSize = true;
            this.lblalmacenaje.Location = new System.Drawing.Point(25, 105);
            this.lblalmacenaje.Name = "lblalmacenaje";
            this.lblalmacenaje.Size = new System.Drawing.Size(76, 13);
            this.lblalmacenaje.TabIndex = 8;
            this.lblalmacenaje.Text = "Almacenaje:";
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Location = new System.Drawing.Point(25, 134);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(31, 13);
            this.lbliva.TabIndex = 9;
            this.lbliva.Text = "IVA:";
            // 
            // lblprestamo
            // 
            this.lblprestamo.AutoSize = true;
            this.lblprestamo.Location = new System.Drawing.Point(25, 51);
            this.lblprestamo.Name = "lblprestamo";
            this.lblprestamo.Size = new System.Drawing.Size(63, 13);
            this.lblprestamo.TabIndex = 6;
            this.lblprestamo.Text = "Prestamo:";
            // 
            // lblinteres
            // 
            this.lblinteres.AutoSize = true;
            this.lblinteres.Location = new System.Drawing.Point(25, 77);
            this.lblinteres.Name = "lblinteres";
            this.lblinteres.Size = new System.Drawing.Size(50, 13);
            this.lblinteres.TabIndex = 7;
            this.lblinteres.Text = "Interes:";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(447, 307);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 43);
            this.btncancelar.TabIndex = 49;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btngenerar
            // 
            this.btngenerar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btngenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Location = new System.Drawing.Point(299, 307);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(84, 43);
            this.btngenerar.TabIndex = 48;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = false;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(136, 88);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(386, 20);
            this.txtcliente.TabIndex = 47;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(21, 84);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(50, 13);
            this.lblcliente.TabIndex = 46;
            this.lblcliente.Text = "Cliente:";
            // 
            // txtboleta_id
            // 
            this.txtboleta_id.Location = new System.Drawing.Point(136, 44);
            this.txtboleta_id.Name = "txtboleta_id";
            this.txtboleta_id.Size = new System.Drawing.Size(75, 20);
            this.txtboleta_id.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Numero de Boleta:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(29, 9);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(92, 13);
            this.lblnombre.TabIndex = 56;
            this.lblnombre.Text = "Refrendo Ilimitado";
            // 
            // Refrendo_Ilimitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 415);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblrefrendo);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.txtboleta_id);
            this.Controls.Add(this.label1);
            this.Name = "Refrendo_Ilimitado";
            this.Text = "Refrendo_Ilimitado";
            this.Load += new System.EventHandler(this.Refrendo_Ilimitado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrefrendo;
        private System.Windows.Forms.Label lblusuario;
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
        private System.Windows.Forms.Label lblnombre;
    }
}