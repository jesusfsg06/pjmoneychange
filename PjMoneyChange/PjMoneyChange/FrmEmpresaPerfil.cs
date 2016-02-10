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
    public partial class FrmEmpresaPerfil : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True");
        BindingSource bindingsource1 = new BindingSource();
        SqlCommand cmd = new SqlCommand();
        SqlCommandBuilder cmb = new SqlCommandBuilder();
        DataTable tabla = new DataTable();
        SqlDataAdapter adaptar = new SqlDataAdapter();
        public FrmEmpresaPerfil()
        {
            InitializeComponent();
        }
        void activar()
        {
            // activare //
            this.txt_razonsocial.Visible = true;
            this.txt_nombre.Visible = true;
            this.txt_direccion1.Visible = true;
            this.txt_direccion2.Visible = true;
            this.txt_rnc.Visible = true;
            this.txt_telefono.Visible = true;
            this.txt_fax.Visible = true;
            this.lbl_nota.Visible = true;
            this.cbx_pais.Visible = true;
            this.pictureBox1.Visible = true;
            this.pictureBox2.Visible = true;
            this.pictureBox3.Visible = true;
            this.pictureBox4.Visible = true;
            this.pictureBox5.Visible = true;
            this.pictureBox7.Visible = true;
            this.pictureBox8.Visible = true;

            //desativare los textos//
            this.lbl_razon2.Visible=false;
            this.lbl_nombre2.Visible = false;
            this.lbl_direc11.Visible = false;
            this.lbl_direc22.Visible = false;
            this.lbl_rnc2.Visible = false;
            this.lbl_pais2.Visible = false;
            this.lbl_tel2.Visible = false;
            this.lbl_fax2.Visible = false;

        }
        void desactivar()
        {
            //desactivo//
            this.txt_razonsocial.Visible = false;
            this.txt_nombre.Visible = false;
            this.txt_direccion1.Visible = false;
            this.txt_direccion2.Visible = false;
            this.txt_rnc.Visible = false;
            this.txt_telefono.Visible = false;
            this.txt_fax.Visible = false;
            this.lbl_nota.Visible = false;
            this.cbx_pais.Visible = false;
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = false;
            this.pictureBox3.Visible = false;
            this.pictureBox4.Visible = false;
            this.pictureBox5.Visible = false;
            this.pictureBox7.Visible = false;
            this.pictureBox8.Visible = false;

            //vuelvo y activo los textos //
            this.lbl_razon2.Visible = true;
            this.lbl_nombre2.Visible = true;
            this.lbl_direc11.Visible = true;
            this.lbl_direc22.Visible = true;
            this.lbl_rnc2.Visible = true;
            this.lbl_pais2.Visible = true;
            this.lbl_tel2.Visible = true;
            this.lbl_fax2.Visible = true;

            this.btn_salir.Enabled = false;
            this.btn_editar.Enabled = true;

        }
        void desactivarError()
        {
            this.errorrazon.Visible = false;
            this.errorrazonBien.Visible = false;
            this.errornombre.Visible = false;
            this.errornombreBien.Visible = false;
            this.errordirec1.Visible = false;
            this.errordirec1Bien.Visible = false;
            this.errordirec2.Visible = false;
            this.errordirec2Bien.Visible = false;
            this.errorfax.Visible = false;
            this.errorfaxBien.Visible = false;
            this.errortel.Visible = false;
            this.errortelBien.Visible = false;
            this.errorrnc.Visible = false;
            this.errorrncBien.Visible = false;

        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            activar();
            this.btn_salir.Enabled = true;
            this.btn_editar.Enabled = false;
            this.txt_razonsocial.Select();
            this.txt_razonsocial.SelectAll();
            this.cbx_pais.SelectedItem = lbl_pais2.Text; // increible logre que salga en el combox el pais selecionado en la sql

            //declararle los valores de los label alos texbox con sql
            this.txt_razonsocial.Text = lbl_razon2.Text;
            this.txt_nombre.Text = lbl_nombre2.Text;
            this.txt_direccion1.Text = lbl_direc11.Text;
            this.txt_direccion2.Text = lbl_direc22.Text;
            this.txt_rnc.Text = lbl_rnc2.Text;
            this.txt_telefono.Text = lbl_tel2.Text;
           this. txt_fax.Text = lbl_fax2.Text;

        }

        private void modificar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update Empresa Set "
                + "razonsocial='" + this.txt_razonsocial.Text + "',"
                 + "nombre='" + this.txt_nombre.Text + "',"
                  + "direccion1='" + this.txt_direccion1.Text + "',"
                   + "direccion2='" + this.txt_direccion2.Text + "',"
                    + "rnc='" + this.txt_rnc.Text + "',"
                    + "pais='" + this.cbx_pais.Text + "',"
                    + "telefono='" + this.txt_telefono.Text + "',"
                    + "fax='" + this.txt_fax.Text + "' where emp_id='" + lbl_id.Text + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Editado Con Exito!!");

                //desativar todos los textbox para mostrar los label con los valores de lostextbox nuevos

                desactivar();
                //ahora utilizo los valores de los txt y los pongo en los label //
                this.lbl_razon2.Text = txt_razonsocial.Text;
                this.lbl_nombre2.Text = txt_nombre.Text;
                this.lbl_direc11.Text = txt_direccion1.Text;
                this.lbl_direc22.Text = txt_direccion2.Text;
                this.lbl_rnc2.Text = txt_rnc.Text;
                this.lbl_pais2.Text = cbx_pais.Text;
                this.lbl_tel2.Text = txt_telefono.Text;
                this.lbl_fax2.Text = txt_fax.Text;
                this.btn_salir.Enabled = false;
                this.btn_editar.Enabled = true;
                desactivarError(); //desativo los botones de errores

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
        private void mostrarUltimo()
        {
            // mostrar ultimo agregado y con lamima secuencia mostrar registros del data
            adaptar = new SqlDataAdapter("SELECT * FROM Empresa", cn);
            cmb = new SqlCommandBuilder(adaptar);
            adaptar.Fill(tabla);
            bindingsource1.DataSource = tabla;
          //  cbx_pais.DataSource = bindingsource1;
            lbl_id.DataBindings.Add("Text", bindingsource1, "emp_id");
            lbl_razon2.DataBindings.Add("Text", bindingsource1, "razonsocial");
            lbl_nombre2.DataBindings.Add("Text", bindingsource1, "nombre");
            lbl_rnc2.DataBindings.Add("Text", bindingsource1, "rnc");
            lbl_direc11.DataBindings.Add("Text", bindingsource1, "direccion1");
            lbl_direc22.DataBindings.Add("Text", bindingsource1, "direccion2");
            lbl_fax2.DataBindings.Add("Text", bindingsource1, "fax");
            lbl_tel2.DataBindings.Add("Text", bindingsource1, "telefono");
            lbl_pais2.DataBindings.Add("Text", bindingsource1, "pais");
            lbl_empresatitulo.DataBindings.Add("Text", bindingsource1, "nombre");
            lbl_subtitulo.DataBindings.Add("Text", bindingsource1, "razonsocial");
        }



        void paiselegido()
        {

            //código para llenar el comboBox
            DataSet ds = new DataSet();
            //indicamos la consulta en SQL
            SqlDataAdapter adapta = new SqlDataAdapter("SELECT * FROM Empresa", cn);
            //se indica el nombre de la tabla
            adapta.Fill(ds, "Empresa");
            cbx_pais.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            cbx_pais.ValueMember = "pais";
;

        }

        private void FrmEmpresaPerfil_Load(object sender, EventArgs e)
        {
            this.btn_salir.Enabled = false;
          //  paiselegido();

            mostrarUltimo();


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {



            if (txt_razonsocial.Text == "")
            {
                MessageBox.Show("Razon Social no Puede Estar en blanco ");
                this.txt_razonsocial.SelectAll();
                this.txt_razonsocial.Focus();
            }
            else
            {
                modificar();



            }
        }

        private void btn_guardar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_salir.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
        }

        private void btn_guardar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_salir.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
        }

        private void btn_editar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_editar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
        }

        private void btn_editar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_editar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
        }

        private void btn_cancelar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_salir.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
        }

        private void btn_cancelar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_salir.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void txt_razonsocial_KeyPress(object sender, KeyPressEventArgs e)
        {

            String datos = "abcdefghijklmnopqrstuvwxyz0123456789 ";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_razonsocial.TextLength < 5)
                {
                    this.errorrazon.Visible = true;
                    this.errorrazonBien.Visible = false;
                    this.txt_razonsocial.Select();
                    this.txt_razonsocial.Focus();
                }
                else
                {
                    this.errorrazon.Visible = false;
                    this.errorrazonBien.Visible = true;
                }
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "abcdefghijklmnopqrstuvwxyz0123456789 ";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_nombre.TextLength < 5)
                {
                    this.errornombre.Visible = true;
                   this.errornombreBien.Visible = false;
                }
                else
                {
                    this.errornombre.Visible = false;
                    this.errornombreBien.Visible = true;
                }
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_telefono.TextLength < 11)
            {
                this.errortel.Visible = true;
                this.errortelBien.Visible = false;
            }
            else
            {
                this.errortel.Visible = false;
                this.errortelBien.Visible = true;
                txt_fax.SelectionStart = 3;
                txt_fax.SelectAll();
                txt_fax.Select();
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
            String datos = "0123456789-";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {

                e.Handled = true;

            }
            else
            {

            }
        }

        private void txt_fax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_fax.TextLength < 11)
            {
                this.errorfax.Visible = true;
                this.errorfaxBien.Visible = false;
            }
            else
            {
                this.errorfax.Visible = false;
                this.errorfaxBien.Visible = true;
                btn_salir.Select();
            }

            txt_fax.MaxLength = 0;

            if (txt_fax.Text == "1")
            {

                txt_fax.Text = "";
                txt_fax.SelectionStart = 3;
            }
            else
            {

                if (txt_fax.TextLength == 3)
                {
                    txt_fax.Text = txt_fax.Text + "-";
                    txt_fax.SelectionStart = 6;
                }

                else
                {
                    if (txt_fax.TextLength == 7)
                    {
                        txt_fax.Text = txt_fax.Text + "-";

                        txt_fax.SelectionStart = 12;

                    }
                }
            }
            String datos = "0123456789-";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {

                e.Handled = true;

            }
            else
            {

            }
        }

        private void txt_rnc_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_rnc.TextLength < 5)
                {
                    this.errorrnc.Visible = true;
                    this.errorrncBien.Visible = false;
                }
                else
                {
                    this.errorrnc.Visible = false;
                    this.errorrncBien.Visible = true;
                }
            }
        }

        private void txt_direccion1_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "abcdefghijklmnopqrstuvwxyz0123456789 ";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_direccion1.TextLength < 5)
                {
                    this.errordirec1.Visible = true;
                    this.errordirec1Bien.Visible = false;
                }
                else
                {
                    this.errordirec1.Visible = false;
                    this.errordirec1Bien.Visible = true;
                }
            }
        }

        private void txt_direccion2_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "abcdefghijklmnopqrstuvwxyz0123456789 ";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_direccion2.TextLength < 5)
                {
                    this.errordirec2.Visible = true;
                    this.errordirec2Bien.Visible = false;
                }
                else
                {
                    this.errordirec2.Visible = false;
                    this.errordirec2Bien.Visible = true;
                }
            }
        }
    }
}
