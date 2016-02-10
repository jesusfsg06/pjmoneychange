namespace PjMoneyChange
{
    partial class FrmDivisas
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
            this.lbl_compra = new System.Windows.Forms.Label();
            this.lbl_divisa = new System.Windows.Forms.Label();
            this.panel_foter = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_compra = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_venta = new System.Windows.Forms.Label();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.txt_venta = new System.Windows.Forms.TextBox();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.panel_foter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_compra
            // 
            this.lbl_compra.AutoSize = true;
            this.lbl_compra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_compra.Location = new System.Drawing.Point(15, 41);
            this.lbl_compra.Name = "lbl_compra";
            this.lbl_compra.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbl_compra.Size = new System.Drawing.Size(90, 23);
            this.lbl_compra.TabIndex = 71;
            this.lbl_compra.Text = "Taza Compra:";
            // 
            // lbl_divisa
            // 
            this.lbl_divisa.AutoSize = true;
            this.lbl_divisa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_divisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_divisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_divisa.Location = new System.Drawing.Point(52, 12);
            this.lbl_divisa.Name = "lbl_divisa";
            this.lbl_divisa.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbl_divisa.Size = new System.Drawing.Size(51, 23);
            this.lbl_divisa.TabIndex = 76;
            this.lbl_divisa.Text = "Divisa:";
            // 
            // panel_foter
            // 
            this.panel_foter.BackColor = System.Drawing.Color.Transparent;
            this.panel_foter.BackgroundImage = global::PjMoneyChange.Properties.Resources.panelfoter;
            this.panel_foter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_foter.Controls.Add(this.btn_cancelar);
            this.panel_foter.Controls.Add(this.btn_agregar);
            this.panel_foter.Controls.Add(this.lbl_id);
            this.panel_foter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_foter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_foter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_foter.Location = new System.Drawing.Point(0, 105);
            this.panel_foter.Name = "panel_foter";
            this.panel_foter.Size = new System.Drawing.Size(311, 39);
            this.panel_foter.TabIndex = 95;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Navy;
            this.btn_cancelar.Image = global::PjMoneyChange.Properties.Resources.bttcancelar;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(217, 8);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(78, 25);
            this.btn_cancelar.TabIndex = 107;
            this.btn_cancelar.Text = "     Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_cancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancelar_MouseDown);
            this.btn_cancelar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancelar_MouseUp);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.Navy;
            this.btn_agregar.Image = global::PjMoneyChange.Properties.Resources.Save;
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_agregar.Location = new System.Drawing.Point(132, 8);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(79, 25);
            this.btn_agregar.TabIndex = 106;
            this.btn_agregar.Text = "    Guardar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            this.btn_agregar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_agregar_MouseDown);
            this.btn_agregar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_agregar_MouseUp);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_id.Location = new System.Drawing.Point(17, 16);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbl_id.Size = new System.Drawing.Size(5, 27);
            this.lbl_id.TabIndex = 107;
            this.lbl_id.Visible = false;
            // 
            // txt_compra
            // 
            this.txt_compra.BackColor = System.Drawing.Color.White;
            this.txt_compra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_compra.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_compra.ForeColor = System.Drawing.Color.SlateGray;
            this.txt_compra.Location = new System.Drawing.Point(109, 41);
            this.txt_compra.MaximumSize = new System.Drawing.Size(4, 23);
            this.txt_compra.MaxLength = 6;
            this.txt_compra.MinimumSize = new System.Drawing.Size(80, 23);
            this.txt_compra.Name = "txt_compra";
            this.txt_compra.Size = new System.Drawing.Size(80, 23);
            this.txt_compra.TabIndex = 100;
            this.txt_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_compra_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PjMoneyChange.Properties.Resources.textboxfondo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(108, 40);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(83, 25);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(81, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 25);
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PjMoneyChange.Properties.Resources.textboxfondo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(108, 70);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(83, 25);
            this.pictureBox3.MinimumSize = new System.Drawing.Size(81, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 25);
            this.pictureBox3.TabIndex = 104;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_venta
            // 
            this.lbl_venta.AutoSize = true;
            this.lbl_venta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_venta.Location = new System.Drawing.Point(21, 71);
            this.lbl_venta.Name = "lbl_venta";
            this.lbl_venta.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbl_venta.Size = new System.Drawing.Size(81, 23);
            this.lbl_venta.TabIndex = 102;
            this.lbl_venta.Text = "Taza Venta:";
            // 
            // pic_icon
            // 
            this.pic_icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_icon.BackgroundImage = global::PjMoneyChange.Properties.Resources.agregardivisa;
            this.pic_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_icon.Location = new System.Drawing.Point(217, 41);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(72, 54);
            this.pic_icon.TabIndex = 105;
            this.pic_icon.TabStop = false;
            // 
            // txt_venta
            // 
            this.txt_venta.BackColor = System.Drawing.Color.White;
            this.txt_venta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_venta.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_venta.ForeColor = System.Drawing.Color.SlateGray;
            this.txt_venta.Location = new System.Drawing.Point(109, 71);
            this.txt_venta.MaximumSize = new System.Drawing.Size(4, 23);
            this.txt_venta.MaxLength = 6;
            this.txt_venta.MinimumSize = new System.Drawing.Size(80, 23);
            this.txt_venta.Name = "txt_venta";
            this.txt_venta.Size = new System.Drawing.Size(80, 23);
            this.txt_venta.TabIndex = 103;
            this.txt_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_venta_KeyPress);
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbx_tipo.Location = new System.Drawing.Point(109, 9);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(186, 26);
            this.cbx_tipo.Sorted = true;
            this.cbx_tipo.TabIndex = 106;
            this.cbx_tipo.SelectionChangeCommitted += new System.EventHandler(this.cbx_tipo_SelectionChangeCommitted);
            // 
            // FrmDivisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::PjMoneyChange.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(311, 144);
            this.Controls.Add(this.cbx_tipo);
            this.Controls.Add(this.pic_icon);
            this.Controls.Add(this.txt_venta);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_venta);
            this.Controls.Add(this.txt_compra);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel_foter);
            this.Controls.Add(this.lbl_divisa);
            this.Controls.Add(this.lbl_compra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDivisas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizacion Compra y Ventas";
            this.Load += new System.EventHandler(this.FrmDivisas_Load);
            this.panel_foter.ResumeLayout(false);
            this.panel_foter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_compra;
        private System.Windows.Forms.Label lbl_divisa;
        private System.Windows.Forms.Panel panel_foter;
        private System.Windows.Forms.TextBox txt_compra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_venta;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_venta;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Label lbl_id;
    }
}