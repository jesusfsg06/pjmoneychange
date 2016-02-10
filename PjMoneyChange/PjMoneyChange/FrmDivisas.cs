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
    public partial class FrmDivisas : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True");
        BindingSource bindingsource1 = new BindingSource();
        SqlCommand cmd = new SqlCommand();
        SqlCommandBuilder cmb = new SqlCommandBuilder();
        DataTable tabla = new DataTable();
        SqlDataAdapter adaptar = new SqlDataAdapter();
        public FrmDivisas()
        {
            InitializeComponent();
        }
        private void modificar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update Divisa Set "
                +"dvs_compra='"+ this.txt_compra.Text + "',"
                +"dvs_venta='"+ this.txt_venta.Text + "' Where id_dvs='"+ lbl_id.Text +"'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Editado Con Exito!!");


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
        void limpiar()
        {
            this.txt_compra.Text = "";
            this.txt_venta.Text = "";
        }
       void mostrarUltimo()
        {
         /*/   // mostrar ultimo agregado y con lamima secuencia mostrar registros del data
            adaptar = new SqlDataAdapter("SELECT * FROM Divisa", cn);
            cmb = new SqlCommandBuilder(adaptar);
            adaptar.Fill(tabla);
            bindingsource1.DataSource = tabla;
            lbl_id.DataBindings.Add("Text", bindingsource1, "id_dvs");
            cbx_tipo.DataBindings.Add("Text", bindingsource1, "dvs_nombre");
            txt_compra.DataBindings.Add("Text", bindingsource1, "dvs_compra");
            txt_venta.DataBindings.Add("Text", bindingsource1, "dvs_venta"); /*/
          


            DataSet ds = new DataSet();
            adaptar = new SqlDataAdapter("SELECT * FROM Divisa Order by dvs_nombre ASC", cn);
            adaptar.Fill(ds, "Divisa");
            cbx_tipo.DataSource = ds.Tables[0].DefaultView;
            cbx_tipo.ValueMember = "dvs_nombre";
            cbx_tipo.DisplayMember = "dvs_nombre"; 




        }
        private void FrmDivisas_Load(object sender, EventArgs e)
        {

          mostrarUltimo(); // como no se poner que me salga la ultima divisa en el combox,con los textbox, agregue una coneccion paralos textbox

      
          

          string ncuenta = cbx_tipo.SelectedValue.ToString();
          cmd = new SqlCommand("SELECT * FROM Divisa WHERE dvs_nombre=@ncuenta", cn);
          cmd.Parameters.AddWithValue("@ncuenta", cbx_tipo.SelectedValue);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            

            if (reader.Read())
            {
                

                txt_compra.Text = Convert.ToString(reader["dvs_compra"]);
                txt_venta.Text = Convert.ToString(reader["dvs_venta"]);
                lbl_id.Text = Convert.ToString(reader["id_dvs"]);
                
            }cn.Close();

         

           
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

                    modificar();

                }
            }
        }

        private void txt_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = ".0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
         /*   //cambiar punto por coma!
            if (e.KeyChar == Convert.ToChar('.'))
            {

                e.Handled = true;
                SendKeys.Send(",");
            } */
        }

        private void txt_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = ".0123456789";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
           /* //cambiar punto por coma!
            if (e.KeyChar == Convert.ToChar('.'))
            {

                e.Handled = true;
                SendKeys.Send(",");
            } */
        }

        private void cbx_tipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            string ncuenta = cbx_tipo.SelectedValue.ToString();

            cmd = new SqlCommand("SELECT * FROM Divisa WHERE dvs_nombre=@ncuenta ", cn);
            cmd.Parameters.AddWithValue("@ncuenta",cbx_tipo.SelectedValue);
cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
   
                txt_compra.Text = Convert.ToString(reader["dvs_compra"]);
                txt_venta.Text = Convert.ToString(reader["dvs_venta"]);
                lbl_id.Text = Convert.ToString(reader["id_dvs"]);

                this.txt_compra.SelectAll();
                
            }
            cn.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
