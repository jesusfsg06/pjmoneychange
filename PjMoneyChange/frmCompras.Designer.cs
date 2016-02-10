namespace PjMoneyChange
{
    partial class frmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.txt_importe = new System.Windows.Forms.TextBox();
            this.lbl_taza = new System.Windows.Forms.Label();
            this.cbx_moneda = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_moneda = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_importe = new System.Windows.Forms.Label();
            this.txt_taza = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.panel_foter = new System.Windows.Forms.Panel();
            this.resultado = new System.Windows.Forms.Label();
            this.importe_oculto = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_importeof = new System.Windows.Forms.Label();
            this.lblmonitor = new System.Windows.Forms.Label();
            this.lbl_cantidadof = new System.Windows.Forms.Label();
            this.lbl_tazaof = new System.Windows.Forms.Label();
            this.marquesina = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_compra = new System.Windows.Forms.Label();
            this.txt_recibido = new System.Windows.Forms.TextBox();
            this.lbl_recibido = new System.Windows.Forms.Label();
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.txt_clientes = new System.Windows.Forms.TextBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_factura = new System.Windows.Forms.Button();
            this.cbx_clientes = new System.Windows.Forms.ComboBox();
            this.fondo_clientes = new System.Windows.Forms.PictureBox();
            this.lbl_recibidoof = new System.Windows.Forms.Label();
            this.lbl_devuelta = new System.Windows.Forms.Label();
            this.btn_calculo = new System.Windows.Forms.Button();
            this.fondo_recibido = new System.Windows.Forms.PictureBox();
            this.panel_contenido = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_foter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo_recibido)).BeginInit();
            this.panel_contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLista.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLista.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgLista.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgLista.Location = new System.Drawing.Point(0, 36);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgLista.RowHeadersWidth = 45;
            this.dgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLista.Size = new System.Drawing.Size(786, 147);
            this.dgLista.TabIndex = 1;
            this.dgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellClick);
            // 
            // txt_importe
            // 
            this.txt_importe.BackColor = System.Drawing.Color.White;
            this.txt_importe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_importe.Font = new System.Drawing.Font("Times New Roman", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importe.Location = new System.Drawing.Point(123, 167);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.ReadOnly = true;
            this.txt_importe.Size = new System.Drawing.Size(652, 52);
            this.txt_importe.TabIndex = 40;
            this.txt_importe.Text = "350.50";
            this.txt_importe.Enter += new System.EventHandler(this.txt_importe_Enter);
            this.txt_importe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_importe_KeyDown);
            this.txt_importe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_importe_KeyPress);
            this.txt_importe.Leave += new System.EventHandler(this.txt_importe_Leave);
            // 
            // lbl_taza
            // 
            this.lbl_taza.AutoSize = true;
            this.lbl_taza.BackColor = System.Drawing.Color.Transparent;
            this.lbl_taza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taza.ForeColor = System.Drawing.Color.White;
            this.lbl_taza.Location = new System.Drawing.Point(403, 102);
            this.lbl_taza.Name = "lbl_taza";
            this.lbl_taza.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_taza.Size = new System.Drawing.Size(63, 30);
            this.lbl_taza.TabIndex = 33;
            this.lbl_taza.Text = "Taza:";
            // 
            // cbx_moneda
            // 
            this.cbx_moneda.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_moneda.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_moneda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbx_moneda.Location = new System.Drawing.Point(123, 21);
            this.cbx_moneda.Name = "cbx_moneda";
            this.cbx_moneda.Size = new System.Drawing.Size(299, 34);
            this.cbx_moneda.Sorted = true;
            this.cbx_moneda.TabIndex = 35;
            this.cbx_moneda.SelectionChangeCommitted += new System.EventHandler(this.cbx_moneda_SelectionChangeCommitted);
            this.cbx_moneda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_moneda_KeyDown);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.AutoCompleteCustomSource.AddRange(new string[] {
            "sofocando"});
            this.txt_cantidad.BackColor = System.Drawing.Color.White;
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cantidad.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold);
            this.txt_cantidad.Location = new System.Drawing.Point(96, 277);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(265, 84);
            this.txt_cantidad.TabIndex = 34;
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_cantidad.Enter += new System.EventHandler(this.txt_cantidad_Enter);
            this.txt_cantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cantidad_KeyDown);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            this.txt_cantidad.Leave += new System.EventHandler(this.txt_cantidad_Leave);
            // 
            // lbl_moneda
            // 
            this.lbl_moneda.AutoSize = true;
            this.lbl_moneda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_moneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moneda.ForeColor = System.Drawing.Color.White;
            this.lbl_moneda.Location = new System.Drawing.Point(24, 21);
            this.lbl_moneda.Name = "lbl_moneda";
            this.lbl_moneda.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_moneda.Size = new System.Drawing.Size(88, 30);
            this.lbl_moneda.TabIndex = 31;
            this.lbl_moneda.Text = "Moneda:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.White;
            this.lbl_cantidad.Location = new System.Drawing.Point(24, 83);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_cantidad.Size = new System.Drawing.Size(96, 30);
            this.lbl_cantidad.TabIndex = 32;
            this.lbl_cantidad.Text = "Cantidad:";
            // 
            // lbl_importe
            // 
            this.lbl_importe.AutoSize = true;
            this.lbl_importe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importe.ForeColor = System.Drawing.Color.White;
            this.lbl_importe.Location = new System.Drawing.Point(24, 181);
            this.lbl_importe.Name = "lbl_importe";
            this.lbl_importe.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_importe.Size = new System.Drawing.Size(86, 30);
            this.lbl_importe.TabIndex = 36;
            this.lbl_importe.Text = "Importe:";
            // 
            // txt_taza
            // 
            this.txt_taza.BackColor = System.Drawing.Color.White;
            this.txt_taza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_taza.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold);
            this.txt_taza.Location = new System.Drawing.Point(500, 227);
            this.txt_taza.Name = "txt_taza";
            this.txt_taza.Size = new System.Drawing.Size(265, 84);
            this.txt_taza.TabIndex = 43;
            this.txt_taza.TabStop = false;
            this.txt_taza.Text = "40.20";
            this.txt_taza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_taza.Enter += new System.EventHandler(this.txt_taza_Enter);
            this.txt_taza.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_taza_KeyDown);
            this.txt_taza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_taza_KeyPress);
            this.txt_taza.Leave += new System.EventHandler(this.txt_taza_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImage = global::PjMoneyChange.Properties.Resources.tops;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_usuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.txt_buscador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 36);
            this.panel1.TabIndex = 44;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(708, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_usuario.Size = new System.Drawing.Size(78, 30);
            this.lbl_usuario.TabIndex = 64;
            this.lbl_usuario.Text = "usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Mostrar #:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.White;
            this.btn_buscar.BackgroundImage = global::PjMoneyChange.Properties.Resources.buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_buscar.Image = global::PjMoneyChange.Properties.Resources.Search;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(241, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(72, 27);
            this.btn_buscar.TabIndex = 50;
            this.btn_buscar.Text = "      Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscador
            // 
            this.txt_buscador.BackColor = System.Drawing.Color.White;
            this.txt_buscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_buscador.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscador.ForeColor = System.Drawing.Color.Red;
            this.txt_buscador.Location = new System.Drawing.Point(96, 4);
            this.txt_buscador.MaximumSize = new System.Drawing.Size(139, 27);
            this.txt_buscador.MinimumSize = new System.Drawing.Size(139, 27);
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(139, 26);
            this.txt_buscador.TabIndex = 43;
            // 
            // panel_foter
            // 
            this.panel_foter.BackColor = System.Drawing.Color.Transparent;
            this.panel_foter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_foter.Controls.Add(this.resultado);
            this.panel_foter.Controls.Add(this.importe_oculto);
            this.panel_foter.Controls.Add(this.lbl_tipo);
            this.panel_foter.Controls.Add(this.lbl_fecha);
            this.panel_foter.Controls.Add(this.btn_nuevo);
            this.panel_foter.Controls.Add(this.btn_cancelar);
            this.panel_foter.Controls.Add(this.btn_cerrar);
            this.panel_foter.Controls.Add(this.lbl_id);
            this.panel_foter.Controls.Add(this.lbl_importeof);
            this.panel_foter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_foter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_foter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_foter.Location = new System.Drawing.Point(0, 444);
            this.panel_foter.Name = "panel_foter";
            this.panel_foter.Size = new System.Drawing.Size(786, 58);
            this.panel_foter.TabIndex = 45;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.BackColor = System.Drawing.Color.Transparent;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.resultado.Location = new System.Drawing.Point(496, 18);
            this.resultado.Name = "resultado";
            this.resultado.Padding = new System.Windows.Forms.Padding(5);
            this.resultado.Size = new System.Drawing.Size(28, 23);
            this.resultado.TabIndex = 68;
            this.resultado.Text = "ID";
            // 
            // importe_oculto
            // 
            this.importe_oculto.AutoSize = true;
            this.importe_oculto.BackColor = System.Drawing.Color.Transparent;
            this.importe_oculto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importe_oculto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.importe_oculto.Location = new System.Drawing.Point(499, 18);
            this.importe_oculto.Name = "importe_oculto";
            this.importe_oculto.Padding = new System.Windows.Forms.Padding(5);
            this.importe_oculto.Size = new System.Drawing.Size(10, 23);
            this.importe_oculto.TabIndex = 67;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_tipo.Location = new System.Drawing.Point(655, 21);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_tipo.Size = new System.Drawing.Size(23, 23);
            this.lbl_tipo.TabIndex = 66;
            this.lbl_tipo.Text = "1";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_fecha.Location = new System.Drawing.Point(855, 21);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_fecha.Size = new System.Drawing.Size(44, 23);
            this.lbl_fecha.TabIndex = 64;
            this.lbl_fecha.Text = "fecha";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.Transparent;
            this.btn_nuevo.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazul;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Image = global::PjMoneyChange.Properties.Resources.Doc_Add;
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(12, 8);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(72, 38);
            this.btn_nuevo.TabIndex = 47;
            this.btn_nuevo.Text = "     Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            this.btn_nuevo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_nuevo_MouseDown);
            this.btn_nuevo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_nuevo_MouseUp);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazul;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::PjMoneyChange.Properties.Resources.Doc_Cancel;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(96, 8);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(78, 38);
            this.btn_cancelar.TabIndex = 50;
            this.btn_cancelar.Text = "      Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_cancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancelar_MouseDown);
            this.btn_cancelar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancelar_MouseUp);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazul;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Image = global::PjMoneyChange.Properties.Resources.Trend_Down;
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(936, 8);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cerrar.Size = new System.Drawing.Size(73, 38);
            this.btn_cerrar.TabIndex = 51;
            this.btn_cerrar.Text = "    Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            this.btn_cerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cerrar_MouseDown);
            this.btn_cerrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cerrar_MouseUp);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_id.Location = new System.Drawing.Point(769, 21);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_id.Size = new System.Drawing.Size(28, 23);
            this.lbl_id.TabIndex = 65;
            this.lbl_id.Text = "ID";
            // 
            // lbl_importeof
            // 
            this.lbl_importeof.AutoSize = true;
            this.lbl_importeof.BackColor = System.Drawing.Color.Transparent;
            this.lbl_importeof.Font = new System.Drawing.Font("Times New Roman", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importeof.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_importeof.Location = new System.Drawing.Point(109, -58);
            this.lbl_importeof.MaximumSize = new System.Drawing.Size(877, 151);
            this.lbl_importeof.MinimumSize = new System.Drawing.Size(877, 151);
            this.lbl_importeof.Name = "lbl_importeof";
            this.lbl_importeof.Size = new System.Drawing.Size(877, 151);
            this.lbl_importeof.TabIndex = 55;
            this.lbl_importeof.Text = "RD$0.00";
            // 
            // lblmonitor
            // 
            this.lblmonitor.AutoSize = true;
            this.lblmonitor.BackColor = System.Drawing.Color.DarkGreen;
            this.lblmonitor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblmonitor.Location = new System.Drawing.Point(676, 18);
            this.lblmonitor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblmonitor.MaximumSize = new System.Drawing.Size(265, 33);
            this.lblmonitor.Name = "lblmonitor";
            this.lblmonitor.Size = new System.Drawing.Size(102, 26);
            this.lblmonitor.TabIndex = 46;
            this.lblmonitor.Text = "Registrado";
            this.lblmonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblmonitor.Click += new System.EventHandler(this.lblmonitor_Click);
            // 
            // lbl_cantidadof
            // 
            this.lbl_cantidadof.AutoSize = true;
            this.lbl_cantidadof.BackColor = System.Drawing.Color.White;
            this.lbl_cantidadof.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cantidadof.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadof.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_cantidadof.Location = new System.Drawing.Point(123, 83);
            this.lbl_cantidadof.MaximumSize = new System.Drawing.Size(209, 52);
            this.lbl_cantidadof.MinimumSize = new System.Drawing.Size(209, 52);
            this.lbl_cantidadof.Name = "lbl_cantidadof";
            this.lbl_cantidadof.Padding = new System.Windows.Forms.Padding(3, 2, 0, 3);
            this.lbl_cantidadof.Size = new System.Drawing.Size(209, 52);
            this.lbl_cantidadof.TabIndex = 53;
            this.lbl_cantidadof.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_tazaof
            // 
            this.lbl_tazaof.AutoSize = true;
            this.lbl_tazaof.BackColor = System.Drawing.Color.White;
            this.lbl_tazaof.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_tazaof.Font = new System.Drawing.Font("Times New Roman", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tazaof.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_tazaof.Location = new System.Drawing.Point(469, 85);
            this.lbl_tazaof.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_tazaof.MaximumSize = new System.Drawing.Size(265, 52);
            this.lbl_tazaof.MinimumSize = new System.Drawing.Size(265, 52);
            this.lbl_tazaof.Name = "lbl_tazaof";
            this.lbl_tazaof.Padding = new System.Windows.Forms.Padding(3, 2, 0, 3);
            this.lbl_tazaof.Size = new System.Drawing.Size(265, 52);
            this.lbl_tazaof.TabIndex = 54;
            this.lbl_tazaof.Text = "40.50";
            this.lbl_tazaof.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_tazaof.Click += new System.EventHandler(this.lbl_tazaof_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_compra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 36);
            this.panel2.TabIndex = 45;
            // 
            // lbl_compra
            // 
            this.lbl_compra.AutoSize = true;
            this.lbl_compra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_compra.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(10)), true);
            this.lbl_compra.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbl_compra.Location = new System.Drawing.Point(0, 6);
            this.lbl_compra.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_compra.Name = "lbl_compra";
            this.lbl_compra.Size = new System.Drawing.Size(281, 28);
            this.lbl_compra.TabIndex = 1;
            this.lbl_compra.Text = "COMPRA DE DIVISA!";
            this.lbl_compra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_recibido
            // 
            this.txt_recibido.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recibido.ForeColor = System.Drawing.Color.Green;
            this.txt_recibido.Location = new System.Drawing.Point(122, 360);
            this.txt_recibido.MaximumSize = new System.Drawing.Size(140, 30);
            this.txt_recibido.MinimumSize = new System.Drawing.Size(140, 30);
            this.txt_recibido.Name = "txt_recibido";
            this.txt_recibido.Size = new System.Drawing.Size(140, 31);
            this.txt_recibido.TabIndex = 39;
            this.txt_recibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_recibido.Enter += new System.EventHandler(this.txt_recibido_Enter);
            this.txt_recibido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_recibido_KeyDown);
            this.txt_recibido.Leave += new System.EventHandler(this.txt_recibido_Leave);
            // 
            // lbl_recibido
            // 
            this.lbl_recibido.AutoSize = true;
            this.lbl_recibido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_recibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recibido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_recibido.Location = new System.Drawing.Point(24, 360);
            this.lbl_recibido.Name = "lbl_recibido";
            this.lbl_recibido.Padding = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.lbl_recibido.Size = new System.Drawing.Size(88, 38);
            this.lbl_recibido.TabIndex = 37;
            this.lbl_recibido.Text = "Recibido:";
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cambio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_cambio.Location = new System.Drawing.Point(291, 361);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbl_cambio.Size = new System.Drawing.Size(85, 30);
            this.lbl_cambio.TabIndex = 38;
            this.lbl_cambio.Text = "Devuelta:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_clientes);
            this.groupBox2.Controls.Add(this.txt_clientes);
            this.groupBox2.Controls.Add(this.btn_imprimir);
            this.groupBox2.Controls.Add(this.btn_factura);
            this.groupBox2.Controls.Add(this.cbx_clientes);
            this.groupBox2.Controls.Add(this.fondo_clientes);
            this.groupBox2.Location = new System.Drawing.Point(562, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 68);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.Color.Transparent;
            this.btn_clientes.BackgroundImage = global::PjMoneyChange.Properties.Resources.imprimir;
            this.btn_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.Color.White;
            this.btn_clientes.Image = global::PjMoneyChange.Properties.Resources.User;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.Location = new System.Drawing.Point(188, 20);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(87, 30);
            this.btn_clientes.TabIndex = 52;
            this.btn_clientes.Text = "      Cliente Fijo";
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            this.btn_clientes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_clientes_MouseDown);
            this.btn_clientes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_clientes_MouseUp);
            // 
            // txt_clientes
            // 
            this.txt_clientes.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clientes.Location = new System.Drawing.Point(6, 20);
            this.txt_clientes.MaximumSize = new System.Drawing.Size(140, 31);
            this.txt_clientes.MinimumSize = new System.Drawing.Size(140, 31);
            this.txt_clientes.Name = "txt_clientes";
            this.txt_clientes.Size = new System.Drawing.Size(140, 34);
            this.txt_clientes.TabIndex = 50;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.BackgroundImage")));
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_imprimir.Image = global::PjMoneyChange.Properties.Resources.Printer;
            this.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimir.Location = new System.Drawing.Point(281, 20);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(72, 30);
            this.btn_imprimir.TabIndex = 49;
            this.btn_imprimir.Text = "      Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            this.btn_imprimir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_imprimir_KeyDown);
            this.btn_imprimir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_imprimir_MouseDown);
            this.btn_imprimir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_imprimir_MouseUp);
            // 
            // btn_factura
            // 
            this.btn_factura.BackColor = System.Drawing.Color.Transparent;
            this.btn_factura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_factura.BackgroundImage")));
            this.btn_factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_factura.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_factura.FlatAppearance.BorderSize = 0;
            this.btn_factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_factura.ForeColor = System.Drawing.Color.White;
            this.btn_factura.Image = global::PjMoneyChange.Properties.Resources.News_Info;
            this.btn_factura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_factura.Location = new System.Drawing.Point(359, 20);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(72, 30);
            this.btn_factura.TabIndex = 48;
            this.btn_factura.Text = "     Factura";
            this.btn_factura.UseVisualStyleBackColor = false;
            this.btn_factura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_factura_MouseDown);
            this.btn_factura.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_factura_MouseUp);
            // 
            // cbx_clientes
            // 
            this.cbx_clientes.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_clientes.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_clientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbx_clientes.Items.AddRange(new object[] {
            " ANTONY ESPINOSA",
            " CLIENTE EN GENERAL",
            " GENERAL",
            " NUEVO CLIENTE",
            " RICHI FAMA",
            " SOFOCANDO.COM",
            " VERFACE.COM"});
            this.cbx_clientes.Location = new System.Drawing.Point(6, 21);
            this.cbx_clientes.MaximumSize = new System.Drawing.Size(200, 0);
            this.cbx_clientes.MinimumSize = new System.Drawing.Size(270, 0);
            this.cbx_clientes.Name = "cbx_clientes";
            this.cbx_clientes.Size = new System.Drawing.Size(270, 28);
            this.cbx_clientes.Sorted = true;
            this.cbx_clientes.TabIndex = 53;
            // 
            // fondo_clientes
            // 
            this.fondo_clientes.BackColor = System.Drawing.Color.Transparent;
            this.fondo_clientes.BackgroundImage = global::PjMoneyChange.Properties.Resources.clientefondo;
            this.fondo_clientes.Location = new System.Drawing.Point(0, 0);
            this.fondo_clientes.Name = "fondo_clientes";
            this.fondo_clientes.Size = new System.Drawing.Size(437, 68);
            this.fondo_clientes.TabIndex = 62;
            this.fondo_clientes.TabStop = false;
            // 
            // lbl_recibidoof
            // 
            this.lbl_recibidoof.AutoSize = true;
            this.lbl_recibidoof.BackColor = System.Drawing.Color.White;
            this.lbl_recibidoof.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_recibidoof.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recibidoof.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_recibidoof.Location = new System.Drawing.Point(123, 361);
            this.lbl_recibidoof.MaximumSize = new System.Drawing.Size(140, 31);
            this.lbl_recibidoof.MinimumSize = new System.Drawing.Size(140, 31);
            this.lbl_recibidoof.Name = "lbl_recibidoof";
            this.lbl_recibidoof.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_recibidoof.Size = new System.Drawing.Size(140, 31);
            this.lbl_recibidoof.TabIndex = 56;
            this.lbl_recibidoof.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_devuelta
            // 
            this.lbl_devuelta.AutoSize = true;
            this.lbl_devuelta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_devuelta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_devuelta.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_devuelta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_devuelta.Location = new System.Drawing.Point(375, 361);
            this.lbl_devuelta.MaximumSize = new System.Drawing.Size(139, 30);
            this.lbl_devuelta.MinimumSize = new System.Drawing.Size(139, 30);
            this.lbl_devuelta.Name = "lbl_devuelta";
            this.lbl_devuelta.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_devuelta.Size = new System.Drawing.Size(139, 30);
            this.lbl_devuelta.TabIndex = 59;
            this.lbl_devuelta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_calculo
            // 
            this.btn_calculo.BackColor = System.Drawing.Color.Transparent;
            this.btn_calculo.BackgroundImage = global::PjMoneyChange.Properties.Resources.imprimir;
            this.btn_calculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_calculo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_calculo.FlatAppearance.BorderSize = 0;
            this.btn_calculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculo.ForeColor = System.Drawing.Color.White;
            this.btn_calculo.Image = global::PjMoneyChange.Properties.Resources.Add;
            this.btn_calculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_calculo.Location = new System.Drawing.Point(436, 23);
            this.btn_calculo.Name = "btn_calculo";
            this.btn_calculo.Size = new System.Drawing.Size(78, 33);
            this.btn_calculo.TabIndex = 60;
            this.btn_calculo.Text = "      Calcular";
            this.btn_calculo.UseVisualStyleBackColor = false;
            this.btn_calculo.Click += new System.EventHandler(this.btn_calculo_Click);
            this.btn_calculo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_calculo_MouseDown);
            this.btn_calculo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_calculo_MouseUp);
            // 
            // fondo_recibido
            // 
            this.fondo_recibido.BackColor = System.Drawing.Color.Transparent;
            this.fondo_recibido.Location = new System.Drawing.Point(118, 341);
            this.fondo_recibido.Name = "fondo_recibido";
            this.fondo_recibido.Size = new System.Drawing.Size(400, 68);
            this.fondo_recibido.TabIndex = 63;
            this.fondo_recibido.TabStop = false;
            // 
            // panel_contenido
            // 
            this.panel_contenido.BackColor = System.Drawing.Color.Transparent;
            this.panel_contenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_contenido.Controls.Add(this.btn_calculo);
            this.panel_contenido.Controls.Add(this.lbl_cantidad);
            this.panel_contenido.Controls.Add(this.lbl_devuelta);
            this.panel_contenido.Controls.Add(this.lbl_recibidoof);
            this.panel_contenido.Controls.Add(this.txt_cantidad);
            this.panel_contenido.Controls.Add(this.groupBox2);
            this.panel_contenido.Controls.Add(this.txt_taza);
            this.panel_contenido.Controls.Add(this.lblmonitor);
            this.panel_contenido.Controls.Add(this.txt_importe);
            this.panel_contenido.Controls.Add(this.lbl_cambio);
            this.panel_contenido.Controls.Add(this.lbl_recibido);
            this.panel_contenido.Controls.Add(this.lbl_cantidadof);
            this.panel_contenido.Controls.Add(this.txt_recibido);
            this.panel_contenido.Controls.Add(this.lbl_tazaof);
            this.panel_contenido.Controls.Add(this.lbl_taza);
            this.panel_contenido.Controls.Add(this.lbl_importe);
            this.panel_contenido.Controls.Add(this.cbx_moneda);
            this.panel_contenido.Controls.Add(this.lbl_moneda);
            this.panel_contenido.Controls.Add(this.fondo_recibido);
            this.panel_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenido.Location = new System.Drawing.Point(0, 219);
            this.panel_contenido.Name = "panel_contenido";
            this.panel_contenido.Size = new System.Drawing.Size(786, 225);
            this.panel_contenido.TabIndex = 64;
            this.panel_contenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenido_Paint);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::PjMoneyChange.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(786, 502);
            this.Controls.Add(this.panel_contenido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_foter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de Moneda";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_foter.ResumeLayout(false);
            this.panel_foter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo_recibido)).EndInit();
            this.panel_contenido.ResumeLayout(false);
            this.panel_contenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.TextBox txt_importe;
        private System.Windows.Forms.Label lbl_taza;
        private System.Windows.Forms.ComboBox cbx_moneda;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_moneda;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_importe;
        private System.Windows.Forms.TextBox txt_taza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_foter;
        private System.Windows.Forms.Label lblmonitor;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_compra;
        private System.Windows.Forms.Label lbl_cantidadof;
        private System.Windows.Forms.Label lbl_tazaof;
        private System.Windows.Forms.Label lbl_importeof;
        private System.Windows.Forms.Timer marquesina;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_recibido;
        private System.Windows.Forms.Label lbl_recibido;
        private System.Windows.Forms.Label lbl_cambio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.TextBox txt_clientes;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.ComboBox cbx_clientes;
        private System.Windows.Forms.Label lbl_recibidoof;
        private System.Windows.Forms.Label lbl_devuelta;
        private System.Windows.Forms.Button btn_calculo;
        private System.Windows.Forms.PictureBox fondo_clientes;
        private System.Windows.Forms.PictureBox fondo_recibido;
        private System.Windows.Forms.Panel panel_contenido;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label importe_oculto;
        private System.Windows.Forms.Label resultado;

    }
}