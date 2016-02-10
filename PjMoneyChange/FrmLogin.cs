using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PjMoneyChange
{
    public partial class FrmLogin : Form
    {

        //connecion
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True;");

     
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.txt_usuario.Focus();
            this.txt_usuario.Select();

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
                cn.Open();



                SqlCommand cmd = new SqlCommand("SELECT usuario,clave FROM Miembros WHERE usuario='" + txt_usuario.Text + "' and clave='" + txt_clave.Text + "' And estado='activo'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

             /*   if (txt_usuario.Text == "admin" && txt_clave.Text=="523")
                {

                    Conectar.domil = txt_usuario.Text;

                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    menu.Show();
                }
            */
            
                if (dt.Rows.Count > 0)
                {
                    //string tipo="Admin" ;
                    cmd = new SqlCommand("SELECT nombre from Miembros where usuario=@usuario", cn);
                    cmd.Parameters.AddWithValue("@usuario", txt_usuario.Text);

                    string leerdatos = cmd.ExecuteScalar().ToString();

                    SqlCommand cmd2 = new SqlCommand("SELECT tipo from Miembros where usuario='" + txt_usuario.Text + "'", cn); // cojo el tipo de usuario logeado
                  //  cmd2.Parameters.AddWithValue("@usuario", tipo);
                    string tipousuario = cmd2.ExecuteScalar().ToString(); // con esto me permite reconocer el tipo de usuario logeado

                    MessageBox.Show("Bienvenido "+ leerdatos, "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Conectar.tipo = tipousuario; // guardo el tipo de usuario pa agrgar condicion del menu
                    Conectar.empleadonombre = leerdatos;
                    Conectar.empleadouser = txt_usuario.Text;

                  FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    menu.Show();
                    this.Hide();
                    cn.Close();
                }
                else
                {
                    if (txt_usuario.Text == "")
                    {
                        this.txt_usuario.Focus();
                        this.txt_usuario.Select();
                        MessageBox.Show("Usuario no puede estar en blanco", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_usuario.SelectAll();
                    }
                    else
                    {
                        if (txt_clave.Text == "")
                        {
                            this.txt_clave.Focus();
                            this.txt_clave.Select();
                            MessageBox.Show("Clave no puede estar en blanco", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            this.txt_usuario.Focus();
                            this.txt_usuario.Select();
                            MessageBox.Show("Conbinacion de usuario y clave Invalidos", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    cn.Close();
                }
                

        }

        private void btn_aceptar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_aceptar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;

        }

        private void btn_aceptar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_aceptar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        }

        private void cancelar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_cancelar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelar.Focus();
            this.btn_cancelar.Select();
        }

        private void cancelar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_cancelar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "abcdefghijklmnopqrstuvwxyz0123456789-_";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "abcdefghijklmnopqrstuvwxyz0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_clave.SelectAll();
                this.txt_clave.Focus();
                e.Handled = true;
            }
        }

        private void txt_clave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_aceptar.Select();
                this.btn_aceptar.Focus();
                e.Handled = true;
            }
        }



    }
}
