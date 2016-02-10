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
    public partial class FrmDivisasNueva : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True");
        
        public FrmDivisasNueva()
        {
            InitializeComponent();
        }

       private void insertar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Divisa(dvs_nombre,dvs_compra,dvs_venta) Values ('" + this.txt_divisa.Text + "', '" + this.txt_compra.Text + "', '" + this.txt_venta.Text + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                DialogResult result = MessageBox.Show("Agregada Con Exito!! Deseas Agregar Otro?", "Confirmacion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    limpiar();
                }
                else if (result == DialogResult.No)
                {
                    this.Hide();
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }

       void limpiar()
       {
           this.txt_divisa.Text = "";
           this.txt_compra.Text = "";
           this.txt_venta.Text = "";
           this.txt_divisa.Select();
           this.txt_divisa.Focus();
       }
        private void FrmDivisasNueva_Load(object sender, EventArgs e)
        {

        }
        private void btn_agregar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_agregar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;

        }

        private void btn_agregar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_agregar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        }

        private void btn_cancelar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_cancelar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelar.Focus();
            this.btn_cancelar.Select();
        }

        private void btn_cancelar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_cancelar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
          //  Conectar info =  new Conectar();
            
         //   SqlCommand comando = new SqlCommand("insert into tabla() values('" + info.Iusuario +"','" ++")",cn);

            if (txt_divisa.Text == "")
            {
                MessageBox.Show("Nombre de Divisa no puede ir en Blanco");
                this.txt_divisa.Select();

            }
            else
            {
                if (txt_compra.Text == "")
                {
                    MessageBox.Show("Debes introducir un Valor de Compra");
                    this.txt_compra.Select();
                }
                else
                {
                    if (txt_venta.Text == "")
                    {
                        MessageBox.Show("Debes introducir un Valor de Venta");
                        this.txt_venta.Select();
                    }
                    else
                    {

                        insertar();

                    }

                }
            }
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = ",0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
          /*  //cambiar punto por coma!
            if (e.KeyChar == Convert.ToChar('.'))
            {

                e.Handled = true;
                SendKeys.Send(",");
            }*/
        }

        private void txt_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = ",0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            /*
            //cambiar punto por coma!
            if (e.KeyChar == Convert.ToChar('.'))
            {

                e.Handled = true;
                SendKeys.Send(",");
            }*/
        }

        private void txt_divisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "abcdefghijklmnopqrstuvwxyz ";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }



    }
}
