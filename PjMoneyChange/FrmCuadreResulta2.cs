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
    public partial class FrmCuadreResulta2 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adaptar = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable tabla = new DataTable();
        SqlCommandBuilder cmb = new SqlCommandBuilder();
        BindingSource bindingsource1 = new BindingSource();
        public FrmCuadreResulta2()
        {
            InitializeComponent();
        }
        void empresa()
        {
            //    ds = new DataSet();
            adaptar = new SqlDataAdapter("Select * from Empresa", cn);
            adaptar.Fill(tabla);
            bindingsource1.DataSource = tabla;
            lbl_empresatitulo.DataBindings.Add("Text", bindingsource1, "nombre");
            lbldirecion.DataBindings.Add("Text", bindingsource1, "direccion1");
            lbl_rnc.DataBindings.Add("Text", bindingsource1, "rnc");
            //   lbl_subtitulo.DataBindings.Add("Text", bindingsource1, "razonsocial");


        }

        private void FrmCuadreResulta2_Load(object sender, EventArgs e)
        {

            empresa();
            //lbl_empresatitulo.Text = Conectar.empresanombre;
           txtfecha.Text = ClaseCuadre.fecha;
            txt_usuario.Text = Conectar.empleadonombre;
            //cantidad
            lbl_c2mil.Text = ClaseCuadre.domil;
            lbl_cmil.Text = ClaseCuadre.mil;
            lbl_c500.Text = ClaseCuadre.quiniento;
            lbl_c200.Text = ClaseCuadre.dociento;
            lbl_c100.Text = ClaseCuadre.cien;
            lbl_c50.Text = ClaseCuadre.cincuenta;
            lbl_c25.Text = ClaseCuadre.veinticinco;
            lbl_c20.Text = ClaseCuadre.veinte;
            lbl_c10.Text = ClaseCuadre.diez;
            lbl_c5.Text = ClaseCuadre.cinco;
            lbl_c01.Text = ClaseCuadre.uno;


            //sumas//
            lbl_r2mil.Text = ClaseCuadre.domilr;
            lbl_rmil.Text = ClaseCuadre.milr;
            lbl_r500.Text = ClaseCuadre.quinientor;
            lbl_r200.Text = ClaseCuadre.docientor;
            lbl_r100.Text = ClaseCuadre.cienr;
            lbl_r50.Text = ClaseCuadre.cincuentar;
            lbl_r25.Text = ClaseCuadre.veinticincor;
            lbl_r20.Text = ClaseCuadre.veinter;
            lbl_r10.Text = ClaseCuadre.diezr;
            lbl_r5.Text = ClaseCuadre.cincor;
            lbl_r01.Text = ClaseCuadre.unor;



            //total
        double domil = Convert.ToDouble(lbl_r2mil.Text);
        double mil = Convert.ToDouble(lbl_rmil.Text);
         double qui = Convert.ToDouble(lbl_r500.Text);
         double doci = Convert.ToDouble(lbl_r200.Text);
         double cien = Convert.ToDouble(lbl_r100.Text);
         double cincu = Convert.ToDouble(lbl_r50.Text);
         double veinti = Convert.ToDouble(lbl_r25.Text);
         double veinte = Convert.ToDouble(lbl_r01.Text);
         double die = Convert.ToDouble(lbl_r20.Text);
         double cinco = Convert.ToDouble(lbl_r10.Text);
         double uno = Convert.ToDouble(lbl_r5.Text);

            lbl_total.Text = string.Format("{0:f2}", domil + mil + qui + doci + cien + cincu + veinti + veinte + die + cinco + uno);






        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
