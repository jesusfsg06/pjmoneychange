using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace PjMoneyChange
{
    public partial class frmCompras : Form
    {
        //ago la coneccion  con el servidor fuera para llamarla en cualquier funcion

        double cantidadn;
        double tazan;
        double resulta2 =0;


        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adaptar = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable tabla = new DataTable();
        SqlCommandBuilder cmb = new SqlCommandBuilder();
        BindingSource bindingsource1 = new BindingSource();
        private double convertirCambio(double recibido, double devuelta)
        {
            return recibido * devuelta;
        }

        public frmCompras()
        {
              InitializeComponent();
           txt_importe.ReadOnly = true;
        }
        private void resultado_Click(object sender, EventArgs e)
        {
            //resultados
            cantidadn = Convert.ToDouble(txt_cantidad.Text);
            tazan = Convert.ToDouble(txt_taza.Text);
           // txt_importe.Text = Convert.ToString((cantidadn * tazan));
            txt_importe.Text = string.Format("{0:f2}", cantidadn * tazan);

        }
        private void resultado2_Click(object sender, EventArgs e)
        {
            //resultados


            cantidadn = Convert.ToDouble(txt_cantidad.Text);
            tazan = Convert.ToDouble(txt_taza.Text);
            txt_importe.Text = string.Format("{0:f2}", cantidadn * tazan);
        }
        //cargo los datos de la abse de datos al DataGrid

        private void conectar()
        {
            SqlDataAdapter adaptar = new SqlDataAdapter("SELECT * FROM CompraVenta order by IDFolio DESC", cn);
            DataSet dataset = new DataSet();
            adaptar.Fill(dataset, "CompraVenta");
            this.dgLista.DataSource = dataset.Tables[0];

        }
        private void mostrarUltimo()
        {
            // mostrar ultimo agregado y con lamima secuencia mostrar registros del data
            adaptar = new SqlDataAdapter("SELECT * FROM CompraVenta order by IDFolio DESC", cn);
            cmb = new SqlCommandBuilder(adaptar);
            adaptar.Fill(tabla);
            bindingsource1.DataSource = tabla;
            dgLista.DataSource = bindingsource1;
            lbl_id.DataBindings.Add("Text", bindingsource1, "IDFolio");
            lbl_fecha.DataBindings.Add("Text", bindingsource1, "Fecha");
            cbx_moneda.DataBindings.Add("Text", bindingsource1, "Moneda");
            lbl_cantidadof.DataBindings.Add("Text", bindingsource1, "Cantidad");
            lbl_tazaof.DataBindings.Add("Text", bindingsource1, "Cotizacion");
          //  lbl_importeof.Text = "RD$" + lbl_importeof.Text;
            
            importe_oculto.DataBindings.Add("Text", bindingsource1, "Importe");
            txt_clientes.DataBindings.Add("Text", bindingsource1, "Cliente");
            lbl_usuario.DataBindings.Add("Text", bindingsource1, "Usuario");
            lbl_tipo.DataBindings.Add("Text", bindingsource1, "Tipo");

            //despues de cargar el dato importe en el lbl importe oculto, le agrego un simbolo de dinero delante antes de mostar
            lbl_importeof.Text = "RD$" + importe_oculto.Text;
        }

        void divisastipo()
        {
            //para leer los registros de divisas y mostrarlos por nombre en un combox
            DataSet ds = new DataSet();
            adaptar = new SqlDataAdapter("SELECT * FROM Divisa Order by dvs_nombre DESC", cn);
            adaptar.Fill(ds, "Divisa");
            cbx_moneda.DataSource = ds.Tables[0].DefaultView;
            cbx_moneda.ValueMember = "dvs_nombre"; // me lo trae con este valor de la sql
            cbx_moneda.DisplayMember = "dvs_nombre"; // me lo meustra con este valor


        }
        void clientes()
        {

            DataSet ds = new DataSet();

            SqlDataAdapter adapta = new SqlDataAdapter("SELECT * FROM Clientes", cn);

            adapta.Fill(ds, "Clientes");
            cbx_clientes.DataSource = ds.Tables[0].DefaultView;
            cbx_clientes.DisplayMember = "nombre";
            cbx_clientes.ValueMember = "nombre";
        }
        void busca2r()
        {
            ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM CompraVenta WHERE IDFolio LIKE '%" + this.txt_buscador.Text + "%'  order by IDFolio DESC", cn);
            adp.Fill(ds, "CompraVenta");
            if (txt_buscador.Text == "")
            {

            }else
            {
            SqlDataAdapter adp1 = new SqlDataAdapter("SELECT * FROM CompraVenta WHERE Usuario LIKE '%" + this.txt_buscador.Text + "%'  order by IDFolio DESC", cn);
            SqlDataAdapter adp2 = new SqlDataAdapter("SELECT * FROM CompraVenta WHERE Cliente LIKE '%" + this.txt_buscador.Text + "%'  order by IDFolio DESC", cn);

            adp1.Fill(ds, "CompraVenta");
            adp2.Fill(ds, "CompraVenta");
            }

            this.dgLista.DataSource = ds.Tables[0];
        }

        void insertar()
        {
           try
            {
                conectar();

                SqlCommand com = new SqlCommand("insert into CompraVenta(Fecha,Moneda,Cantidad,Cotizacion,Importe,Cliente,Usuario,Tipo) values('" + lbl_fecha.Text + "', '" + cbx_moneda.Text + "' ,'" + txt_cantidad.Text + "','" + txt_taza.Text + "','" + txt_importe.Text + "','" + cbx_clientes.Text + "','" + lbl_usuario.Text + "','Compra')", cn);
                 cn.Open();

              //   SqlCommand capital = new SqlCommand("Select CapExistente from DineroFondo", cn);

                // string existente = capital.ExecuteScalar().ToString();
               //  string resultado;

               //  resultado = Convert.ToString(existente) - Convert.ToString(txt_importe.Text);


                com.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM CompraVenta order by IDFolio DESC", cn);
                DataSet dataset = new DataSet();
                adp.Fill(dataset, "CompraVenta");
                busca2r(); // para q me muestre lo ultimo
                cn.Close();

           }
           catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        

        }

        void comboxCambioDivisas()
        {

            // para que al leer los registros y mostrarlo en combox con el DivisasTipo, al leerlos que me muestre los datos, tipo de divisas y taza
            //este lo cargo en el evento nuevo para que al agregar nuevo me muestre la taza tbm, y lo cargo en el eevnto COMBOXalSelecionarItems
            string ncuenta = cbx_moneda.SelectedValue.ToString();
            cmd = new SqlCommand("SELECT * FROM Divisa WHERE dvs_nombre=@ncuenta ", cn);
            cmd.Parameters.AddWithValue("@ncuenta", cbx_moneda.SelectedValue);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            
            if (reader.Read())
            {

                txt_taza.Text = Convert.ToString(reader["dvs_compra"]);
                lbl_id.Text = Convert.ToString(reader["id_dvs"]);

            } cn.Close();
        }
        private void frmCompras_Load(object sender, EventArgs e)
        {
           clientes(); //  para mostrar en el combox o texbox clientes fijos y nuevos!

            divisastipo();// coloco eltipodemoneda primero q los ultimos datos del bilding para q sepuedan visualizar
            mostrarUltimo();



            string ncuenta = cbx_moneda.SelectedValue.ToString();
            cmd = new SqlCommand("SELECT * FROM Divisa WHERE dvs_nombre=@ncuenta", cn);
            cmd.Parameters.AddWithValue("@ncuenta", cbx_moneda.SelectedValue);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {


                txt_taza.Text = Convert.ToString(reader["dvs_compra"]);
                lbl_id.Text = Convert.ToString(reader["id_dvs"]);
                cn.Close();
            } 

            // activo que el ComboxCambioDivisas para que al leer la Divisa muestre tambien la taza
          //  comboxCambioDivisas();
            Conectar.empleadouser = lbl_usuario.Text;
            lbl_usuario.Text = Conectar.empleadouser;
           
            //fecha del sistema
            try
{

DateTime Hoy = DateTime.Today;
string datos = Hoy.ToString("dd/MM/yyyy");

lbl_fecha.Text = datos;

}

catch (Exception )

{

}


            ToolTip texto = new ToolTip();
            texto.ShowAlways = true;
            texto.SetToolTip(btn_buscar, "Buscar Registro");
            texto.SetToolTip(btn_nuevo, "[F1] Comprar Nueva Divisa");
            texto.SetToolTip(btn_imprimir, "[F2] Imprimir Factura");
            texto.SetToolTip(btn_cerrar, "[F4] Cerrar Ventana de Compra");
            texto.SetToolTip(btn_cancelar, "[F5] Cancelar Divisa Registrada");
            texto.SetToolTip(btn_factura, "[F3] Ver Factura");




            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.btn_nuevo.Focus();
            this.btn_nuevo.Select();





            //activar formulario de guardados falsos
            this.lbl_cantidadof.Visible = true;
            this.lbl_tazaof.Visible = true;
            this.lbl_importeof.Visible = true;
            this.lbl_recibidoof.Visible = true;

            //desactivar  formulario reales
            this.txt_cantidad.Visible = false;
            this.txt_taza.Visible = false;
            this.txt_importe.Visible = false;
            this.cbx_clientes.Visible = false;

            //desactivar botones reales
            this.btn_factura.Enabled = false;
            this.btn_imprimir.Enabled = false;
            this.btn_cancelar.Enabled = false;

            this.cbx_moneda.Enabled = false;
            this.cbx_clientes.Enabled = false;
            this.btn_clientes.Enabled = false;

            /*
            lbl_monitor.Text = "CASA DE CAMBIO SOFOCANDO.COM";  // titulo dela marquesina
            h = lbl_monitor.Location.X;
            v = lbl_monitor.Location.Y;
            marquesina.Start();*/
            
            if (txt_cantidad.Text == "")
            {
                txt_cantidad.Text = "0.00";
            }
            else
            {
                txt_cantidad.Text = txt_cantidad.Text;
            }
           

        }
        /*
        private void marquesina_Tick(object sender, EventArgs e)
        {
            if (h == 0)
            {

                this.lbl_monitor.Location = new System.Drawing.Point(this.Width, v);
                h = this.Width;
            }
            else
            {
                this.lbl_monitor.Location = new System.Drawing.Point(h, v);
                h -= 2;
                return;
            }
        }*/

        private void txt_cantidad_Enter(object sender, EventArgs e)
        {

                this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                this.txt_cantidad.BackColor = System.Drawing.Color.AliceBlue;
                this.txt_recibido.Text = "0.00"; // si se digitara la cantidad el dinero recibido db  volver a ingresarse
                this.lbl_devuelta.Text = ""; 
        }

        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            if ((cantidadn.ToString() == "") || (txt_cantidad.Text.Trim() == ""))
            {
                MessageBox.Show("Llene todos los campos");
                this.txt_cantidad.Select();
                this.txt_cantidad.Focus();
                this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                return;
            }
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_cantidad.BackColor = System.Drawing.Color.White;
            this.txt_cantidad.DeselectAll();
            this.txt_cantidad.HideSelection = true;


            resultado_Click(sender, null);
        }

        private void txt_cantidad_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.txt_importe.SelectAll();
                this.txt_importe.Focus();
                e.Handled = true;
            }

            if (e.Alt)
            {
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_importe.SelectAll();
                this.txt_importe.Focus();
                e.Handled = true;
            }
        }

        private void txt_importe_Enter(object sender, EventArgs e)
        {
            this.txt_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_importe.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void txt_importe_Leave(object sender, EventArgs e)
        {
            this.txt_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_importe.BackColor = System.Drawing.SystemColors.Window;
            this.txt_importe.DeselectAll();
            this.txt_importe.HideSelection = true;
            resultado2_Click(sender, null);
        }

        private void txt_importe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_recibido.SelectAll();
                this.txt_recibido.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                this.txt_cantidad.SelectAll();
                this.txt_cantidad.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_recibido.SelectAll();
                this.txt_recibido.Focus();
                e.Handled = true;
            }
        }

        private void txt_recibido_Enter(object sender, EventArgs e)
        {
            this.txt_recibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_recibido.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void txt_recibido_Leave(object sender, EventArgs e)
        {


            this.txt_recibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_recibido.BackColor = System.Drawing.SystemColors.Window;
            this.txt_recibido.DeselectAll();
            this.txt_recibido.HideSelection = true;
            resultado2_Click(sender, null);
            //resultados
            double rec, cant;
            rec = double.Parse(txt_recibido.Text);
            cant = double.Parse(txt_cantidad.Text);
            lbl_devuelta.Text = resulta2.ToString();
            lbl_devuelta.Text = string.Format("{0:f2}", rec - cant);
            if (txt_recibido.Text == "0.00")
            {
                this.lbl_devuelta.Text = "";
            }
        }

        private void txt_recibido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_imprimir.Select();
                this.btn_imprimir.Focus();
                e.Handled = true;




            }
            if (e.KeyCode == Keys.Up)
            {
                this.txt_importe.SelectAll();
                this.txt_importe.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.btn_imprimir.Select();
                this.btn_imprimir.Focus();
                e.Handled = true;
            }
        }






        private void btn_nuevo_Click(object sender, EventArgs e)
        {




            //desactivar formulario de guardados
            this.lbl_cantidadof.Visible = false;
            this.lbl_tazaof.Visible = false;
            this.lbl_importeof.Visible = false;
            this.lbl_recibidoof.Visible = false;

            this.cbx_clientes.Visible = false;
            this.txt_clientes.Visible = true;
            this.btn_clientes.Visible = true;


            //activar  formulario reales
            this.txt_cantidad.Visible = true;
            this.txt_taza.Visible = true;
            this.txt_importe.Visible = true;
            this.txt_recibido.Visible = true;
            this.cbx_moneda.Visible = true;
            this.cbx_moneda.Enabled = true;
            this.btn_clientes.Enabled = true;

            //desactivar botones reales
            this.btn_factura.Enabled = true;
            this.btn_imprimir.Enabled = true;
            this.btn_cancelar.Enabled = true;
            this.cbx_clientes.Enabled = true;


            this.txt_cantidad.ReadOnly = false;
            this.txt_cantidad.Focus();
            this.txt_cantidad.SelectAll();
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_cantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cantidad.BackColor = System.Drawing.Color.AliceBlue;

            this.txt_taza.ReadOnly = false;
            this.txt_taza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_taza.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_taza.BackColor = System.Drawing.Color.White;

            this.txt_importe.ReadOnly = false;
            this.txt_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_importe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_importe.BackColor = System.Drawing.Color.White;
            this.txt_importe.Text = "RD$0.00";

            this.lblmonitor.Text = "Registrando Nuevo";
            this.lblmonitor.ForeColor = System.Drawing.Color.Yellow;

            this.txt_recibido.ReadOnly = false;
            this.txt_recibido.Text = "0.00";
            this.txt_recibido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_recibido.BackColor = System.Drawing.SystemColors.Window;

            this.cbx_moneda.Enabled = true;


            this.cbx_clientes.Text = "";
            this.txt_clientes.Clear();
            this.txt_clientes.Text = "";
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

            //si la cantidad es cero
            if (cantidadn == 0)
            {

                MessageBox.Show("La Cantidad Debe ser Mayor que 0");
                this.txt_cantidad.SelectAll();
                this.txt_cantidad.Focus();
                this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
               // return;

            }
            else
            {

                if (tazan == 0)
                {

                    MessageBox.Show("La Cotizacion del Cambio Debe ser Mayor que 0");
                    this.txt_taza.SelectAll();
                    this.txt_taza.Focus();
                    this.txt_taza.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                   // return;
                }

                else
                {






                    // a puros coñazo hice eta maldita condicion!! 
                    if ((txt_clientes.Text == "")) // si no se digitan ningun maldito cliente
                    {
                        //
                        if (cbx_clientes.SelectedIndex > 0) // se eligira un maldito cliente de la lista
                        {

                            cbx_clientes.SelectedIndex.ToString();
                        }
                        else
                        {
                            cbx_clientes.SelectedIndex = 0; // si no se eligen cliente, se escojera el Publico
                        }

                    }
                    else
                    {
                      //  txt_clientes.Text = txt_clientes.Text;
                    }

                    insertar();


                }
            }
            //si la taza es cero


            this.lbl_recibidoof.Visible = false;

            //desactivar  botones reales
            this.txt_cantidad.Visible = false;
            this.txt_taza.Visible = false;
            this.txt_importe.Visible = false;
            this.txt_recibido.Visible = false;

            this.cbx_moneda.Enabled = false;


            //activar botones de guardados falsos
            this.lbl_cantidadof.Visible = true;
            this.lbl_tazaof.Visible = true;
            this.lbl_importeof.Visible = true;
            this.lbl_recibidoof.Visible = true;

            this.btn_nuevo.Select();
            this.btn_nuevo.Focus();

            //me guardara en pantalla el ultimo registro agregado
            lbl_cantidadof.Text = txt_cantidad.Text;
            lbl_importeof.Text = txt_importe.Text;
            lbl_tazaof.Text = txt_taza.Text;
            this.lblmonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblmonitor.Text = "Registrado";
            this.lblmonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        }

        private void txt_taza_Enter(object sender, EventArgs e)
        {
            this.txt_taza.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_taza.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void txt_taza_Leave(object sender, EventArgs e)
        {
            if ((tazan.ToString() == "") || (txt_taza.Text.Trim() == ""))
            {
                MessageBox.Show("Llene todos los campos");
                this.txt_taza.Select();
                this.txt_taza.Focus();
                this.txt_taza.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                return;
            }
            this.txt_taza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_taza.BackColor = System.Drawing.SystemColors.Window;
            this.txt_taza.DeselectAll();
            this.txt_taza.HideSelection = true;
            resultado2_Click(sender, null);
        }
        private void txt_taza_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_importe.SelectAll();
                this.txt_importe.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                this.txt_cantidad.SelectAll();
                this.txt_cantidad.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_importe.SelectAll();
                this.txt_importe.Focus();
                e.Handled = true;
            }
        }
        /*/
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) ||
                (keyData == Keys.Left) ||
                (keyData == Keys.Up) ||
                (keyData == Keys.Down) || 
                (keyData == Keys.Control) || 
                (keyData == Keys.Alt) ||
                (keyData == Keys.A) ||
                (keyData == Keys.B) ||
                (keyData == Keys.C) ||
                (keyData == Keys.D) ||
                (keyData == Keys.E) ||
                (keyData == Keys.F) ||
                (keyData == Keys.G) ||
                (keyData == Keys.H) ||
                (keyData == Keys.I) ||
                (keyData == Keys.J) ||
                (keyData == Keys.K) ||
                (keyData == Keys.L) ||
                (keyData == Keys.M) ||
                (keyData == Keys.N) ||
                (keyData == Keys.O) ||
                (keyData == Keys.P) ||
                (keyData == Keys.Q) ||
                (keyData == Keys.R) ||
                (keyData == Keys.S) ||
                (keyData == Keys.T) ||
                (keyData == Keys.U) ||
                (keyData == Keys.V) ||
                (keyData == Keys.W) ||
                (keyData == Keys.X) ||
                (keyData == Keys.Y) ||
                (keyData == Keys.Z) ||
                (keyData == Keys.Tab) ||
                (keyData == Keys.Shift) ||
                (keyData == Keys.Space) ||

                (keyData == Keys.ShiftKey) ||

                (keyData == Keys.Crsel) ||

                (keyData == Keys.ShiftKey)
                )
            {
                //Do custom stuff or nothing.
                //true if key was processed by control, false otherwise
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }/*/

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

                try
                {
                    if (tabla.Rows.Count > 0)
                    {
                    SqlCommand cmd = new SqlCommand("DELETE FROM CompraVenta  WHERE IDFolio='" + this.lbl_id.Text + "'", cn);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();


                    MessageBox.Show("ELIMINADO CORRECTAMENTE");

                    // limpiar();
                    this.txt_cantidad.Focus();
                    this.btn_cancelar.Enabled = false;

                        int fila = dgLista.CurrentRow.Index;
                        dgLista.Rows.RemoveAt(fila);
                    }

                }

                catch (Exception)
                {
                    MessageBox.Show("NO SE PUDO ELIMINAR DATO");
                    cn.Close();
                }
                


        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            //al activar lalista combo de cliente selecionar elcliente general
           // cbx_clientes.SelectedIndex = 1;
            txt_clientes.Text = "";
            txt_clientes.Clear();
            btn_clientes.Visible = false;
            txt_clientes.Visible = false;
            cbx_clientes.Visible = true;
            this.cbx_clientes.Enabled = true;


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

        private void btn_cancelar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_cancelar.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazul;
        }

        private void btn_cancelar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_cancelar.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazulselect;
            //volver a mostrar elboton principal sin tener q agregar un leave
        }

        private void btn_cerrar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_cerrar.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazulselect;
        }

        private void btn_cerrar_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_cerrar.BackgroundImage = global::PjMoneyChange.Properties.Resources.botonazul;
        }

        private void btn_clientes_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_clientes.BackgroundImage = global::PjMoneyChange.Properties.Resources.imprimirselect;
        }

        private void btn_clientes_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_clientes.BackgroundImage = global::PjMoneyChange.Properties.Resources.imprimir;
        }

        private void btn_imprimir_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_imprimir.BackgroundImage = global::PjMoneyChange.Properties.Resources.imprimirselect;
        }

        private void btn_imprimir_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_imprimir.BackgroundImage = global::PjMoneyChange.Properties.Resources.imprimir;
        }

        private void btn_factura_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_factura.BackgroundImage = global::PjMoneyChange.Properties.Resources.imprimirselect;
        }

        private void btn_factura_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_factura.BackgroundImage = global::PjMoneyChange.Properties.Resources.imprimir;
        }

        private void btn_calculo_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_calculo.BackgroundImage = global::PjMoneyChange.Properties.Resources.imprimirselect;
        }

        private void btn_calculo_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_calculo.BackgroundImage = global::PjMoneyChange.Properties.Resources.imprimir;
        }

        private void cbx_moneda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_cantidad.SelectAll();
                this.txt_cantidad.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.txt_cantidad.SelectAll();
                this.txt_cantidad.Focus();
                e.Handled = true;
            }

        }

        private void btn_imprimir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txt_recibido.SelectAll();
                this.txt_recibido.Focus();
                e.Handled = true;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            busca2r();
        }

        private void dgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btn_cancelar.Enabled = true;

            this.lbl_recibidoof.Visible = false;

            //desactivar  botones reales
            this.txt_cantidad.Visible = false;
            this.txt_taza.Visible = false;
            this.txt_importe.Visible = false;
            this.txt_recibido.Visible = false;

            this.cbx_moneda.Enabled = false;


            //activar botones de guardados falsos
            this.lbl_cantidadof.Visible = true;
            this.lbl_tazaof.Visible = true;
            this.lbl_importeof.Visible = true;
            this.lbl_recibidoof.Visible = true;

            this.btn_nuevo.Select();
            this.btn_nuevo.Focus();

            //me guardara en pantalla el ultimo registro agregado
            lbl_cantidadof.Text = txt_cantidad.Text;
            lbl_importeof.Text = txt_importe.Text;
            lbl_tazaof.Text = txt_taza.Text;
            this.lblmonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblmonitor.Text = "Registrado";
            this.lblmonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;



          lbl_id.Text = dgLista[0, dgLista.CurrentCell.RowIndex].Value.ToString();
          lbl_fecha.Text = dgLista[1, dgLista.CurrentCell.RowIndex].Value.ToString();
          cbx_moneda.Text = dgLista[2, dgLista.CurrentCell.RowIndex].Value.ToString();
       lbl_cantidadof.Text = dgLista[3, dgLista.CurrentCell.RowIndex].Value.ToString();
        lbl_tazaof.Text = dgLista[4, dgLista.CurrentCell.RowIndex].Value.ToString();
         lbl_importeof.Text = dgLista[5, dgLista.CurrentCell.RowIndex].Value.ToString();
          txt_clientes.Text = dgLista[6, dgLista.CurrentCell.RowIndex].Value.ToString();
         lblmonitor.Text = dgLista[7, dgLista.CurrentCell.RowIndex].Value.ToString();

            //despues que el label importe oculto jale los datos, agregar simbolo de dineros
         lbl_importeof.Text = "RD$" + importe_oculto.Text;

          /*/  if (this.dgLista.SelectedRows.Count > 0 &&
    this.dgLista.SelectedRows[0].Index !=
    this.dgLista.Rows.Count - 1)
            {
                this.dgLista.Rows.RemoveAt(
                    this.dgLista.SelectedRows[0].Index);
            }/*/
        }

        private void cbx_moneda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ncuenta = cbx_moneda.SelectedValue.ToString();

            cmd = new SqlCommand("SELECT * FROM Divisa WHERE dvs_nombre=@ndivisa ", cn);
            cmd.Parameters.AddWithValue("@ndivisa", cbx_moneda.SelectedValue);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                txt_taza.Text = Convert.ToString(reader["dvs_compra"]);
                lbl_id.Text = Convert.ToString(reader["id_dvs"]);
                txt_cantidad.Text = Convert.ToString(reader["dvs_venta"]);

                this.txt_cantidad.SelectAll();

            }
            cn.Close();
        }

        private void btn_calculo_Click(object sender, EventArgs e)
        {
            FrmCalculadora calcular = new FrmCalculadora();
            calcular.ShowDialog();
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789.,";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
                            //cambiar punto por coma!
            if (e.KeyChar == Convert.ToChar('.'))
            {

            e.Handled = true;
            SendKeys.Send(",");
            }
        }

        private void txt_taza_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789.,";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            /*    //cambiar punto por coma!
            if (e.KeyChar == Convert.ToChar('.'))
            {

            e.Handled = true;
            SendKeys.Send(",");
            }*/
        }

        private void txt_importe_KeyPress(object sender, KeyPressEventArgs e)
        {
            String datos = "0123456789.,";
            if (datos.Contains(e.KeyChar) == false & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
                            //cambiar punto por coma!
            if (e.KeyChar == Convert.ToChar('.'))
            {

            e.Handled = true;
            SendKeys.Send(",");
            }
        }

        private void panel_contenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblmonitor_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tazaof_Click(object sender, EventArgs e)
        {

        }
       

    }
}
