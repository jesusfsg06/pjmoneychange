namespace PjMoneyChange
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.panel_foter = new System.Windows.Forms.Panel();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_foter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.White;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_usuario.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.SlateGray;
            this.txt_usuario.Location = new System.Drawing.Point(79, 16);
            this.txt_usuario.MaximumSize = new System.Drawing.Size(100, 18);
            this.txt_usuario.MaxLength = 15;
            this.txt_usuario.MinimumSize = new System.Drawing.Size(105, 20);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(105, 20);
            this.txt_usuario.TabIndex = 58;
            this.txt_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_usuario_KeyDown);
            this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
            // 
            // txt_clave
            // 
            this.txt_clave.BackColor = System.Drawing.Color.White;
            this.txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_clave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_clave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.ForeColor = System.Drawing.Color.SlateGray;
            this.txt_clave.Location = new System.Drawing.Point(79, 55);
            this.txt_clave.MaximumSize = new System.Drawing.Size(100, 18);
            this.txt_clave.MaxLength = 12;
            this.txt_clave.MinimumSize = new System.Drawing.Size(105, 20);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(105, 20);
            this.txt_clave.TabIndex = 59;
            this.txt_clave.UseSystemPasswordChar = true;
            this.txt_clave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_clave_KeyDown);
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clave_KeyPress);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_usuario.Location = new System.Drawing.Point(9, 15);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbl_usuario.Size = new System.Drawing.Size(55, 23);
            this.lbl_usuario.TabIndex = 60;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_clave.Location = new System.Drawing.Point(20, 54);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lbl_clave.Size = new System.Drawing.Size(44, 23);
            this.lbl_clave.TabIndex = 61;
            this.lbl_clave.Text = "Clave";
            // 
            // panel_foter
            // 
            this.panel_foter.BackColor = System.Drawing.Color.Transparent;
            this.panel_foter.BackgroundImage = global::PjMoneyChange.Properties.Resources.panelfoter;
            this.panel_foter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_foter.Controls.Add(this.lbl_fecha);
            this.panel_foter.Controls.Add(this.btn_aceptar);
            this.panel_foter.Controls.Add(this.btn_cancelar);
            this.panel_foter.Controls.Add(this.btn_cerrar);
            this.panel_foter.Controls.Add(this.lbl_id);
            this.panel_foter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_foter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_foter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_foter.Location = new System.Drawing.Point(0, 90);
            this.panel_foter.Name = "panel_foter";
            this.panel_foter.Size = new System.Drawing.Size(219, 39);
            this.panel_foter.TabIndex = 66;
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
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Transparent;
            this.btn_aceptar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.Navy;
            this.btn_aceptar.Image = global::PjMoneyChange.Properties.Resources.Ok;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_aceptar.Location = new System.Drawing.Point(12, 8);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(72, 25);
            this.btn_aceptar.TabIndex = 47;
            this.btn_aceptar.Text = "   Nuevo";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            this.btn_aceptar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_aceptar_MouseDown);
            this.btn_aceptar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_aceptar_MouseUp);
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
            this.btn_cancelar.Location = new System.Drawing.Point(129, 8);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(78, 25);
            this.btn_cancelar.TabIndex = 50;
            this.btn_cancelar.Text = "    Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_cancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelar_MouseDown);
            this.btn_cancelar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cancelar_MouseUp);
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(76, 14);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(110, 21);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(110, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 23);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(76, 53);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(110, 21);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(110, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 23);
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PjMoneyChange.Properties.Resources.fon2menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(219, 129);
            this.Controls.Add(this.panel_foter);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificacion";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel_foter.ResumeLayout(false);
            this.panel_foter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.Panel panel_foter;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}