namespace SISCEM
{
    partial class Consulta_Venta
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
            this.gvBoleta = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtventa_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncliente = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvBoleta)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBoleta
            // 
            this.gvBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBoleta.Location = new System.Drawing.Point(26, 68);
            this.gvBoleta.Name = "gvBoleta";
            this.gvBoleta.Size = new System.Drawing.Size(633, 281);
            this.gvBoleta.TabIndex = 7;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(259, 15);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 6;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtventa_id
            // 
            this.txtventa_id.Location = new System.Drawing.Point(102, 17);
            this.txtventa_id.Name = "txtventa_id";
            this.txtventa_id.Size = new System.Drawing.Size(100, 20);
            this.txtventa_id.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Boleta:";
            // 
            // btncliente
            // 
            this.btncliente.Location = new System.Drawing.Point(435, 38);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(107, 26);
            this.btncliente.TabIndex = 17;
            this.btncliente.Text = "Buscar x Cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(102, 44);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(313, 20);
            this.txtnombre.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cliente:";
            // 
            // Consulta_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 392);
            this.Controls.Add(this.btncliente);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvBoleta);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtventa_id);
            this.Controls.Add(this.label1);
            this.Name = "Consulta_Venta";
            this.Text = "Consulta_Venta";
            ((System.ComponentModel.ISupportInitialize)(this.gvBoleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvBoleta;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtventa_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
    }
}