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
    public partial class FrmCapital : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adaptar = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable tabla = new DataTable();
        BindingSource bindingsource1 = new BindingSource();
        public FrmCapital()
        {
            InitializeComponent();
        }
        void mostrarultimo()
        {

            adaptar = new SqlDataAdapter("Select * from DineroFondo", cn);
            adaptar.Fill(tabla);
            bindingsource1.DataSource = tabla;
          lbl_capitalinicial.DataBindings.Add("Text", bindingsource1, "CapInicial");
          lbl_capitalexistente.DataBindings.Add("Text", bindingsource1, "CapExistente");



        }

        private void FrmCapital_Load(object sender, EventArgs e)
        {
            lbl_subtitulo.Text = Conectar.empresanombre;
            mostrarultimo();
           double inicial = Convert.ToDouble(lbl_capitalinicial.Text);
          double existente = Convert.ToDouble(lbl_capitalexistente.Text);
          
            if (Convert.ToDouble(lbl_capitalinicial.Text) > Convert.ToDouble(lbl_capitalexistente.Text))
            {
                this.lbl_estado.BackColor = System.Drawing.Color.IndianRed;
                lbl_estado.Text = string.Format("{0:f2}", existente - inicial);
                //this.lbl_estado.Text = "Estable";
            }
            else
            {
                lbl_estado.Text = string.Format("{0:f2}", existente - inicial);
                this.lbl_estado.BackColor = System.Drawing. Color.LightSeaGreen;
                 
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_salir_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_salir.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnselecionado;
        }

        private void btn_salir_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_salir.BackgroundImage = global::PjMoneyChange.Properties.Resources.btnex;
        }
    }
}
