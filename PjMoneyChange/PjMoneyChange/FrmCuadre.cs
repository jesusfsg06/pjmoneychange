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
    public partial class FrmCuadre : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adaptar = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable tabla = new DataTable();
        SqlCommandBuilder cmb = new SqlCommandBuilder();
        BindingSource bindingsource1 = new BindingSource();
        double cantidad = 0;
        double taza =0;
        string vacio = "0.00";
        public FrmCuadre()
        {
            InitializeComponent();
        }
        void limpiar()
        {

            //texbox
            this.txt_1.Text = "";
            this.txt_5.Text = "";
            this.txt_10.Text = "";
            this.txt_20.Text = "";
            this.txt_25.Text = "";
            this.txt_50.Text = "";
            this.txt_100.Text = "";
            this.txt_200.Text = "";
            this.txt_500.Text = "";
            this.txt_mil.Text = "";
            this.txt_2mil.Text = "";
            this.lbl_id.Text = "";
            //lbl
            this.lbl_1.Text = vacio;
            this.lbl_5.Text = vacio;
            this.lbl_10.Text = vacio;
            this.lbl_20.Text = vacio;
            this.lbl_25.Text = vacio;
            this.lbl_50.Text = vacio;
            this.lbl_100.Text = vacio;
            this.lbl_200.Text = vacio;
            this.lbl_500.Text = vacio;
            this.lbl_mil.Text = vacio;
            this.lbl_2mil.Text = vacio;


            this.txt_2mil.Focus();
            this.txt_2mil.Select();

            this.btn_guardar.Enabled = true;

            //poner fecha del sistema windows
            try
            {

                DateTime Hoy = DateTime.Today;
                string datos = Hoy.ToString("dd/MM/yyyy");

                lbl_fechadatos.Text = datos;

            }

            catch (Exception)
            {

            }
    
        }
        void empresa()
        {
        //    ds = new DataSet();
            adaptar = new SqlDataAdapter("Select nombre from Empresa",cn);
            adaptar.Fill(tabla);
            bindingsource1.DataSource = tabla;
           lbl_empresatitulo.DataBindings.Add("Text", bindingsource1, "nombre");
        //   lbl_subtitulo.DataBindings.Add("Text", bindingsource1, "razonsocial");


        }

        void mostrarultimo()
        {

         SqlDataAdapter  adaptar2 = new SqlDataAdapter("Select * from Cuadre Order by mid DESC", cn);
            adaptar2.Fill(tabla);
            bindingsource1.DataSource = tabla;
            lbl_id.DataBindings.Add("Text", bindingsource1, "mid");
           lbl_fechadatos.DataBindings.Add("Text", bindingsource1, "fecha");
           txt_1.DataBindings.Add("Text", bindingsource1, "m1");
           txt_5.DataBindings.Add("Text", bindingsource1, "m2");
           txt_10.DataBindings.Add("Text", bindingsource1, "m3");
           txt_20.DataBindings.Add("Text", bindingsource1, "m4");
           txt_25.DataBindings.Add("Text", bindingsource1, "m5");
           txt_50.DataBindings.Add("Text", bindingsource1, "m6");
           txt_100.DataBindings.Add("Text", bindingsource1, "m7");
           txt_200.DataBindings.Add("Text", bindingsource1, "m8");
           txt_500.DataBindings.Add("Text", bindingsource1, "m9");
           txt_mil.DataBindings.Add("Text", bindingsource1, "m10");
           txt_2mil.DataBindings.Add("Text", bindingsource1, "m11");


        }
        private void txt_2mil_Leave(object sender, EventArgs e)
        {
            if (txt_2mil.Text == "")
            {
                lbl_2mil.Text = vacio;
            }
            else
            {
                cantidad = Convert.ToDouble(txt_2mil.Text);
                taza = 10.50;
                lbl_2mil.Text = string.Format("{0:f2}", cantidad * taza);

            }

            
        }

        private void txt_mil_Leave(object sender, EventArgs e)
        {
            if (txt_mil.Text == "")
            {
                lbl_mil.Text = vacio;
            }
            else
            {
                cantidad = Convert.ToDouble(txt_mil.Text);
                taza = 1000;
                lbl_mil.Text = string.Format("{0:f2}", cantidad * taza);
            }

        }

        private void txt_500_Leave(object sender, EventArgs e)
        {
            if (txt_500.Text == "")
            {
                lbl_500.Text = vacio;
            }
            else
            {
                cantidad = Convert.ToDouble(txt_500.Text);
                taza = 500;
                lbl_500.Text = string.Format("{0:f2}", cantidad * taza);
            }

        }

        private void txt_200_Leave(object sender, EventArgs e)
        {
            if (txt_200.Text == "")
            {
                lbl_200.Text = vacio;
            }
            else
            {
                cantidad = Convert.ToDouble(txt_200.Text);
                taza = 200;
                lbl_200.Text = string.Format("{0:f2}", cantidad * taza);
            }

        }

        private void txt_100_Leave(object sender, EventArgs e)
        {
            if (txt_100.Text == "")
            {
                lbl_100.Text = vacio;
            }
            else
            {
                cantidad = Convert.ToDouble(txt_100.Text);

                lbl_100.Text = string.Format("{0:f2}", cantidad * taza);
            }

        }

        private void txt_50_Leave(object sender, EventArgs e)
        {
            if (txt_50.Text == "")
            {
                lbl_50.Text = vacio;
            }
            else
            {
                cantidad = Convert.ToDouble(txt_50.Text);
                taza = 50;
                lbl_50.Text = string.Format("{0:f2}", cantidad * taza);
            }

        }

        private void txt_25_Leave(object sender, EventArgs e)
        {
            if (txt_25.Text == "")
            {
                lbl_25.Text = vacio;
            }
            else
            {
                cantidad = Convert.ToDouble(txt_25.Text);
                taza = 25;
                lbl_25.Text = string.Format("{0:f2}", cantidad * taza);
            }

        }

        private void txt_20_Leave(object sender, EventArgs e)
        {
            if (txt_20.Text == "")
            {
                lbl_20.Text = vacio;
            }
            else
            {
                cantidad = Convert.ToDouble(txt_20.Text);
                taza = 20;
                lbl_20.Text = string.Format("{0:f2}", cantidad * taza);
            }

        }

        private void txt_10_Leave(object sender, EventArgs e)
        {

            if (txt_10.Text == "")
            {
                lbl_10.Text = vacio;
            }
            else
            {
                cantidad = Convert.ToDouble(txt_10.Text);
                taza = 10;
                lbl_10.Text = string.Format("{0:f2}", cantidad * taza);
            }
        }

        private void txt_5_Leave(object sender, EventArgs e)
        {

            if (txt_5.Text == "")
            {
                lbl_5.Text = vacio;
            }
            else
            {
                cantidad = Convert.ToDouble(txt_5.Text);
                taza = 5;
                lbl_5.Text = string.Format("{0:f2}", cantidad * taza);
            }
        }

        private void txt_1_Leave(object sender, EventArgs e)
        {
            if (txt_1.Text == "")
            {
                lbl_1.Text = vacio;
            }else
            {
            cantidad = Convert.ToDouble(txt_1.Text);
            taza = 1;
            lbl_1.Text = string.Format("{0:f2}", cantidad * taza);
            }
        }

        private void FrmCuadre_Load(object sender, EventArgs e)
        {
            //empresa();
            mostrarultimo();

            this.txt_2mil.Select();
            this.txt_2mil.Focus();
            this.btn_guardar.Enabled = false;
        }


        private void txt_2mil_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_2mil.Text == "0")
                {
                    this.txt_2mil.Text = "";

                }
            }
        }

        private void txt_mil_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_mil.Text == "0")
                {
                    this.txt_mil.Text = "";

                }
            }
        }

        private void txt_500_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_500.Text == "0")
                {
                    this.txt_500.Text = "";

                }
            }
        }

        private void txt_200_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_200.Text == "0")
                {
                    this.txt_200.Text = "";

                }
            }
        }

        private void txt_100_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_100.Text == "0")
                {
                    this.txt_100.Text = "";

                }
            }
        }

        private void txt_50_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_50.Text == "0")
                {
                    this.txt_50.Text = "";

                }
            }
        }

        private void txt_25_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_25.Text == "0")
                {
                    this.txt_25.Text = "";

                }
            }
        }

        private void txt_20_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_20.Text == "0")
                {
                    this.txt_20.Text = "";

                }
            }
        }

        private void txt_10_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_10.Text == "0")
                {
                    this.txt_10.Text = "";

                }
            }
        }

        private void txt_5_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_5.Text == "0")
                {
                    this.txt_5.Text = "";

                }
            }
        }

        private void txt_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_1.Text =="0")
                {
                    this.txt_1.Text="";

                }
            }
        }

        private void txt_2mil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_mil.SelectAll();
                this.txt_mil.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_mil.SelectAll();
                this.txt_mil.Focus();
                e.Handled = true;
            }
        }

        private void txt_mil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txt_2mil.SelectAll();
                this.txt_2mil.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_500.SelectAll();
                this.txt_500.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {

                this.txt_500.SelectAll();
                this.txt_500.Focus();
                e.Handled = true;

            }
        }

        private void txt_500_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txt_mil.SelectAll();
                this.txt_mil.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_200.SelectAll();
                this.txt_200.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_200.SelectAll();
                this.txt_200.Focus();
                e.Handled = true;
            }
        }

        private void txt_200_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txt_500.SelectAll();
                this.txt_500.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_100.SelectAll();
                this.txt_100.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_100.SelectAll();
                this.txt_100.Focus();
                e.Handled = true;
            }
        }

        private void txt_100_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txt_200.SelectAll();
                this.txt_200.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_50.SelectAll();
                this.txt_50.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_50.SelectAll();
                this.txt_50.Focus();
                e.Handled = true;
            }
        }

        private void txt_50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txt_100.SelectAll();
                this.txt_100.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_25.SelectAll();
                this.txt_25.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_25.SelectAll();
                this.txt_25.Focus();
                e.Handled = true;
            }
        }

        private void txt_25_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txt_50.SelectAll();
                this.txt_50.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_20.SelectAll();
                this.txt_20.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_20.SelectAll();
                this.txt_20.Focus();
                e.Handled = true;
            }
        }

        private void txt_20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txt_25.SelectAll();
                this.txt_25.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_10.SelectAll();
                this.txt_10.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_10.SelectAll();
                this.txt_10.Focus();
                e.Handled = true;
            }
        }

        private void txt_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txt_10.SelectAll();
                this.txt_10.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_5.SelectAll();
                this.txt_5.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_5.SelectAll();
                this.txt_5.Focus();
                e.Handled = true;
            }
        }

        private void txt_5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txt_10.SelectAll();
                this.txt_10.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_1.SelectAll();
                this.txt_1.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_1.SelectAll();
                this.txt_1.Focus();
                e.Handled = true;
            }
        }

        private void txt_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txt_5.SelectAll();
                this.txt_5.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_guardar.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.btn_guardar.Focus();
                e.Handled = true;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
         try
            {
                cmd = new SqlCommand("Insert into cuadre(m1,m2,m3,m4,m5,m6,m7,m8,m9,m10,m11) Values('" + txt_1.Text + "','" + txt_5.Text + "','" + txt_10.Text + "','" + txt_20.Text + "','" + txt_25.Text + "','" + txt_50.Text + "','" + txt_100.Text + "','" + txt_200.Text + "','" + txt_500.Text + "','" + txt_mil.Text + "','" + txt_2mil.Text + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Actualizada con Exito");
                this.btn_guardar.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_guardar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_guardar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
        }

        private void btn_guardar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_guardar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("Al agregar Nuevo, Se Limpiara el Cuadre Existente. Desea Agregar Nuevo?", "Confirmacion", MessageBoxButtons.YesNo);
            if (mensaje == DialogResult.Yes)
            {
                limpiar();
            }
            else if (mensaje == DialogResult.No)
            {
                
            }
            
        }

        private void btn_nuevo_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_nuevo.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
        }

        private void btn_nuevo_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_nuevo.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_cancelar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
        }

        private void btn_cancelar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_cancelar.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            ClaseCuadre.domil = txt_2mil.Text;
            ClaseCuadre.mil = txt_mil.Text;
            ClaseCuadre.quiniento = txt_500.Text;
            ClaseCuadre.dociento = txt_200.Text;
            ClaseCuadre.cien = txt_100.Text;
            ClaseCuadre.cincuenta = txt_50.Text;
            ClaseCuadre.veinticinco = txt_25.Text;
            ClaseCuadre.veinte = txt_20.Text;
            ClaseCuadre.diez = txt_10.Text;
            ClaseCuadre.cinco = txt_5.Text;
            ClaseCuadre.uno = txt_1.Text;

            ClaseCuadre.domilr = lbl_2mil.Text;
            ClaseCuadre.milr = lbl_mil.Text;
            ClaseCuadre.quinientor = lbl_500.Text;
            ClaseCuadre.docientor = lbl_200.Text;
            ClaseCuadre.cienr = lbl_100.Text;
            ClaseCuadre.cincuentar = lbl_50.Text;
            ClaseCuadre.veinticincor = lbl_25.Text;
            ClaseCuadre.veinter = lbl_20.Text;
            ClaseCuadre.diezr = lbl_10.Text;
            ClaseCuadre.cincor = lbl_5.Text;
            ClaseCuadre.unor = lbl_1.Text;




            ClaseCuadre.fecha = lbl_fechadatos.Text;
           FrmCuadreResulta2 mostrarimp = new FrmCuadreResulta2();
           mostrarimp.ShowDialog();


           

        }

        private void btn_imprimir_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_imprimir.BackgroundImage = global::PjMoneyChange.Properties.Resources.imprimirselect;
        }

        private void btn_imprimir_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_imprimir.BackgroundImage = global::PjMoneyChange.Properties.Resources.imprimir;
        }

        private void FrmCuadre_Move(object sender, EventArgs e)
        {
            txt_1.Select();
            txt_5.Select();
            txt_10.Select();
            txt_20.Select();
            txt_25.FindForm();
        }


    }
}
