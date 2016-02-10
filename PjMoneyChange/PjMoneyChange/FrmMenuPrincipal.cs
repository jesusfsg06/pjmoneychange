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
    public partial class FrmMenuPrincipal : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adaptar = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable tabla = new DataTable();
        SqlCommandBuilder cmb = new SqlCommandBuilder();
        BindingSource bindingsource1 = new BindingSource();

        public FrmMenuPrincipal()
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
            lbl_razonsocial.DataBindings.Add("Text", bindingsource1, "razonsocial");
            Conectar.empresanombre = lbl_empresa.Text;
            Conectar.empresasocial = lbl_razonsocial.Text;
        }

        void usermiembros()
        {
            //ocultar botones que solo son para admin
            this.btn_clientes.Visible = false;
            this.btn_entradasalida.Visible = false;
            this.btn_miembro.Visible = false;
            this.btn_taza.Visible = false;
            this.btn_companymenu.Visible = false;
            this.btn_tazamenu.Visible = false;

            //archivos
            this.compañiaToolStripMenuItem.Visible = false;
            this.usuariosToolStripMenuItem.Visible = false;
            this.clientesToolStripMenuItem.Visible = false;
            this.productosToolStripMenuItem.Visible = false;

            //consultas
            this.consultasToolStripMenuItem.Visible = false;

            //procesos
            this.entradaSalidadToolStripMenuItem.Visible = false;

            //reorganizar menu
            this.btn_estadisticas.Location = new System.Drawing.Point(192, 5);
            this.btn_cuadre.Location = new System.Drawing.Point(3, 6);
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_encabezado.Visible = toolBarToolStripMenuItem.Checked;
        }


        private void panelDerechoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_menuder.Visible = panelDerechoToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade acerca = new Acercade();
            acerca.MdiParent = this;
            acerca.Show();
        }
        //panel izquierdooooooo
        private void btn_taza_Click(object sender, EventArgs e)
        {
            FrmDivisas taza = new FrmDivisas();
            taza.MdiParent = this;
            taza.Show();
        }

        private void btn_cuadre_Click(object sender, EventArgs e)
        {
            FrmCuadre panelcuadre = new FrmCuadre();
            panelcuadre.MdiParent = this;
            panelcuadre.Show();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            empresa();

            lbl_usuario.Text = Conectar.empleadonombre;
            Conectar.empleadouser = lbl_usuario.Text;
            lbl_usuario.Text = Conectar.empleadouser;


            lbl_empresa.Text = lbl_empresa.Text;
            this.Text = lbl_empresa.Text + " Usuario: " + lbl_usuario.Text;
            
            // condicion para tipos de usuarios mostrados
            if(Conectar.tipo == "Admin")
            {
                MessageBox.Show("Bienvenido: "+ Conectar.empleadonombre);
            }else
            {
                usermiembros(); // solo se muestran los botones de formularios para empleados
            }
            
           lbl_fecha.Text = DateTime.Now.ToString("G");
            ToolTip texto = new ToolTip();
            texto.ShowAlways = true;
            texto.SetToolTip(btn_agregarDivisa, "Comprar Nueva Divisa");
            texto.SetToolTip(btn_venderDivisa, "Vender Divisa");
            texto.SetToolTip(btn_entradasalida, "Entradas y Salidas");
            texto.SetToolTip(btn_estadisticas, "Informe Actual");
            texto.SetToolTip(btn_miembro, "Miembros Empleados");
            texto.SetToolTip(btn_companymenu, "Informacion de Empresa");
            texto.SetToolTip(btn_tazamenu, "Cotizacion de Divisas");
           
        }


        private void btn_clientes_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.MdiParent = this;
            clientes.Show();
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
            entraysale.MdiParent = this;
            entraysale.Show();
        }
        private void btn_agregarDivisa_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel.Text = "Agregando Nueva Compra";
            frmCompras comprar = new frmCompras();
            comprar.MdiParent = this;
            comprar.Show();
        }
        private void btn_tazamenu_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel.Text = "Cotizaciones de Divisas";
            FrmDivisasNueva nuevadivisa = new FrmDivisasNueva();
            nuevadivisa.MdiParent = this;
            nuevadivisa.Show();
        }

        private void btn_companymenu_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel.Text = "Informacion de Compañia";
            FrmEmpresaPerfil inforcompany = new FrmEmpresaPerfil();
            inforcompany.MdiParent = this;
            inforcompany.Show();
        }

        private void btn_miembro_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel.Text = "Gestion de Empleados";
            frmempleados empleados = new frmempleados();
            empleados.MdiParent = this;
            empleados.Show();
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

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculadora calculadora = new FrmCalculadora();
            calculadora.MdiParent = this;
            calculadora.Show();
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            Spere abrir = new Spere();
            abrir.ShowDialog();

        }

        private void btn_venderDivisa_Click(object sender, EventArgs e)
        {

        }

        private void entradasYSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCapital capital = new FrmCapital();
            capital.MdiParent = this;
            capital.Show();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            FrmLogin abrir = new FrmLogin();
            abrir.Show();
            this.Close();
        }


        //finmenu procesos//

    }
}
