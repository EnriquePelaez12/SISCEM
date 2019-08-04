namespace SISCEM
{
    partial class Actualiza_Kilates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualiza_Kilates));
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.lblprecio_venta = new System.Windows.Forms.Label();
            this.lblcatalogo = new System.Windows.Forms.Label();
            this.dgvkilataje = new System.Windows.Forms.DataGridView();
            this.txtkilatajeid = new System.Windows.Forms.TextBox();
            this.lblkilatajeid = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblprecio_compra = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtidkilate = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkilataje)).BeginInit();
            this.SuspendLayout();
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(504, 126);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(213, 22);
            this.txtprecioventa.TabIndex = 16;
            // 
            // lblprecio_venta
            // 
            this.lblprecio_venta.AutoSize = true;
            this.lblprecio_venta.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio_venta.Location = new System.Drawing.Point(377, 134);
            this.lblprecio_venta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprecio_venta.Name = "lblprecio_venta";
            this.lblprecio_venta.Size = new System.Drawing.Size(112, 19);
            this.lblprecio_venta.TabIndex = 22;
            this.lblprecio_venta.Text = "Precio Venta:";
            // 
            // lblcatalogo
            // 
            this.lblcatalogo.AutoSize = true;
            this.lblcatalogo.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatalogo.Location = new System.Drawing.Point(16, 199);
            this.lblcatalogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcatalogo.Name = "lblcatalogo";
            this.lblcatalogo.Size = new System.Drawing.Size(31, 19);
            this.lblcatalogo.TabIndex = 21;
            this.lblcatalogo.Text = "ID:";
            // 
            // dgvkilataje
            // 
            this.dgvkilataje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkilataje.Location = new System.Drawing.Point(20, 242);
            this.dgvkilataje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvkilataje.Name = "dgvkilataje";
            this.dgvkilataje.Size = new System.Drawing.Size(895, 268);
            this.dgvkilataje.TabIndex = 20;
            this.dgvkilataje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkilataje_CellContentClick);
            // 
            // txtkilatajeid
            // 
            this.txtkilatajeid.Location = new System.Drawing.Point(118, 80);
            this.txtkilatajeid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtkilatajeid.Name = "txtkilatajeid";
            this.txtkilatajeid.ReadOnly = true;
            this.txtkilatajeid.Size = new System.Drawing.Size(227, 22);
            this.txtkilatajeid.TabIndex = 11;
            // 
            // lblkilatajeid
            // 
            this.lblkilatajeid.AutoSize = true;
            this.lblkilatajeid.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkilatajeid.Location = new System.Drawing.Point(16, 80);
            this.lblkilatajeid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkilatajeid.Name = "lblkilatajeid";
            this.lblkilatajeid.Size = new System.Drawing.Size(36, 19);
            this.lblkilatajeid.TabIndex = 19;
            this.lblkilatajeid.Text = "No:";
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(504, 75);
            this.txtpreciocompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(213, 22);
            this.txtpreciocompra.TabIndex = 15;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(118, 125);
            this.txtvalor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(227, 22);
            this.txtvalor.TabIndex = 12;
            // 
            // lblprecio_compra
            // 
            this.lblprecio_compra.AutoSize = true;
            this.lblprecio_compra.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio_compra.Location = new System.Drawing.Point(366, 76);
            this.lblprecio_compra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprecio_compra.Name = "lblprecio_compra";
            this.lblprecio_compra.Size = new System.Drawing.Size(130, 19);
            this.lblprecio_compra.TabIndex = 14;
            this.lblprecio_compra.Text = "Precio Compra:";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(16, 126);
            this.lblvalor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(54, 19);
            this.lblvalor.TabIndex = 13;
            this.lblvalor.Text = "Valor:";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btncancelar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncancelar.Location = new System.Drawing.Point(777, 126);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(138, 46);
            this.btncancelar.TabIndex = 18;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnguardar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnguardar.Location = new System.Drawing.Point(777, 62);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(138, 46);
            this.btnguardar.TabIndex = 17;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtidkilate
            // 
            this.txtidkilate.Location = new System.Drawing.Point(118, 198);
            this.txtidkilate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidkilate.Name = "txtidkilate";
            this.txtidkilate.Size = new System.Drawing.Size(227, 22);
            this.txtidkilate.TabIndex = 23;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnbuscar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbuscar.Location = new System.Drawing.Point(390, 185);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(138, 46);
            this.btnbuscar.TabIndex = 24;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnmodificar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodificar.Location = new System.Drawing.Point(612, 185);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(138, 46);
            this.btnmodificar.TabIndex = 25;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(-1, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(994, 49);
            this.label13.TabIndex = 53;
            this.label13.Text = "Actualiza Kilatajes";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsalir.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalir.Location = new System.Drawing.Point(777, 185);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(138, 46);
            this.btnsalir.TabIndex = 54;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Actualiza_Kilates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(992, 541);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtidkilate);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.lblprecio_venta);
            this.Controls.Add(this.lblcatalogo);
            this.Controls.Add(this.dgvkilataje);
            this.Controls.Add(this.txtkilatajeid);
            this.Controls.Add(this.lblkilatajeid);
            this.Controls.Add(this.txtpreciocompra);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblprecio_compra);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Actualiza_Kilates";
            this.Text = "Actualiza_Kilates";
            this.Load += new System.EventHandler(this.Actualiza_Kilates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkilataje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label lblprecio_venta;
        private System.Windows.Forms.Label lblcatalogo;
        private System.Windows.Forms.DataGridView dgvkilataje;
        private System.Windows.Forms.TextBox txtkilatajeid;
        private System.Windows.Forms.Label lblkilatajeid;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblprecio_compra;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtidkilate;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnmodificar;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnsalir;
    }
}