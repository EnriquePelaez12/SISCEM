namespace SISCEM
{
    partial class Empeño
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empeño));
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblidentificacion = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtcotitular = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblclienteid = new System.Windows.Forms.Label();
            this.txtcliennte_id = new System.Windows.Forms.TextBox();
            this.grouboxtitular = new System.Windows.Forms.GroupBox();
            this.groupboxTipo = new System.Windows.Forms.GroupBox();
            this.txtprestamo = new System.Windows.Forms.TextBox();
            this.lblprestamo = new System.Windows.Forms.Label();
            this.lblplazo = new System.Windows.Forms.Label();
            this.cmbplazo = new System.Windows.Forms.ComboBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtpiedra = new System.Windows.Forms.TextBox();
            this.lblpiedra = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblpeso = new System.Windows.Forms.Label();
            this.cmbmarca = new System.Windows.Forms.ComboBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.cmbpresentacion = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblkilataje = new System.Windows.Forms.Label();
            this.cmbkilataje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxtipo = new System.Windows.Forms.ComboBox();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.btnguadar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal_prestamo = new System.Windows.Forms.TextBox();
            this.lblcontador = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCellValue = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRowValue = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.txttotal_avaluo = new System.Windows.Forms.TextBox();
            this.lblaeliminar = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnoboleta = new System.Windows.Forms.Label();
            this.lblcat = new System.Windows.Forms.Label();
            this.lblkil = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.grouboxtitular.SuspendLayout();
            this.groupboxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(35, 70);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(80, 20);
            this.lblnombre.TabIndex = 15;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblidentificacion
            // 
            this.lblidentificacion.AutoSize = true;
            this.lblidentificacion.Location = new System.Drawing.Point(33, 111);
            this.lblidentificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidentificacion.Name = "lblidentificacion";
            this.lblidentificacion.Size = new System.Drawing.Size(87, 20);
            this.lblidentificacion.TabIndex = 21;
            this.lblidentificacion.Text = "Cotitular:";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(33, 146);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(96, 20);
            this.lbldireccion.TabIndex = 24;
            this.lbldireccion.Text = "Direccion:";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(33, 199);
            this.lblmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(62, 20);
            this.lblmail.TabIndex = 27;
            this.lblmail.Text = "Email:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(185, 62);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(283, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtcotitular
            // 
            this.txtcotitular.Location = new System.Drawing.Point(184, 102);
            this.txtcotitular.Margin = new System.Windows.Forms.Padding(4);
            this.txtcotitular.Name = "txtcotitular";
            this.txtcotitular.ReadOnly = true;
            this.txtcotitular.Size = new System.Drawing.Size(283, 26);
            this.txtcotitular.TabIndex = 20;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(181, 146);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.ReadOnly = true;
            this.txtdireccion.Size = new System.Drawing.Size(285, 26);
            this.txtdireccion.TabIndex = 25;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(181, 191);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(285, 26);
            this.txtemail.TabIndex = 26;
            // 
            // lblclienteid
            // 
            this.lblclienteid.AutoSize = true;
            this.lblclienteid.Location = new System.Drawing.Point(39, 28);
            this.lblclienteid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblclienteid.Name = "lblclienteid";
            this.lblclienteid.Size = new System.Drawing.Size(99, 20);
            this.lblclienteid.TabIndex = 37;
            this.lblclienteid.Text = "Cliente_Id:";
            // 
            // txtcliennte_id
            // 
            this.txtcliennte_id.Location = new System.Drawing.Point(184, 28);
            this.txtcliennte_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtcliennte_id.Name = "txtcliennte_id";
            this.txtcliennte_id.Size = new System.Drawing.Size(283, 26);
            this.txtcliennte_id.TabIndex = 1;
            this.txtcliennte_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // grouboxtitular
            // 
            this.grouboxtitular.BackColor = System.Drawing.Color.White;
            this.grouboxtitular.Controls.Add(this.txtcliennte_id);
            this.grouboxtitular.Controls.Add(this.lblclienteid);
            this.grouboxtitular.Controls.Add(this.txtemail);
            this.grouboxtitular.Controls.Add(this.txtdireccion);
            this.grouboxtitular.Controls.Add(this.txtcotitular);
            this.grouboxtitular.Controls.Add(this.txtNombre);
            this.grouboxtitular.Controls.Add(this.lblmail);
            this.grouboxtitular.Controls.Add(this.lbldireccion);
            this.grouboxtitular.Controls.Add(this.lblidentificacion);
            this.grouboxtitular.Controls.Add(this.lblnombre);
            this.grouboxtitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouboxtitular.Location = new System.Drawing.Point(34, 123);
            this.grouboxtitular.Margin = new System.Windows.Forms.Padding(4);
            this.grouboxtitular.Name = "grouboxtitular";
            this.grouboxtitular.Padding = new System.Windows.Forms.Padding(4);
            this.grouboxtitular.Size = new System.Drawing.Size(477, 268);
            this.grouboxtitular.TabIndex = 39;
            this.grouboxtitular.TabStop = false;
            this.grouboxtitular.Text = "Cliente";
            // 
            // groupboxTipo
            // 
            this.groupboxTipo.BackColor = System.Drawing.Color.White;
            this.groupboxTipo.Controls.Add(this.txtprestamo);
            this.groupboxTipo.Controls.Add(this.lblprestamo);
            this.groupboxTipo.Controls.Add(this.lblplazo);
            this.groupboxTipo.Controls.Add(this.cmbplazo);
            this.groupboxTipo.Controls.Add(this.btnlimpiar);
            this.groupboxTipo.Controls.Add(this.btnagregar);
            this.groupboxTipo.Controls.Add(this.txtpiedra);
            this.groupboxTipo.Controls.Add(this.lblpiedra);
            this.groupboxTipo.Controls.Add(this.txtpeso);
            this.groupboxTipo.Controls.Add(this.lblpeso);
            this.groupboxTipo.Controls.Add(this.cmbmarca);
            this.groupboxTipo.Controls.Add(this.lblmarca);
            this.groupboxTipo.Controls.Add(this.lbldescripcion);
            this.groupboxTipo.Controls.Add(this.txtdescripcion);
            this.groupboxTipo.Controls.Add(this.cmbpresentacion);
            this.groupboxTipo.Controls.Add(this.lblestado);
            this.groupboxTipo.Controls.Add(this.lblkilataje);
            this.groupboxTipo.Controls.Add(this.cmbkilataje);
            this.groupboxTipo.Controls.Add(this.label1);
            this.groupboxTipo.Controls.Add(this.cbxtipo);
            this.groupboxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxTipo.Location = new System.Drawing.Point(590, 116);
            this.groupboxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.groupboxTipo.Name = "groupboxTipo";
            this.groupboxTipo.Padding = new System.Windows.Forms.Padding(4);
            this.groupboxTipo.Size = new System.Drawing.Size(964, 348);
            this.groupboxTipo.TabIndex = 40;
            this.groupboxTipo.TabStop = false;
            this.groupboxTipo.Text = "Descricion de Prendas";
            // 
            // txtprestamo
            // 
            this.txtprestamo.Location = new System.Drawing.Point(161, 306);
            this.txtprestamo.Margin = new System.Windows.Forms.Padding(4);
            this.txtprestamo.Name = "txtprestamo";
            this.txtprestamo.Size = new System.Drawing.Size(201, 26);
            this.txtprestamo.TabIndex = 19;
            // 
            // lblprestamo
            // 
            this.lblprestamo.AutoSize = true;
            this.lblprestamo.Location = new System.Drawing.Point(11, 311);
            this.lblprestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprestamo.Name = "lblprestamo";
            this.lblprestamo.Size = new System.Drawing.Size(95, 20);
            this.lblprestamo.TabIndex = 18;
            this.lblprestamo.Text = "Prestamo:";
            // 
            // lblplazo
            // 
            this.lblplazo.AutoSize = true;
            this.lblplazo.Location = new System.Drawing.Point(16, 265);
            this.lblplazo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblplazo.Name = "lblplazo";
            this.lblplazo.Size = new System.Drawing.Size(62, 20);
            this.lblplazo.TabIndex = 17;
            this.lblplazo.Text = "Plazo:";
            // 
            // cmbplazo
            // 
            this.cmbplazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbplazo.FormattingEnabled = true;
            this.cmbplazo.Location = new System.Drawing.Point(163, 255);
            this.cmbplazo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbplazo.Name = "cmbplazo";
            this.cmbplazo.Size = new System.Drawing.Size(200, 28);
            this.cmbplazo.TabIndex = 16;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnlimpiar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnlimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlimpiar.Location = new System.Drawing.Point(388, 176);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(138, 46);
            this.btnlimpiar.TabIndex = 15;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnagregar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnagregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar.Location = new System.Drawing.Point(388, 110);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(138, 46);
            this.btnagregar.TabIndex = 14;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtpiedra
            // 
            this.txtpiedra.Location = new System.Drawing.Point(163, 212);
            this.txtpiedra.Margin = new System.Windows.Forms.Padding(4);
            this.txtpiedra.Name = "txtpiedra";
            this.txtpiedra.Size = new System.Drawing.Size(200, 26);
            this.txtpiedra.TabIndex = 13;
            // 
            // lblpiedra
            // 
            this.lblpiedra.AutoSize = true;
            this.lblpiedra.Location = new System.Drawing.Point(16, 212);
            this.lblpiedra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpiedra.Name = "lblpiedra";
            this.lblpiedra.Size = new System.Drawing.Size(117, 20);
            this.lblpiedra.TabIndex = 12;
            this.lblpiedra.Text = "Peso Piedra:";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(163, 171);
            this.txtpeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(200, 26);
            this.txtpeso.TabIndex = 11;
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(19, 175);
            this.lblpeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(57, 20);
            this.lblpeso.TabIndex = 10;
            this.lblpeso.Text = "Peso:";
            // 
            // cmbmarca
            // 
            this.cmbmarca.FormattingEnabled = true;
            this.cmbmarca.Location = new System.Drawing.Point(163, 102);
            this.cmbmarca.Margin = new System.Windows.Forms.Padding(4);
            this.cmbmarca.Name = "cmbmarca";
            this.cmbmarca.Size = new System.Drawing.Size(200, 28);
            this.cmbmarca.TabIndex = 9;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(19, 108);
            this.lblmarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(67, 20);
            this.lblmarca.TabIndex = 8;
            this.lblmarca.Text = "Marca:";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(407, 52);
            this.lbldescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(116, 20);
            this.lbldescripcion.TabIndex = 7;
            this.lbldescripcion.Text = "Descripcion:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(537, 48);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(408, 291);
            this.txtdescripcion.TabIndex = 6;
            // 
            // cmbpresentacion
            // 
            this.cmbpresentacion.FormattingEnabled = true;
            this.cmbpresentacion.Location = new System.Drawing.Point(161, 137);
            this.cmbpresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbpresentacion.Name = "cmbpresentacion";
            this.cmbpresentacion.Size = new System.Drawing.Size(201, 28);
            this.cmbpresentacion.TabIndex = 5;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(19, 137);
            this.lblestado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(73, 20);
            this.lblestado.TabIndex = 4;
            this.lblestado.Text = "Estado:";
            // 
            // lblkilataje
            // 
            this.lblkilataje.AutoSize = true;
            this.lblkilataje.Location = new System.Drawing.Point(16, 79);
            this.lblkilataje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkilataje.Name = "lblkilataje";
            this.lblkilataje.Size = new System.Drawing.Size(78, 20);
            this.lblkilataje.TabIndex = 3;
            this.lblkilataje.Text = "Kilataje:";
            // 
            // cmbkilataje
            // 
            this.cmbkilataje.FormattingEnabled = true;
            this.cmbkilataje.Location = new System.Drawing.Point(163, 69);
            this.cmbkilataje.Margin = new System.Windows.Forms.Padding(4);
            this.cmbkilataje.Name = "cmbkilataje";
            this.cmbkilataje.Size = new System.Drawing.Size(200, 28);
            this.cmbkilataje.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo:";
            // 
            // cbxtipo
            // 
            this.cbxtipo.FormattingEnabled = true;
            this.cbxtipo.Location = new System.Drawing.Point(161, 34);
            this.cbxtipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxtipo.Name = "cbxtipo";
            this.cbxtipo.Size = new System.Drawing.Size(201, 28);
            this.cbxtipo.TabIndex = 0;
            this.cbxtipo.SelectionChangeCommitted += new System.EventHandler(this.cbxtipo_SelectionChangeCommitted);
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.AllowUserToAddRows = false;
            this.dgvdetalle.AllowUserToDeleteRows = false;
            this.dgvdetalle.AllowUserToResizeColumns = false;
            this.dgvdetalle.AllowUserToResizeRows = false;
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Location = new System.Drawing.Point(15, 471);
            this.dgvdetalle.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.ReadOnly = true;
            this.dgvdetalle.RowHeadersVisible = false;
            this.dgvdetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvdetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalle.Size = new System.Drawing.Size(1533, 185);
            this.dgvdetalle.TabIndex = 41;
            this.dgvdetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalle_CellContentClick);
            this.dgvdetalle.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdetalle_CellMouseDoubleClick);
            // 
            // btnguadar
            // 
            this.btnguadar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnguadar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnguadar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnguadar.Location = new System.Drawing.Point(493, 671);
            this.btnguadar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguadar.Name = "btnguadar";
            this.btnguadar.Size = new System.Drawing.Size(138, 46);
            this.btnguadar.TabIndex = 42;
            this.btnguadar.Text = "Guardar";
            this.btnguadar.UseVisualStyleBackColor = false;
            this.btnguadar.Visible = false;
            this.btnguadar.Click += new System.EventHandler(this.btnguadar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(804, 671);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 46);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnbuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarcliente.ForeColor = System.Drawing.Color.White;
            this.btnbuscarcliente.Location = new System.Drawing.Point(507, 184);
            this.btnbuscarcliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(88, 31);
            this.btnbuscarcliente.TabIndex = 44;
            this.btnbuscarcliente.Text = "Buscar..";
            this.btnbuscarcliente.UseVisualStyleBackColor = false;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(1174, 682);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(51, 20);
            this.lbltotal.TabIndex = 46;
            this.lbltotal.Text = "Total";
            // 
            // txttotal_prestamo
            // 
            this.txttotal_prestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttotal_prestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal_prestamo.ForeColor = System.Drawing.Color.Red;
            this.txttotal_prestamo.Location = new System.Drawing.Point(1242, 676);
            this.txttotal_prestamo.Margin = new System.Windows.Forms.Padding(4);
            this.txttotal_prestamo.Name = "txttotal_prestamo";
            this.txttotal_prestamo.Size = new System.Drawing.Size(133, 30);
            this.txttotal_prestamo.TabIndex = 45;
            // 
            // lblcontador
            // 
            this.lblcontador.AutoSize = true;
            this.lblcontador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontador.ForeColor = System.Drawing.Color.Red;
            this.lblcontador.Location = new System.Drawing.Point(182, 64);
            this.lblcontador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontador.Name = "lblcontador";
            this.lblcontador.Size = new System.Drawing.Size(24, 25);
            this.lblcontador.TabIndex = 47;
            this.lblcontador.Text = "_";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCellValue,
            this.copyRowValue,
            this.deleteRow});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 76);
            // 
            // copyCellValue
            // 
            this.copyCellValue.Name = "copyCellValue";
            this.copyCellValue.Size = new System.Drawing.Size(162, 24);
            this.copyCellValue.Text = "Copiar celda";
            // 
            // copyRowValue
            // 
            this.copyRowValue.Name = "copyRowValue";
            this.copyRowValue.Size = new System.Drawing.Size(162, 24);
            this.copyRowValue.Text = "Copiar Fila";
            // 
            // deleteRow
            // 
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(162, 24);
            this.deleteRow.Text = "Eliminar fila";
            // 
            // txttotal_avaluo
            // 
            this.txttotal_avaluo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttotal_avaluo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal_avaluo.ForeColor = System.Drawing.Color.Red;
            this.txttotal_avaluo.Location = new System.Drawing.Point(1384, 674);
            this.txttotal_avaluo.Margin = new System.Windows.Forms.Padding(4);
            this.txttotal_avaluo.Name = "txttotal_avaluo";
            this.txttotal_avaluo.Size = new System.Drawing.Size(133, 30);
            this.txttotal_avaluo.TabIndex = 49;
            // 
            // lblaeliminar
            // 
            this.lblaeliminar.AutoSize = true;
            this.lblaeliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaeliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblaeliminar.Location = new System.Drawing.Point(158, 442);
            this.lblaeliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblaeliminar.Name = "lblaeliminar";
            this.lblaeliminar.Size = new System.Drawing.Size(19, 20);
            this.lblaeliminar.TabIndex = 50;
            this.lblaeliminar.Text = "_";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btneliminar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btneliminar.Location = new System.Drawing.Point(411, 426);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(138, 43);
            this.btneliminar.TabIndex = 51;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 442);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Quitar linea:";
            // 
            // lblnoboleta
            // 
            this.lblnoboleta.AutoSize = true;
            this.lblnoboleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoboleta.Location = new System.Drawing.Point(43, 64);
            this.lblnoboleta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnoboleta.Name = "lblnoboleta";
            this.lblnoboleta.Size = new System.Drawing.Size(119, 25);
            this.lblnoboleta.TabIndex = 53;
            this.lblnoboleta.Text = "No. Boleta:";
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblcat.Location = new System.Drawing.Point(212, 443);
            this.lblcat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(16, 17);
            this.lblcat.TabIndex = 54;
            this.lblcat.Text = "_";
            this.lblcat.Visible = false;
            // 
            // lblkil
            // 
            this.lblkil.AutoSize = true;
            this.lblkil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblkil.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblkil.Location = new System.Drawing.Point(290, 442);
            this.lblkil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkil.Name = "lblkil";
            this.lblkil.Size = new System.Drawing.Size(16, 17);
            this.lblkil.TabIndex = 55;
            this.lblkil.Text = "_";
            this.lblkil.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnImprimir.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimir.Location = new System.Drawing.Point(648, 671);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(138, 46);
            this.btnImprimir.TabIndex = 56;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbluser.Location = new System.Drawing.Point(1123, 70);
            this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(12, 17);
            this.lbluser.TabIndex = 57;
            this.lbluser.Text = ":";
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
            this.label13.Size = new System.Drawing.Size(1562, 49);
            this.label13.TabIndex = 58;
            this.label13.Text = "Registro de Boleta de Empeño";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsalir.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalir.Location = new System.Drawing.Point(959, 670);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(138, 46);
            this.btnsalir.TabIndex = 59;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Empeño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1559, 754);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblkil);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.lblnoboleta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.lblaeliminar);
            this.Controls.Add(this.txttotal_avaluo);
            this.Controls.Add(this.lblcontador);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txttotal_prestamo);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnguadar);
            this.Controls.Add(this.dgvdetalle);
            this.Controls.Add(this.groupboxTipo);
            this.Controls.Add(this.grouboxtitular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Empeño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empeño";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Empeño_FormClosed);
            this.Load += new System.EventHandler(this.Empeño_Load);
            this.grouboxtitular.ResumeLayout(false);
            this.grouboxtitular.PerformLayout();
            this.groupboxTipo.ResumeLayout(false);
            this.groupboxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblidentificacion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtcotitular;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblclienteid;
        private System.Windows.Forms.TextBox txtcliennte_id;
        private System.Windows.Forms.GroupBox grouboxtitular;
        private System.Windows.Forms.GroupBox groupboxTipo;
        private System.Windows.Forms.ComboBox cmbpresentacion;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblkilataje;
        private System.Windows.Forms.ComboBox cmbkilataje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxtipo;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.ComboBox cmbmarca;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtpiedra;
        private System.Windows.Forms.Label lblpiedra;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnguadar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblplazo;
        private System.Windows.Forms.ComboBox cmbplazo;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.TextBox txtprestamo;
        private System.Windows.Forms.Label lblprestamo;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal_prestamo;
        private System.Windows.Forms.Label lblcontador;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyCellValue;
        private System.Windows.Forms.ToolStripMenuItem copyRowValue;
        private System.Windows.Forms.ToolStripMenuItem deleteRow;
        internal System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.TextBox txttotal_avaluo;
        private System.Windows.Forms.Label lblaeliminar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnoboleta;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.Label lblkil;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lbluser;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnsalir;

    }
}