namespace PjMoneyChange
{
    partial class FrmCapital
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
            this.panel_foter = new System.Windows.Forms.Panel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.lbl_empresatitulo = new System.Windows.Forms.Label();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.btn_company = new System.Windows.Forms.Button();
            this.fondoContenido = new System.Windows.Forms.GroupBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_capitalexistente = new System.Windows.Forms.Label();
            this.lbl_capitalinicial = new System.Windows.Forms.Label();
            this.lbl_direc1 = new System.Windows.Forms.Label();
            this.lbl_Razon = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.panel_foter.SuspendLayout();
            this.fondoContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_foter
            // 
            this.panel_foter.BackColor = System.Drawing.Color.Transparent;
            this.panel_foter.BackgroundImage = global::PjMoneyChange.Properties.Resources.panelfoter;
            this.panel_foter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_foter.Controls.Add(this.lbl_id);
            this.panel_foter.Controls.Add(this.btn_cancelar);
            this.panel_foter.Controls.Add(this.btn_salir);
            this.panel_foter.Controls.Add(this.btn_editar);
            this.panel_foter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_foter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_foter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_foter.Location = new System.Drawing.Point(0, 257);
            this.panel_foter.Name = "panel_foter";
            this.panel_foter.Size = new System.Drawing.Size(313, 39);
            this.panel_foter.TabIndex = 95;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_id.Location = new System.Drawing.Point(9, 7);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_id.Size = new System.Drawing.Size(10, 35);
            this.lbl_id.TabIndex = 78;
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
            this.btn_cancelar.Location = new System.Drawing.Point(456, 7);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(78, 25);
            this.btn_cancelar.TabIndex = 66;
            this.btn_cancelar.Text = "     Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.Navy;
            this.btn_salir.Image = global::PjMoneyChange.Properties.Resources.Trend_Down;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_salir.Location = new System.Drawing.Point(225, 7);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(79, 25);
            this.btn_salir.TabIndex = 47;
            this.btn_salir.Text = "  Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            this.btn_salir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_salir_MouseDown);
            this.btn_salir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_salir_MouseUp);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.Navy;
            this.btn_editar.Image = global::PjMoneyChange.Properties.Resources.Web_edit;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_editar.Location = new System.Drawing.Point(367, 7);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(78, 25);
            this.btn_editar.TabIndex = 50;
            this.btn_editar.Text = "   Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // lbl_empresatitulo
            // 
            this.lbl_empresatitulo.AutoSize = true;
            this.lbl_empresatitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_empresatitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empresatitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_empresatitulo.Location = new System.Drawing.Point(102, 16);
            this.lbl_empresatitulo.Name = "lbl_empresatitulo";
            this.lbl_empresatitulo.Size = new System.Drawing.Size(131, 25);
            this.lbl_empresatitulo.TabIndex = 162;
            this.lbl_empresatitulo.Text = "Caja Capital";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(104, 50);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(47, 13);
            this.lbl_subtitulo.TabIndex = 163;
            this.lbl_subtitulo.Text = "empresa";
            this.lbl_subtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_company
            // 
            this.btn_company.BackColor = System.Drawing.Color.Transparent;
            this.btn_company.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbb;
            this.btn_company.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_company.FlatAppearance.BorderSize = 0;
            this.btn_company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_company.ForeColor = System.Drawing.Color.Transparent;
            this.btn_company.Image = global::PjMoneyChange.Properties.Resources.iconcapital;
            this.btn_company.Location = new System.Drawing.Point(10, 7);
            this.btn_company.Name = "btn_company";
            this.btn_company.Size = new System.Drawing.Size(84, 64);
            this.btn_company.TabIndex = 164;
            this.btn_company.UseVisualStyleBackColor = false;
            // 
            // fondoContenido
            // 
            this.fondoContenido.BackColor = System.Drawing.Color.Transparent;
            this.fondoContenido.Controls.Add(this.lbl_estado);
            this.fondoContenido.Controls.Add(this.lbl_capitalexistente);
            this.fondoContenido.Controls.Add(this.lbl_capitalinicial);
            this.fondoContenido.Controls.Add(this.lbl_direc1);
            this.fondoContenido.Controls.Add(this.lbl_Razon);
            this.fondoContenido.Controls.Add(this.lbl_nombre);
            this.fondoContenido.Location = new System.Drawing.Point(12, 76);
            this.fondoContenido.Name = "fondoContenido";
            this.fondoContenido.Size = new System.Drawing.Size(289, 169);
            this.fondoContenido.TabIndex = 165;
            this.fondoContenido.TabStop = false;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_estado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_estado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.White;
            this.lbl_estado.Location = new System.Drawing.Point(120, 116);
            this.lbl_estado.MinimumSize = new System.Drawing.Size(139, 35);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(139, 35);
            this.lbl_estado.TabIndex = 166;
            this.lbl_estado.Text = "0.00";
            this.lbl_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_capitalexistente
            // 
            this.lbl_capitalexistente.AutoSize = true;
            this.lbl_capitalexistente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_capitalexistente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_capitalexistente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_capitalexistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_capitalexistente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_capitalexistente.Location = new System.Drawing.Point(120, 70);
            this.lbl_capitalexistente.MinimumSize = new System.Drawing.Size(139, 35);
            this.lbl_capitalexistente.Name = "lbl_capitalexistente";
            this.lbl_capitalexistente.Size = new System.Drawing.Size(139, 35);
            this.lbl_capitalexistente.TabIndex = 165;
            this.lbl_capitalexistente.Text = "0.00";
            this.lbl_capitalexistente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_capitalinicial
            // 
            this.lbl_capitalinicial.AutoSize = true;
            this.lbl_capitalinicial.BackColor = System.Drawing.Color.Transparent;
            this.lbl_capitalinicial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_capitalinicial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_capitalinicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_capitalinicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_capitalinicial.Location = new System.Drawing.Point(120, 25);
            this.lbl_capitalinicial.MinimumSize = new System.Drawing.Size(139, 35);
            this.lbl_capitalinicial.Name = "lbl_capitalinicial";
            this.lbl_capitalinicial.Size = new System.Drawing.Size(139, 35);
            this.lbl_capitalinicial.TabIndex = 164;
            this.lbl_capitalinicial.Text = "0.00";
            this.lbl_capitalinicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_direc1
            // 
            this.lbl_direc1.AutoSize = true;
            this.lbl_direc1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_direc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direc1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_direc1.Location = new System.Drawing.Point(42, 127);
            this.lbl_direc1.Name = "lbl_direc1";
            this.lbl_direc1.Size = new System.Drawing.Size(69, 15);
            this.lbl_direc1.TabIndex = 86;
            this.lbl_direc1.Text = "Direccion 1";
            // 
            // lbl_Razon
            // 
            this.lbl_Razon.AutoSize = true;
            this.lbl_Razon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Razon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Razon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Razon.Location = new System.Drawing.Point(31, 36);
            this.lbl_Razon.Name = "lbl_Razon";
            this.lbl_Razon.Size = new System.Drawing.Size(83, 15);
            this.lbl_Razon.TabIndex = 80;
            this.lbl_Razon.Text = "Capital Inicial:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_nombre.Location = new System.Drawing.Point(30, 81);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(84, 15);
            this.lbl_nombre.TabIndex = 83;
            this.lbl_nombre.Text = "Capital Actual:";
            // 
            // FrmCapital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PjMoneyChange.Properties.Resources.fon2menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(313, 296);
            this.Controls.Add(this.fondoContenido);
            this.Controls.Add(this.btn_company);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_empresatitulo);
            this.Controls.Add(this.panel_foter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCapital";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capital Caja";
            this.Load += new System.EventHandler(this.FrmCapital_Load);
            this.panel_foter.ResumeLayout(false);
            this.panel_foter.PerformLayout();
            this.fondoContenido.ResumeLayout(false);
            this.fondoContenido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_foter;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_empresatitulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Button btn_company;
        private System.Windows.Forms.GroupBox fondoContenido;
        private System.Windows.Forms.Label lbl_direc1;
        private System.Windows.Forms.Label lbl_Razon;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_capitalexistente;
        private System.Windows.Forms.Label lbl_capitalinicial;
    }
}