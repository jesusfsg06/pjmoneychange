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
    public partial class frmMenu : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=SOFOCANDO\SOFOCANDO; Initial Catalog=DBMoneyChange; Integrated Security = true;");
       SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adaptar = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable tabla = new DataTable();
        SqlCommandBuilder cmb = new SqlCommandBuilder();
        BindingSource bindingsource1 = new BindingSource();
        int h = 0, v = 0;
        public frmMenu()
        {
            InitializeComponent();
        }

        void empresa()
        {
            adaptar = new SqlDataAdapter("SELECT * FROM Empresa", cn);
            cmb = new SqlCommandBuilder(adaptar);
            adaptar.Fill(tabla);
            bindingsource1.DataSource = tabla;

           lbl_empresa.DataBindings.Add("Text", bindingsource1, "nombre");


        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

            ToolTip texto = new ToolTip();
            texto.ShowAlways = true;
            texto.SetToolTip(btn_agregarDivisa, "Comprar Nueva Divisa");
            texto.SetToolTip(btn_venderDivisa, "Vender Divisa");
            texto.SetToolTip(btn_entradasalida, "Entradas y Salidas");
            texto.SetToolTip(btn_estadisticas, "Informe Actual");
            texto.SetToolTip(btn_miembro, "Miembros Empleados");
            texto.SetToolTip(btn_companymenu, "Informacion de Empresa");
            texto.SetToolTip(btn_tazamenu, "Cotizacion de Divisas");
            empresa();

        }

        private void markesina_Tick(object sender, EventArgs e)
        {
            if (h == 0)
            {

                this.lbl_empresa.Location = new System.Drawing.Point(this.Width, v);
                h = this.Width;
            }
            else
            {
                this.lbl_empresa.Location = new System.Drawing.Point(h, v);
                h -= 2;
                return;
            }
        }

        private void btn_taza_Click(object sender, EventArgs e)
        {
            FrmDivisas cambiarPrecios = new FrmDivisas();
            cambiarPrecios.ShowDialog();
        }

        private void btn_cuadre_Click(object sender, EventArgs e)
        {
            FrmCuadre cuadrar = new FrmCuadre();
            cuadrar.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clientes");
        }


        private void monedasYTazasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_taza_Click(sender, null);
        }

        private void btn_tazamenu_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_tazamenu.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenuselect;
        }

        private void btn_tazamenu_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_tazamenu.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }
        private void btn_tazamenu_MouseLeave(object sender, EventArgs e)
        {
            this.btn_tazamenu.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        private void btn_tazamenu_MouseEnter(object sender, EventArgs e)
        {
            this.btn_tazamenu.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenupasar;
        }

        private void btn_companymenu_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_companymenu.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenuselect;
        }

        private void btn_companymenu_MouseEnter(object sender, EventArgs e)
        {
            this.btn_companymenu.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenupasar;
        }

        private void btn_companymenu_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_companymenu.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        private void btn_companymenu_MouseLeave(object sender, EventArgs e)
        {
            this.btn_companymenu.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        private void btn_miembro_MouseEnter(object sender, EventArgs e)
        {
            this.btn_miembro.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenupasar;
        }

        private void btn_miembro_MouseLeave(object sender, EventArgs e)
        {
            this.btn_miembro.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        private void btn_miembro_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_miembro.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenuselect;
        }

        private void btn_miembro_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_miembro.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        private void btn_estadisticas_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_estadisticas.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenuselect;
        }

        private void btn_estadisticas_MouseEnter(object sender, EventArgs e)
        {
            this.btn_estadisticas.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenupasar;
        }

        private void btn_estadisticas_MouseLeave(object sender, EventArgs e)
        {
            this.btn_estadisticas.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        private void btn_estadisticas_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_estadisticas.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        private void btn_entradasalida_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_entradasalida.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenuselect;
        }

        private void btn_entradasalida_MouseEnter(object sender, EventArgs e)
        {
            this.btn_entradasalida.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenupasar;
        }

        private void btn_entradasalida_MouseLeave(object sender, EventArgs e)
        {
            this.btn_entradasalida.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        private void btn_entradasalida_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_entradasalida.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        private void btn_venderDivisa_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_venderDivisa.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenuselect;
        }

        private void btn_venderDivisa_MouseEnter(object sender, EventArgs e)
        {
            this.btn_venderDivisa.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenupasar;
        }

        private void btn_venderDivisa_MouseLeave(object sender, EventArgs e)
        {
            this.btn_venderDivisa.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        private void btn_venderDivisa_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_venderDivisa.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        private void btn_agregarDivisa_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_agregarDivisa.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenuselect;
        }

        private void btn_agregarDivisa_MouseEnter(object sender, EventArgs e)
        {
            this.btn_agregarDivisa.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenupasar;
        }

        private void btn_agregarDivisa_MouseLeave(object sender, EventArgs e)
        {
            this.btn_agregarDivisa.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        private void btn_agregarDivisa_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_agregarDivisa.BackgroundImage = global::PjMoneyChange.Properties.Resources.bbbmenu;
        }

        // menu archivo
        private void compañiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresaPerfil verEmpresa = new FrmEmpresaPerfil();
            verEmpresa.ShowDialog();
        }

        private void tazaCotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDivisas divisasTaza = new FrmDivisas();
            divisasTaza.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
           clientes.ShowDialog();
        }
        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmempleados cargar = new frmempleados();
            cargar.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // fin menu de archivo//


        // MenuDirecto //

        private void btn_entradasalida_Click(object sender, EventArgs e)
        {
            FrmEntradaSalida entraysale = new FrmEntradaSalida();
            entraysale.ShowDialog();
        }
        private void btn_agregarDivisa_Click(object sender, EventArgs e)
        {
            frmCompras comprar = new frmCompras();
            comprar.ShowDialog();
        }
        private void btn_tazamenu_Click(object sender, EventArgs e)
        {
            FrmDivisasNueva nuevadivisa = new FrmDivisasNueva();
            nuevadivisa.ShowDialog();
        }

        private void btn_companymenu_Click(object sender, EventArgs e)
        {
            FrmEmpresaPerfil inforcompany = new FrmEmpresaPerfil();
            inforcompany.ShowDialog();
        }

        private void btn_miembro_Click(object sender, EventArgs e)
        {
            frmempleados empleados = new frmempleados();
            empleados.ShowDialog();
        }

        //menu procesos//
        private void compraDivisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras compras = new frmCompras();
            compras.ShowDialog();
        }

        private void ventasDivisasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cajeroCuadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuadre cajacuadre = new FrmCuadre();
            cajacuadre.ShowDialog();
        }

        private void entradaSalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntradaSalida entradasalidas = new FrmEntradaSalida();
            entradasalidas.ShowDialog();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Acercade about = new Acercade();
            about.ShowDialog();
        }
        //finmenu procesos//


    }
}
