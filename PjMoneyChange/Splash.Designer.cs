namespace PjMoneyChange
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_sub = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_conteo = new System.Windows.Forms.Label();
            this.lbl_esperar = new System.Windows.Forms.Label();
            this.lbl_copyr = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_sub
            // 
            resources.ApplyResources(this.lbl_sub, "lbl_sub");
            this.lbl_sub.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_sub.Name = "lbl_sub";
            // 
            // lbltitulo
            // 
            resources.ApplyResources(this.lbltitulo, "lbltitulo");
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbltitulo.Name = "lbltitulo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.panel1.Controls.Add(this.lbl_conteo);
            this.panel1.Controls.Add(this.lbl_esperar);
            this.panel1.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lbl_conteo
            // 
            resources.ApplyResources(this.lbl_conteo, "lbl_conteo");
            this.lbl_conteo.BackColor = System.Drawing.Color.Maroon;
            this.lbl_conteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_conteo.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_conteo.Name = "lbl_conteo";
            // 
            // lbl_esperar
            // 
            resources.ApplyResources(this.lbl_esperar, "lbl_esperar");
            this.lbl_esperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.lbl_esperar.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_esperar.Name = "lbl_esperar";
            // 
            // lbl_copyr
            // 
            resources.ApplyResources(this.lbl_copyr, "lbl_copyr");
            this.lbl_copyr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_copyr.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_copyr.Name = "lbl_copyr";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Name = "label6";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Step = 100;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Name = "panel2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::PjMoneyChange.Properties.Resources.fon2x;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // Splash
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PjMoneyChange.Properties.Resources.fon2;
            this.CausesValidation = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lbl_copyr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_sub);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Splash_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Splash_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_sub;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_esperar;
        private System.Windows.Forms.Label lbl_conteo;
        private System.Windows.Forms.Label lbl_copyr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}