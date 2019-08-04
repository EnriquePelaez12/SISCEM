namespace SISCEM
{
    partial class Venta_Prendas
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblcodig = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblboleta = new System.Windows.Forms.Label();
            this.lblkilataje = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblpiedra = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtboleta = new System.Windows.Forms.TextBox();
            this.txtkilataje = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtpiedra = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.txtcliente_id = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.txtnombre_cliente = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblventa = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(317, 27);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(63, 20);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblcodig
            // 
            this.lblcodig.AutoSize = true;
            this.lblcodig.Location = new System.Drawing.Point(34, 35);
            this.lblcodig.Name = "lblcodig";
            this.lblcodig.Size = new System.Drawing.Size(83, 13);
            this.lblcodig.TabIndex = 1;
            this.lblcodig.Text = "Codigo_Prenda:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(148, 28);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(152, 20);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // lblboleta
            // 
            this.lblboleta.AutoSize = true;
            this.lblboleta.Location = new System.Drawing.Point(34, 66);
            this.lblboleta.Name = "lblboleta";
            this.lblboleta.Size = new System.Drawing.Size(40, 13);
            this.lblboleta.TabIndex = 3;
            this.lblboleta.Text = "Boleta:";
            // 
            // lblkilataje
            // 
            this.lblkilataje.AutoSize = true;
            this.lblkilataje.Location = new System.Drawing.Point(34, 143);
            this.lblkilataje.Name = "lblkilataje";
            this.lblkilataje.Size = new System.Drawing.Size(44, 13);
            this.lblkilataje.TabIndex = 4;
            this.lblkilataje.Text = "Kilataje:";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(34, 264);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbldescripcion.TabIndex = 5;
            this.lbldescripcion.Text = "Descripción:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(32, 105);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(55, 13);
            this.lblcategoria.TabIndex = 9;
            this.lblcategoria.Text = "Categoria:";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(32, 183);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(34, 13);
            this.lblpeso.TabIndex = 10;
            this.lblpeso.Text = "Peso:";
            // 
            // lblpiedra
            // 
            this.lblpiedra.AutoSize = true;
            this.lblpiedra.Location = new System.Drawing.Point(33, 223);
            this.lblpiedra.Name = "lblpiedra";
            this.lblpiedra.Size = new System.Drawing.Size(40, 13);
            this.lblpiedra.TabIndex = 11;
            this.lblpiedra.Text = "Piedra:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(320, 179);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(34, 13);
            this.lbltotal.TabIndex = 12;
            this.lbltotal.Text = "Total:";
            // 
            // txtboleta
            // 
            this.txtboleta.Location = new System.Drawing.Point(148, 66);
            this.txtboleta.Name = "txtboleta";
            this.txtboleta.ReadOnly = true;
            this.txtboleta.Size = new System.Drawing.Size(152, 20);
            this.txtboleta.TabIndex = 13;
            // 
            // txtkilataje
            // 
            this.txtkilataje.Location = new System.Drawing.Point(148, 136);
            this.txtkilataje.Name = "txtkilataje";
            this.txtkilataje.ReadOnly = true;
            this.txtkilataje.Size = new System.Drawing.Size(152, 20);
            this.txtkilataje.TabIndex = 14;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(148, 98);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.ReadOnly = true;
            this.txtcategoria.Size = new System.Drawing.Size(152, 20);
            this.txtcategoria.TabIndex = 15;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(148, 176);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.ReadOnly = true;
            this.txtpeso.Size = new System.Drawing.Size(152, 20);
            this.txtpeso.TabIndex = 16;
            // 
            // txtpiedra
            // 
            this.txtpiedra.Location = new System.Drawing.Point(148, 216);
            this.txtpiedra.Name = "txtpiedra";
            this.txtpiedra.ReadOnly = true;
            this.txtpiedra.Size = new System.Drawing.Size(152, 20);
            this.txtpiedra.TabIndex = 17;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(35, 293);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.ReadOnly = true;
            this.txtdescripcion.Size = new System.Drawing.Size(271, 185);
            this.txtdescripcion.TabIndex = 18;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(426, 176);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(132, 20);
            this.txttotal.TabIndex = 19;
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(478, 223);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(80, 34);
            this.btnprocesar.TabIndex = 3;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.BackColor = System.Drawing.Color.Blue;
            this.btnbuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarcliente.ForeColor = System.Drawing.Color.White;
            this.btnbuscarcliente.Location = new System.Drawing.Point(492, 67);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(66, 25);
            this.btnbuscarcliente.TabIndex = 45;
            this.btnbuscarcliente.Text = "Buscar..";
            this.btnbuscarcliente.UseVisualStyleBackColor = false;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // txtcliente_id
            // 
            this.txtcliente_id.Location = new System.Drawing.Point(385, 69);
            this.txtcliente_id.Name = "txtcliente_id";
            this.txtcliente_id.ReadOnly = true;
            this.txtcliente_id.Size = new System.Drawing.Size(82, 20);
            this.txtcliente_id.TabIndex = 46;
            this.txtcliente_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcliente_id_KeyPress);
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(323, 69);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(57, 13);
            this.lblcliente.TabIndex = 47;
            this.lblcliente.Text = "Cliente_Id:";
            // 
            // txtnombre_cliente
            // 
            this.txtnombre_cliente.Location = new System.Drawing.Point(385, 105);
            this.txtnombre_cliente.Name = "txtnombre_cliente";
            this.txtnombre_cliente.Size = new System.Drawing.Size(173, 20);
            this.txtnombre_cliente.TabIndex = 48;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(323, 105);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(42, 13);
            this.lblnombre.TabIndex = 49;
            this.lblnombre.Text = "Cliente:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(478, 264);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(80, 34);
            this.btncancelar.TabIndex = 50;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblusuario.Location = new System.Drawing.Point(492, 13);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(10, 13);
            this.lblusuario.TabIndex = 51;
            this.lblusuario.Text = ":";
            // 
            // lblventa
            // 
            this.lblventa.AutoSize = true;
            this.lblventa.Location = new System.Drawing.Point(667, 13);
            this.lblventa.Name = "lblventa";
            this.lblventa.Size = new System.Drawing.Size(35, 13);
            this.lblventa.TabIndex = 52;
            this.lblventa.Text = "Venta";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(39, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 53;
            // 
            // Venta_Prendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 490);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblventa);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtnombre_cliente);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.txtcliente_id);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtpiedra);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtkilataje);
            this.Controls.Add(this.txtboleta);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblpiedra);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblkilataje);
            this.Controls.Add(this.lblboleta);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodig);
            this.Controls.Add(this.btnbuscar);
            this.Name = "Venta_Prendas";
            this.Text = "Venta de Prendas";
            this.Load += new System.EventHandler(this.Venta_Prendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblcodig;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblboleta;
        private System.Windows.Forms.Label lblkilataje;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblpiedra;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtboleta;
        private System.Windows.Forms.TextBox txtkilataje;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtpiedra;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.TextBox txtcliente_id;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TextBox txtnombre_cliente;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblventa;
        private System.Windows.Forms.Label lblid;
    }
}