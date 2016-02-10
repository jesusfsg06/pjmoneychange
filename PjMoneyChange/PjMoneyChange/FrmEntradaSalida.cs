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
    public partial class FrmEntradaSalida : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adaptar = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable tabla = new DataTable();
        SqlCommandBuilder cmb = new SqlCommandBuilder();
        BindingSource bindingsource1 = new BindingSource();
        public FrmEntradaSalida()
        {
            InitializeComponent();
        }
        void conecta2()
        {
            adaptar = new SqlDataAdapter("Select * From EntradaSalida Order By Tipo_id DESC",cn);
            ds = new DataSet();
            adaptar.Fill(ds, "EntradaSalida");
            this.dgLista.DataSource = ds.Tables[0];
        }
        void insertar()
        {

        }
        private void FrmEntradaSalida_Load(object sender, EventArgs e)
        {
            conecta2();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
