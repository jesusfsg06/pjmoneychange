using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PjMoneyChange
{
    public partial class FrmEmpresaInfo : Form
    {
        public FrmEmpresaInfo()
        {
            InitializeComponent();
        }


        private void FrmEmpresaInfo_Load(object sender, EventArgs e)
        {
           txt_razonsocial.Select();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            cbx_pais.SelectedIndex = -1;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
           // limpiar();
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            if (txt_razonsocial.Text == "")
            {
                MessageBox.Show("Usuario No Puede Ir en Blanco");
                txt_razonsocial.Select();
                txt_razonsocial.Focus();
                this.errorusuario.Visible = true;
            }
            else
            {
                if (txt_nombre.Text == "")
                {
                    MessageBox.Show("UsuarioINcorre");

                    this.errorclave.Visible = true;
                }
                else
                {

                    if (txt_telefono.Text == "")
                    {
                        MessageBox.Show("Proporcione un Telefono");

                        this.errorclave.Visible = true;
                        this.errorclave2.Visible = true;
                    }
                    else
                    {
                        if (txt_telefono.Text == "")
                        {
                            MessageBox.Show("Proporcione un Telefono");
                            txt_nombre.Select();
                            txt_nombre.Focus();
                            this.errornombre.Visible = true;
                        }
                        else
                        {

                                            FrmEmpresaInfo paso2 = new FrmEmpresaInfo();
                                            paso2.Show();
                                            this.Hide();


                        } this.errorclave2.Visible = false;
                    } this.errorclave.Visible = false;
                    } this.errorclave.Visible = false;
                } this.errorusuario.Visible = false;
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
        }

        private void txt_razonsocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "abcdefghijklmnopqrstuvwxyz";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
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
        }

        private void txt_fechad_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void txt_fecham_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_fechaa_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "abcdefghijklmnopqrstuvwxyz0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {

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
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
          
            FrmRegistro atras = new FrmRegistro();
            atras.Show();
            this.Hide();
        }

        private void FrmEmpresaInfo_Load_1(object sender, EventArgs e)
        {

        }

    }
}

