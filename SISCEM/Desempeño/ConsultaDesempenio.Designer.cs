﻿namespace SISCEM
{
    partial class ConsultaDesempenio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDesempenio));
            this.gvBoleta = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtdesempenio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncliente = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvBoleta)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBoleta
            // 
            this.gvBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBoleta.Location = new System.Drawing.Point(44, 163);
            this.gvBoleta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gvBoleta.Name = "gvBoleta";
            this.gvBoleta.Size = new System.Drawing.Size(1055, 411);
            this.gvBoleta.TabIndex = 11;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbuscar.Location = new System.Drawing.Point(431, 76);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(138, 46);
            this.btnbuscar.TabIndex = 10;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtdesempenio
            // 
            this.txtdesempenio.Location = new System.Drawing.Point(170, 88);
            this.txtdesempenio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtdesempenio.Name = "txtdesempenio";
            this.txtdesempenio.Size = new System.Drawing.Size(164, 27);
            this.txtdesempenio.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Desempeño:";
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btncliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncliente.Location = new System.Drawing.Point(730, 76);
            this.btncliente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(138, 46);
            this.btncliente.TabIndex = 14;
            this.btncliente.Text = "Buscar x Cliente";
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(170, 127);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(519, 27);
            this.txtnombre.TabIndex = 13;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cliente:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(-1, -3);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1144, 49);
            this.label13.TabIndex = 59;
            this.label13.Text = "Consulta de Desempeños";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalir.Location = new System.Drawing.Point(988, 79);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(138, 46);
            this.btnsalir.TabIndex = 60;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // ConsultaDesempenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1140, 611);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btncliente);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvBoleta);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtdesempenio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ConsultaDesempenio";
            this.Text = "ConsultaDesempenio";
            ((System.ComponentModel.ISupportInitialize)(this.gvBoleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvBoleta;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtdesempenio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnsalir;
    }
}