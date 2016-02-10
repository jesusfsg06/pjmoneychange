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
    public partial class FrmRegistro : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        public FrmRegistro()
        {
            InitializeComponent();
        }
        private void limpiar()
        {
            txt_usuario.Text = "";
            txt_clave.Text = "";
            txt_clave2.Text = "";
            txt_nombre.Text = "";
            txt_fechad.Text = "d";
            txt_fecham.Text = "m";
            txt_fechaa.Text = "a";
            txt_telefono.Text = "";
            txt_direccion.Text = "";
            txt_usuario.Select();
            txt_usuario.Focus();
            cbx_genero.SelectedIndex = 2;
        }
        void siguiente()
        {
            //desativo los del primero
            panelregistro.Visible = false;
            lbl_paso1.Visible = false;
            lbl_pasomensaje1.Visible = false;
            lbl_crearcuenta.Visible = false;
            this.btn_company.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbselect;
            this.btn_company.Image = global::PjMoneyChange.Properties.Resources.empresa;

            this.btn_aceptar.Visible = false;
            // y activo los del segundo
            this.btn_anterior.Visible = true;
            this.btn_finalizar.Visible = true;

            this.panelempresa.Visible = true;
        }
        void atras()
        {
            //activo los del primero
            panelregistro.Visible = true;
            lbl_paso1.Visible = true;
            lbl_pasomensaje1.Visible = true;
            lbl_crearcuenta.Visible = true;
            this.btn_agregarMiembro.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbselect;
            this.btn_agregarMiembro.Image = global::PjMoneyChange.Properties.Resources.member;

            //desativo los del segundo
            this.btn_aceptar.Visible = true;
                this.btn_anterior.Visible=false;
            this.btn_finalizar.Visible=false;

            this.panelempresa.Visible = false;
        }

        void insertar()
        {
            //fecha del sistema del windows
            try
            {

                DateTime Hoy = DateTime.Today;
                string datos = Hoy.ToString("dd/MM/yyyy");

                lbl_fecha.Text = datos;

            }

            catch (Exception)
            {

            }

            string fechita;

            fechita = txt_fechaa.Text + txt_fecham.Text + txt_fechad.Text;
            try
            {
                SqlCommand registro = new SqlCommand("INSERT INTO Miembros(usuario,clave,nombre,fecha,nacimiento,direccion,genero,telefono,tipo,estado)VALUES('"
                    + this.txt_usuario.Text + "','" + this.txt_clave.Text
                    + "','" + this.txt_nombre.Text
                    + "','" + this.lbl_fecha.Text
                    + "','" + Convert.ToString(fechita) // otro vendito logro!!
                    //   + "','" + Convert.ToDateTime(this.mascarafecha.Text)
                    + "','" + this.txt_direccion.Text
                    + "','" + this.cbx_genero.SelectedItem
                    + "','" + this.txt_telefono.Text
                    + "','Admin','activo')", cn);

               SqlCommand empresa = new SqlCommand("INSERT INTO Empresa(emp_id,razonsocial,nombre,direccion1,direccion2,rnc,pais,telefono,fax)VALUES(1,'" + this.txt_razonsocial.Text
                    + "','" + this.txt_nombre.Text
                    + "','" + this.txt_direccion1.Text
                    + "','" + this.txt_direccion2.Text
                    + "','" + Convert.ToDouble(this.txt_rnc.Text)
                    + "','" + this.cbx_pais.SelectedItem
                    + "','" + this.txt_telefono.Text
                    + "','" + this.txt_fax.Text
                    + "')", cn);
                cn.Open();
                empresa.ExecuteNonQuery();
                registro.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Instalacion Exitosa!");
                this.Hide();
                FrmLogin menu = new FrmLogin();
                menu.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }




        void guardardatos()
        {
            //fecha de nacimiento
            string fechita;
            fechita = txt_fechaa.Text + txt_fecham.Text + txt_fechad.Text;

            //fecha del sistema del windows
            DateTime Hoy = DateTime.Today;
            string datos = Hoy.ToString("dd/MM/yyyy");
            lbl_fecha.Text = datos;

            CsInstalacion.inusuario = txt_usuario.Text;
            CsInstalacion.inclave = txt_clave.Text;
            CsInstalacion.insexo = cbx_genero.Text;
            CsInstalacion.innombre = txt_nombre.Text;
            CsInstalacion.infecha = lbl_fecha.Text;
            CsInstalacion.innacimiento = fechita;
            CsInstalacion.intelefono = txt_telefono.Text;
            CsInstalacion.indireccion = txt_direccion.Text;
            CsInstalacion.dia = txt_fechad.Text;
            CsInstalacion.mes = txt_fecham.Text;
            CsInstalacion.anios = txt_fechaa.Text;

            //por si le damos a volver a tras al segundo formulario, mostrar valores guardados

            txt_usuario.Text = CsInstalacion.inusuario;
            txt_clave.Text = CsInstalacion.inclave;
            cbx_genero.SelectedValue = CsInstalacion.insexo;
            txt_nombre.Text = CsInstalacion.innombre;
            txt_fechad.Text = CsInstalacion.dia;
            txt_fecham.Text = CsInstalacion.mes;
            txt_fechaa.Text = CsInstalacion.anios;
        }
        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            txt_usuario.Select();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            cbx_genero.SelectedIndex = 2;

            ToolTip texto = new ToolTip();
            texto.ShowAlways = true;
            texto.SetToolTip(btn_agregarMiembro, "Registrar Cuenta de Administrador");
            texto.SetToolTip(btn_company, "Registrar Informacion de Empresa");
            texto.SetToolTip(pic_creador, "Creado by Json Design");

            this.btn_finalizar.Visible = false;
            this.btn_anterior.Visible = false;
            this.panelempresa.Visible = false;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txt_fechad_Enter(object sender, EventArgs e)
        {

            if (txt_fechad.Text == "d")
            {
                txt_fechad.Text = "";
            }
            else
            {
                txt_fechad.Select();
                txt_fechad.Focus();
            }
        }

        private void txt_fechad_Leave(object sender, EventArgs e)
        {
            if (txt_fechad.Text == "")
            {
                txt_fechad.Text = "d";
            }
            else
            {
                txt_fechad.Text = txt_fechad.Text;
            }
        }

        private void txt_fecham_Leave(object sender, EventArgs e)
        {
            if (txt_fecham.Text == "")
            {
                txt_fecham.Text = "m";
            }
            else
            {
                txt_fecham.Text = txt_fecham.Text;
            }
        }

        private void txt_fecham_Enter(object sender, EventArgs e)
        {
            if (txt_fecham.Text == "m")
            {
                txt_fecham.Text = "";
            }
            else
            {
                txt_fecham.Select();
                txt_fecham.Focus();
            }
        }

        private void txt_fechaa_Leave(object sender, EventArgs e)
        {
            if (txt_fechaa.Text == "")
            {
                txt_fechaa.Text = "a";
            }
            else
            {
                txt_fechaa.Text = txt_fechaa.Text;
            }
        }

        private void txt_fechaa_Enter(object sender, EventArgs e)
        {
            if (txt_fechaa.Text == "a")
            {
                txt_fechaa.Text = "";
            }
            else
            {
                txt_fechaa.Select();
                txt_fechaa.Focus();
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

        private void btn_limpiar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_limpiar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        }

        private void btn_limpiar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_limpiar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void btn_cancelar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_cancelar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        }

        private void btn_cancelar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_cancelar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void btn_finalizar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_finalizar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
            this.btn_finalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        }

        private void btn_finalizar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_finalizar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void btn_anterior_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_anterior.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
            this.btn_anterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        }

        private void btn_anterior_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_anterior.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_anterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {


            if (txt_usuario.Text == "")
            {
                MessageBox.Show("Usuario No Puede Ir en Blanco");
                txt_usuario.Select();
                txt_usuario.Focus();
                this.errorusuario.Visible = true;
            }
            else
            {
                if (txt_clave.Text == "")
                {
                    MessageBox.Show("Clave No Puede Ir en Blanco");
                    txt_clave.Select();
                    txt_clave.Focus();
                    this.errorclave.Visible = true;
                }
                else
                {

                    if (txt_clave.TextLength < 6)
                    {
                        MessageBox.Show("La Clave debe ser mayor que 6");
                        txt_clave.Select();
                        txt_clave.Focus();
                        this.errorclave.Visible = true;
                        this.errorclave2.Visible = true;
                    }
                    else
                    {

                    if (txt_clave.Text != txt_clave2.Text)
                    {
                        MessageBox.Show("Clave No Coinciden");
                        txt_clave2.Select();
                        txt_clave2.Focus();
                        this.errorclave.Visible = true;
                        this.errorclave2.Visible = true;
                    }
                    else
                    {
                        if (txt_nombre.Text == "")
                        {
                            MessageBox.Show("Nombre No Puede Ir en Blanco");
                            txt_nombre.Select();
                            txt_nombre.Focus();
                            this.errornombre.Visible = true;
                        }
                        else
                        {
                            if (txt_fechad.Text == "d")
                            {
                                MessageBox.Show("Digite Dia de Nacimiento");
                                txt_fechad.Select();
                                txt_fechad.Focus();
                                this.errorfecha.Visible = true;
                            }
                            else
                            {
                                if (txt_fecham.Text == "m")
                                {
                                    MessageBox.Show("Digite Mes de Nacimiento");
                                    txt_fecham.Select();
                                    txt_fecham.Focus();
                                    this.errorfecha.Visible = true;
                                }
                                else
                                {
                                    if (txt_fechaa.Text == "a")
                                    {
                                        MessageBox.Show("Digite Año de Nacimiento");
                                        txt_fechaa.Select();
                                        txt_fechaa.Focus();
                                        txt_fechaa.SelectionStart = 5;
                                        this.errorfecha.Visible = true;
                                    }
                                    else
                                    {
                                        txt_fechaa.MaxLength = 0;
                                        if (txt_fechaa.TextLength < 4)
                                        {
                                            MessageBox.Show("Año Incoompleto");
                                            txt_fechaa.SelectionStart = 4;
                                        }
                                        else
                                        {
                                            if (txt_fechaa.TextLength > 1990)
                                            {
                                                txt_telefono.SelectionStart = 3;
                                                this.errorfecha.Visible = true;
                                                MessageBox.Show("Año Incoompleto");
                                            }

                                            //guardar los datos en la clase antes de abrir sigueinte pasode intalacion

                                            siguiente();


                                        }
                                        this.errorfecha.Visible = false;                                        
                                    }this.errornombre.Visible = false;
                                } this.errornombre.Visible = false;
                            } this.errorclave.Visible = false;
                        } this.errorclave2.Visible = false;
                    } this.errorclave.Visible = false;
                    }
                } this.errorusuario.Visible = false;
            } 
        }

        private void FrmRegistro_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FrmRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            String datos = "abcdefghijklmnñopqrstuvwxyz ";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_nombre.TextLength < 4)
                {
                    this.errornombre.Visible = true;

                }
                else
                {
                    this.errornombre.Visible = false;
                    this.errornombreBien.Visible = true;
                }
            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            String datos = "abcdefghijklmnopqrstuvwxyz";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_usuario.TextLength < 4)
                {
                    this.errorusuario.Visible = true;

                }
                else
                {
                    this.errorusuario.Visible = false;
                    this.errorusuarioBien.Visible = true;
                }
            }
        }

        private void txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {


            /*/ if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
             {
                 MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 e.Handled = true;
                 return;
             }/*/

            String datos = "abcdefghijklmnopqrstuvwxyz0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_clave.TextLength < 5)
                {
                    this.errorclave.Visible = true;

                }
                else
                {
                    this.errorclave.Visible = false;
                    this.errorclaveBien.Visible = true;

                }
            }
        }

        private void txt_fechad_KeyPress(object sender, KeyPressEventArgs e)
        {


            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_fechad.TextLength == 1)
                {
                    txt_fecham.SelectionStart = 3;
                    txt_fecham.SelectAll();
                    txt_fecham.Select();
                    this.errorfecha.Visible = true;
                }
                else
                {
                    this.errorfecha.Visible = true;
                }
            }

        }

        private void txt_fecham_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_fecham.TextLength == 1)
                {
                    txt_fechaa.SelectionStart = 3;
                    txt_fechaa.SelectAll();
                    txt_fechaa.Select();
                    this.errorfecha.Visible = true;
                }
                else
                {
                    this.errorfecha.Visible = true;
                    
                }
            }
        }

        private void txt_fechaa_KeyPress(object sender, KeyPressEventArgs e)
        {

            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_fechaa.TextLength == 3)
                {
                    txt_telefono.SelectionStart = 3;
                    txt_telefono.SelectAll();
                    txt_telefono.Select();
                    this.errorfecha.Visible = false;
                    this.errorfechaBien.Visible = true;
                }
                else
                {
                    this.errorfecha.Visible = true;
                }
            }
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "abcdefghijklmnopqrstuvwxyz0123456789/ #,ñ";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (txt_telefono.TextLength < 11)
            {
                this.errortel.Visible = true;

            }
            else
            {
                this.errortel.Visible = false;
                this.errorTelBien.Visible = true;
                txt_direccion.SelectionStart = 3;
                txt_direccion.SelectAll();
                txt_direccion.Select();
            }

            txt_telefono.MaxLength = 0;

                        if (txt_telefono.Text == "1")
                        {

                            txt_telefono.Text = "";
                            txt_telefono.SelectionStart = 3;
                        }
                        else
                        {

                            if (txt_telefono.TextLength == 3)
                            {
                                txt_telefono.Text = txt_telefono.Text + "-";
                                txt_telefono.SelectionStart = 6;
                            }

                            else
                            {
                                if (txt_telefono.TextLength == 7)
                                {
                                    txt_telefono.Text = txt_telefono.Text + "-";

                                    txt_telefono.SelectionStart = 12;

                                }
                            }
                        }
          /*/  if (txt_telefono.TextLength == 1)
            {

                txt_telefono.Text =  txt_telefono.Text + "-";

                txt_telefono.SelectionStart = 4;
            }
            else
            {
                if (txt_telefono.TextLength == 5)
                {
                    txt_telefono.Text = txt_telefono.Text + "-";

                    txt_telefono.SelectionStart = 7;
                }
                else
                {
                    if (txt_telefono.TextLength == 9)
                    {
                        txt_telefono.Text = txt_telefono.Text + "-";

                        txt_telefono.SelectionStart = 12;

                    }
                    else
                    {

                    }
                }
            }/*/
            String datos = "0123456789-";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {

                e.Handled = true;

            }
            else
            {

            }
        }

        private void txt_clave2_KeyPress(object sender, KeyPressEventArgs e)
        {

            String datos = "abcdefghijklmnopqrstuvwxyz0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_clave2.TextLength < 5)
                {
                    this.errorclave2.Visible = true;

                }
                else
                {
                    this.errorclave2.Visible = false;
                    this.errorclave2Bien.Visible = true;
                }
            }
        }

        private void txt_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_clave.SelectAll();
                txt_clave.Select();
            }
        }

        private void txt_clave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_clave2.SelectAll();
                txt_clave2.Select();
            }
        }

        private void txt_clave2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               cbx_genero.SelectAll();
               cbx_genero.Select();
            }
        }

        private void cbx_genero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_nombre.SelectAll();
                txt_nombre.Select();
            }
        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_fechad.SelectAll();
                txt_fechad.Select();
            }
        }

        private void txt_direccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btn_aceptar.Select();
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            atras();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {

            insertar();
        }

        
    }
}

