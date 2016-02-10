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
    public partial class frmempleados : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True;");
       SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adaptar = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable tabla = new DataTable();
        SqlCommandBuilder cmb = new SqlCommandBuilder();
        BindingSource bindingsource1 = new BindingSource();

        public frmempleados()
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
            txt_usuario.DataBindings.Add("Text", bindingsource1, "Usuario");
            txt_clave.DataBindings.Add("Text", bindingsource1, "Clave");
            txt_nombre.DataBindings.Add("Text", bindingsource1, "Nombre");
            //txt_nacimiento.DataBindings.Add("Text", bindingsource1, "Fecha");
            txt_direccion.DataBindings.Add("Text", bindingsource1, "Direccion");
           cbx_genero.DataBindings.Add("Text", bindingsource1, "genero");
            txt_telefono.DataBindings.Add("Text", bindingsource1, "Telefono");
            cbx_tipo.DataBindings.Add("SelectedItem", bindingsource1, "Tipo");
           
             
        }


            private void conectar2()
        {

            SqlDataAdapter adaptar = new SqlDataAdapter("SELECT * FROM Miembros order by m_id DESC", cn);
            DataSet ds = new DataSet();
            adaptar.Fill(ds, "Miembros");
            this.dgregistro.DataSource = ds.Tables[0];
           

        }
       //interface
        public void desactiva_boton()
            {
                this.btn_nuevo.Enabled = false;
                this.txt_clave2.Enabled = false;
                this.lbl_clave2.Enabled = false;


            }
        void busca2r()
        {
            DataSet ds = new DataSet();
            adaptar = new SqlDataAdapter("SELECT * FROM Miembros WHERE nombre LIKE '%" + this.txt_buscador.Text + "%'", cn);

            if (txt_buscador.Text == "")
            {
                SqlDataAdapter adaptar2 = new SqlDataAdapter("SELECT * FROM Miembros WHERE usuario LIKE '%" + this.txt_buscador.Text + "%'", cn);
            adaptar2.Fill(ds, "Miembros");
            }
            
            adaptar.Fill(ds, "Miembros");
            
            this.dgregistro.DataSource = ds.Tables[0];
        }

       public void desactiva_textos()
       {
           this.txt_usuario.Enabled = false;
           this.txt_clave.Enabled = false;
           this.txt_clave2.Enabled = false;
           this.txt_nombre.Enabled = false;
           this.txt_direccion.Enabled = false;
           this.txt_telefono.Enabled = false;

       }
       public void activa_textos()
       {
           this.txt_usuario.Enabled = true;
           this.txt_clave.Enabled = true;
           this.txt_clave2.Enabled = true;
           this.txt_nombre.Enabled = true;
           this.txt_direccion.Enabled = true;
           this.txt_telefono.Enabled = true;
       }
       public void ocultarenEditar()
       {
           //oculto lasfechas separadas  y muestrofecha junta//
           this.txt_fecham.Visible = false;
           this.txt_fechad.Visible = false;
           this.txt_fechaa.Visible = false;

           this.mascarafecha.Visible = true;
           this.txt_id.Visible = true;
           this.lbl_id.Visible = true;

           this.btn_limpiar.Enabled = true;
           this.btn_modificar.Enabled = true;
           this.btn_eliminar.Enabled = true;

           //oculto clave 2 con todo  ylabel para mostrar tipo de usuario
           pictureBox3.Visible = false;
           this.txt_clave2.Visible = false;
           this.lbl_clave2.Visible = false;
           //ahora activo el comboxde tipo de usuario comoesta en editar//
           this.lbl_estado.Visible = true;
           this.cbx_estado.Visible = true;

       }
       public void limpiar()
       {
           this.txt_usuario.Text = "";
           this.txt_clave.Text = "";
           this.txt_clave2.Text = "";
           this.txt_nombre.Text = "";
           this.txt_direccion.Text = "";
           this.txt_telefono.Text = "";
           this.cbx_tipo.SelectedIndex = -0;
           this.txt_id.Text = "";
           this.cbx_genero.SelectedValue=1;
           this.txt_telefono.Text = "";
           this.btn_nuevo.Enabled = true;
           txt_usuario.Select();
           


           //oculto lasfechas separadas  y muestrofecha junta//
           this.txt_fecham.Visible = true;
           this.txt_fechad.Visible = true;
           this.txt_fechaa.Visible = true;

           this.mascarafecha.Visible = false;
           this.txt_id.Visible = false;
           this.txt_id.Clear();
           this.lbl_id.Visible = false;
           this.btn_limpiar.Enabled = false;
           this.btn_modificar.Enabled = false;
           this.btn_eliminar.Enabled = false;

           //vuelvo amostrar clave 2 con todo  ylabel para mostrar tipo de usuario
           pictureBox3.Visible = true;
           this.txt_clave2.Visible = true;
           this.lbl_clave2.Visible = true;
           //ahora desactivo el comboxde tipo de usuario comoesta en editar//
           this.lbl_estado.Visible = false;
           this.cbx_estado.Visible = false;
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Miembros(usuario,clave,nombre,fecha,nacimiento,direccion,genero,telefono,tipo,estado)VALUES('"
                    + this.txt_usuario.Text + "','" + this.txt_clave.Text
                    + "','" + this.txt_nombre.Text
                    + "','" + this.lbl_fecha.Text
                    + "','" + Convert.ToString(fechita) // otro vendito logro!!
                    //   + "','" + Convert.ToDateTime(this.mascarafecha.Text)
                    + "','" + this.txt_direccion.Text
                    + "','" + this.cbx_genero.SelectedItem
                    + "','" + this.txt_telefono.Text
                    + "','" + this.cbx_tipo.Text
                    + "','activo')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Insertado Con Exito!", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                desactiva_textos();
                limpiar();
                this.txt_usuario.Focus();
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
            txt_usuario.Text = dgregistro[1, dgregistro.CurrentCell.RowIndex].Value.ToString();
            txt_clave.Text = dgregistro[2, dgregistro.CurrentCell.RowIndex].Value.ToString();
            txt_nombre.Text = dgregistro[3, dgregistro.CurrentCell.RowIndex].Value.ToString();
            lbl_fecha.Text = dgregistro[4, dgregistro.CurrentCell.RowIndex].Value.ToString();
           mascarafecha.Text = dgregistro[5, dgregistro.CurrentCell.RowIndex].Value.ToString();
            txt_direccion.Text = dgregistro[6, dgregistro.CurrentCell.RowIndex].Value.ToString();
          cbx_genero.Text = dgregistro[7, dgregistro.CurrentCell.RowIndex].Value.ToString();
            txt_telefono.Text = dgregistro[8, dgregistro.CurrentCell.RowIndex].Value.ToString();
            cbx_tipo.Text = dgregistro[9, dgregistro.CurrentCell.RowIndex].Value.ToString();
            cbx_estado.Text = dgregistro[10, dgregistro.CurrentCell.RowIndex].Value.ToString();
            btn_nuevo.Enabled = false;
            ocultarenEditar();
        }
        private void frmempleados_Load(object sender, EventArgs e)
        {
            conectar2();
            this.lbl_id.Hide();
            this.txt_id.Hide();

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {


            if (txt_usuario.Text == "")
            {
                MessageBox.Show("Usuario No Puede Ir en Blanco", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_usuario.Select();
                txt_usuario.Focus();

            }
            else
            {
                if (txt_clave.Text == "")
                {
                    MessageBox.Show("Clave No Puede Ir en Blanco", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_clave.Select();
                    txt_clave.Focus();

                }
                else
                {

                    if (txt_clave.TextLength < 6)
                    {
                        MessageBox.Show("La Clave debe ser mayor que 6", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_clave.Select();
                        txt_clave.Focus();

                    }
                    else
                    {

                        if (txt_clave.Text != txt_clave2.Text)
                        {
                            MessageBox.Show("Clave No Coinciden", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_clave2.Select();
                            txt_clave2.Focus();

                        }
                        else
                        {
                            if (txt_nombre.Text == "")
                            {
                                MessageBox.Show("Nombre No Puede Ir en Blanco", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_nombre.Select();
                                txt_nombre.Focus();

                            }
                            else
                            {
                                if (txt_fechad.Text == "d")
                                {
                                    MessageBox.Show("Digite Dia de Nacimiento", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txt_fechad.Select();
                                    txt_fechad.Focus();

                                }
                                else
                                {
                                    if (txt_fecham.Text == "m")
                                    {
                                        MessageBox.Show("Digite Mes de Nacimiento", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                        txt_fecham.Select();
                                        txt_fecham.Focus();

                                    }
                                    else
                                    {
                                        if (txt_fechaa.Text == "a")
                                        {
                                            MessageBox.Show("Digite Año de Nacimiento", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txt_fechaa.Select();
                                            txt_fechaa.Focus();
                                            txt_fechaa.SelectionStart = 5;

                                        }
                                        else
                                        {
                                            txt_fechaa.MaxLength = 0;
                                            if (txt_fechaa.TextLength < 4)
                                            {
                                                MessageBox.Show("Año Incompleto", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txt_fechaa.Select();
                                                txt_fechaa.Focus();
                                                txt_fechaa.SelectionStart = 4;
                                            }
                                            else
                                            {
                                                if (txt_fechaa.TextLength > 1990)
                                                {
                                                    MessageBox.Show("Año debe ser menor al 1990", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    txt_telefono.SelectionStart = 3;
                                                    txt_fechaa.Select();
                                                    txt_fechaa.Focus();
                                                }
                                                else
                                                {
                                                    if (cbx_tipo.SelectedItem.ToString()   == "")
                                                    {
                                                        cbx_tipo.Focus();
                                                        cbx_tipo.Select();
                                                        MessageBox.Show("Elegir Tipo de Usuario", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        insertar();
                                                    }
                                                }
                                            }

                                        } 
                                    } 
                                } 
                            } 
                        } 
                    }
                } 
            } 


            
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
                DialogResult result = MessageBox.Show("Deseas Eliminar este Usuario?", "Confirmacion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Miembros  WHERE m_id=@userid", cn);
                    cmd.Parameters.AddWithValue("userid", dgregistro.CurrentRow.Cells["m_id"].Value);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    int fila = dgregistro.CurrentRow.Index;
                    dgregistro.Rows.RemoveAt(fila);

                }
                else if (result == DialogResult.No)
                {
                    return;
                }
                /*
                SqlCommand cmd = new SqlCommand("DELETE FROM Miembros  WHERE m_id='" + this.txt_id.Text + "'", cn);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close(); 
                

            MessageBox.Show("Eliminado Con Exito!", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                */
                limpiar(); 
                 
               

            }

            catch (Exception)
            {
                MessageBox.Show("No se Pudo Eliminar Usuario", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {




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
            else
            {
                if (txt_fechad.TextLength == 1)
                {
                    txt_fecham.SelectionStart = 3;
                    txt_fecham.SelectAll();
                    txt_fecham.Select();
  
                }
                else
                {

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

                }
                else
                {


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
                    txt_direccion.SelectionStart = 3;
                    txt_direccion.SelectAll();
                    txt_direccion.Select();

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

            }
            else
            {

                cbx_tipo.Select();
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
                btn_nuevo.Select();
            }
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

        private void btn_modificar_Click(object sender, EventArgs e)
        {





              SqlCommand cmd = new SqlCommand("UPDATE Miembros SET "
               + " usuario='"+this.txt_usuario.Text+"',"
                +"clave='"+ this.txt_clave.Text + "',"
                +"nombre='"+ this.txt_nombre.Text + "',"
                + "nacimiento='" + this.mascarafecha.Text + "',"
               + " direccion='" + this.txt_direccion.Text + "',"
               + " genero='" + this.cbx_genero.Text + "'," 
                +"telefono='"+ this.txt_telefono.Text + "',"
                 +"tipo='"+ this.cbx_tipo.Text + "',"
                + "estado='" + this.cbx_estado.Text + "' WHERE m_id='" + this.txt_id.Text + "'", cn);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Editado Con Exito!", "Mensaje De Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                desactiva_textos();
                limpiar();
                this.txt_usuario.Focus();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
          //  int atras = this.BindingContext[ds, "Miembros"].Position = -1;
            this.BindingContext[ds,"Miembros"].Position++;
        }

    }
}
