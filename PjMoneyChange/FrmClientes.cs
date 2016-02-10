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
    public partial class FrmClientes : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True;");
       SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adaptar = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable tabla = new DataTable();
        SqlCommandBuilder cmb = new SqlCommandBuilder();
        BindingSource bindingsource1 = new BindingSource();
        public FrmClientes()
        {
            InitializeComponent();
        }

            private void conectar()
        {

            adaptar = new SqlDataAdapter("SELECT * FROM Miembros", cn);
            cmb = new SqlCommandBuilder(adaptar);
            adaptar.Fill(tabla);
            bindingsource1.DataSource = tabla;
            dgregistro.DataSource = bindingsource1;
            txt_id.DataBindings.Add("Text", bindingsource1, "ID");
            txt_nombre.DataBindings.Add("Text", bindingsource1, "Usuario");
            txt_apellido.DataBindings.Add("Text", bindingsource1, "Clave");
            txt_cedula.DataBindings.Add("Text", bindingsource1, "Nombre");
            //txt_nacimiento.DataBindings.Add("Text", bindingsource1, "Fecha");
            txt_direccion.DataBindings.Add("Text", bindingsource1, "Direccion");
           cbx_genero.DataBindings.Add("Text", bindingsource1, "genero");
            txt_telefono.DataBindings.Add("Text", bindingsource1, "Telefono");
            cbx_estado.DataBindings.Add("SelectedItem", bindingsource1, "Tipo");
           
             
        }


            private void conectar2()
        {

            SqlDataAdapter adaptar = new SqlDataAdapter("SELECT * FROM Clientes", cn);
            DataSet ds = new DataSet();
            adaptar.Fill(ds, "Clientes");
            this.dgregistro.DataSource = ds.Tables[0];
           

        }
       //interface
        public void desactiva_boton()
            {
                this.btn_nuevo.Enabled = false;



            }
        void busca2r()
        {
            adaptar = new SqlDataAdapter("SELECT * FROM Clientes WHERE nombre LIKE '%" + this.txt_buscador.Text + "%'", cn);
           SqlDataAdapter adaptar2 = new SqlDataAdapter("SELECT * FROM Clientes WHERE apellido LIKE '%" + this.txt_buscador.Text + "%'", cn);
            DataSet ds = new DataSet();
            adaptar.Fill(ds, "Clientes");
            adaptar2.Fill(ds, "Clientes");
            this.dgregistro.DataSource = ds.Tables[0];
        }

       public void desactiva_textos()
       {
           this.txt_nombre.Enabled = false;
           this.txt_apellido.Enabled = false;
           this.txt_cedula.Enabled = false;
           this.txt_direccion.Enabled = false;
           this.txt_telefono.Enabled = false;

       }
       public void activa_textos()
       {
           this.txt_nombre.Enabled = true;
           this.txt_apellido.Enabled = true;
           this.txt_cedula.Enabled = true;
           this.txt_direccion.Enabled = true;
           this.txt_telefono.Enabled = true;
       }

       public void limpiar()
       {
           this.txt_nombre.Text = "";
           this.txt_apellido.Text = "";
           this.txt_cedula.Text = "";
           this.txt_direccion.Text = "";
           this.txt_telefono.Text = "";
           this.cbx_estado.SelectedIndex = -0;
           this.txt_id.Text = "";
           this.cbx_genero.SelectedValue=1;
           this.txt_telefono.Text = "";
           this.btn_nuevo.Enabled = true;

           


           //oculto lasfechas separadas  y muestrofecha junta//

           this.txt_id.Visible = false;
           this.txt_id.Clear();
           this.lbl_id.Visible = false;
           this.btn_limpiar.Enabled = false;
           this.btn_modificar.Enabled = false;
           this.btn_eliminar.Enabled = false;
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

           try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Clientes(nombre,apellido,genero,fecha,direccion,telefono,cedula,estado)VALUES('"
                    + this.txt_nombre.Text + "','" + this.txt_apellido.Text
                    + "','" + this.cbx_genero.SelectedItem
                    + "','" + this.lbl_fecha.Text
                    + "','" +this.txt_direccion.Text
                    + "','" + this.txt_telefono.Text
                    + "','" + this.txt_cedula.Text
                    + "','" + this.cbx_estado.SelectedItem
                    + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Insertado Con Exito!", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                desactiva_textos();
                limpiar();
                this.txt_nombre.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
        public void modificar()
        {
            txt_id.Text = dgregistro[0, dgregistro.CurrentCell.RowIndex].Value.ToString();
            txt_nombre.Text = dgregistro[1, dgregistro.CurrentCell.RowIndex].Value.ToString();
            txt_apellido.Text = dgregistro[2, dgregistro.CurrentCell.RowIndex].Value.ToString();
            txt_cedula.Text = dgregistro[3, dgregistro.CurrentCell.RowIndex].Value.ToString();
            lbl_fecha.Text = dgregistro[4, dgregistro.CurrentCell.RowIndex].Value.ToString();
            //txt_fecha.Text = dgregistro[5, dgregistro.CurrentCell.RowIndex].Value.ToString();
            txt_direccion.Text = dgregistro[6, dgregistro.CurrentCell.RowIndex].Value.ToString();
          cbx_genero.Text = dgregistro[7, dgregistro.CurrentCell.RowIndex].Value.ToString();
            txt_telefono.Text = dgregistro[8, dgregistro.CurrentCell.RowIndex].Value.ToString();
            cbx_estado.Text = dgregistro[9, dgregistro.CurrentCell.RowIndex].Value.ToString();
            btn_nuevo.Enabled = false;

            //oculto lasfechas separadas  y muestrofecha junta//

            this.txt_id.Visible = true;
            this.lbl_id.Visible = true;

            this.btn_limpiar.Enabled = true;
            this.btn_modificar.Enabled = true;
            this.btn_eliminar.Enabled = true;

        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            conectar2();
            this.lbl_id.Hide();
            this.txt_id.Hide();

            cbx_estado.SelectedIndex = 0;// selecionar miembro activopor defecto
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            insertar();
            
        }

        private void dgregistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modificar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            busca2r();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM compra  WHERE ID='" + this.txt_id.Text + "'", cn);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                
                int fila = dgregistro.CurrentRow.Index;
            dgregistro.Rows.RemoveAt(fila);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");

                 limpiar();
               

            }

            catch (Exception)
            {
                MessageBox.Show("NO SE PUDO ELIMINAR DATO");
                cn.Close();
            }

            
        }
        
        
        private void btn_nuevo_MouseDown(object sender, MouseEventArgs e)
        {


            this.btn_nuevo.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazulselect;
            //volver a mostrar elboton principal sin tener q agregar un leave
        }

        private void btn_nuevo_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_nuevo.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazul;
        }

        private void btn_modificar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_modificar.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazul;
        }

        private void btn_modificar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_modificar.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazulselect;
            //volver a mostrar elboton principal sin tener q agregar un leave
        }

        private void btn_salir_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_salir.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazulselect;
        }

        private void btn_salir_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_salir.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazul;
        }

        private void btn_limpiar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_limpiar.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazulselect;
        }

        private void btn_limpiar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_limpiar.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazul;
        }

        private void btn_eliminar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_eliminar.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazulselect;
        }

        private void btn_eliminar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_eliminar.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazul;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            String datos = "abcdefghijklmnopqrstuvwxyz";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
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

            }
            else
            {

                cbx_estado.Select();
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

        }

        private void txt_clave2_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_apellido.SelectAll();
                txt_apellido.Select();
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
                txt_cedula.SelectAll();
                txt_cedula.Select();
            }
        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_apellido.SelectAll();
                txt_apellido.Select();
            }
        }

        private void txt_direccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txt_telefono.Select();
            }
        }


        private void btn_modificar_Click(object sender, EventArgs e)
        {
                         SqlCommand cmd = new SqlCommand("UPDATE Clientes SET "
 + " nombre='"+this.txt_nombre.Text+"',"
  +"apellido='"+ this.txt_apellido.Text + "',"
   + "genero='" + this.cbx_genero.Text + "',"
  + "fecha='" + lbl_fecha.Text + "',"
 + " direccion='" + this.txt_direccion.Text + "',"
 + " telefono='" + this.txt_telefono.Text + "'," 
  +"cedula='"+ this.txt_cedula.Text + "',"
   +"estado='"+ this.cbx_estado.Text + "' WHERE m_id='"+this.txt_id.Text+"'", cn);

  cn.Open();
  cmd.ExecuteNonQuery();
  cn.Close();

  MessageBox.Show("Editado Con Exito!", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
  desactiva_textos();
  limpiar();
  this.txt_nombre.Focus(); 
        }

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_cedula.TextLength < 11)
            {

            }
            else
            {

              txt_direccion.Select();
            }

            txt_cedula.MaxLength = 0;

            if (txt_cedula.Text == "0")
            {

                txt_cedula.Text = "";
                txt_cedula.SelectionStart = 3;
            }
            else
            {

                if (txt_cedula.TextLength == 3)
                {
                    txt_cedula.Text = txt_cedula.Text + "-";
                    txt_cedula.SelectionStart = 6;
                }

                else
                {
                    if (txt_cedula.TextLength == 11)
                    {
                        txt_cedula.Text = txt_cedula.Text + "-";

                        txt_cedula.SelectionStart = 13;

                    }
                    else
                    {

                        }
                }
        }

        }




    }
}
