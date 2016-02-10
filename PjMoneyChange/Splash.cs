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
    public partial class Splash : Form
    {
        int sg=100;
        bool cargar =true;

          //connecion
        SqlConnection cn = new SqlConnection(@"Data Source=MARILYN-PC\SQLEXPRESS;Initial Catalog=DBmoneychange;Integrated Security=True;");

               
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

      sg = sg - 5;     

                lbl_conteo.Text = sg.ToString();
                lbl_esperar.Text = lbl_esperar.Text;
                progressBar1.Value = sg;
             //   progressBar1.Visible = false;

                if (sg == 0)
                {
                    timer1.Stop();
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT m_id FROM Miembros ", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                {

                    FrmLogin entrada = new FrmLogin();
                    entrada.Show();
                    this.Hide();
                    cn.Close();
                }
                    else
                    {
                        FrmRegistro entrada = new FrmRegistro();
                        entrada.Show();
                        this.Hide();
                        cn.Close();
                    }
                   
                }
            //
            if (cargar)
            {
                lbl_esperar.ForeColor = Color.Firebrick;
                cargar = false;
            }
            else
            {
                lbl_esperar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
                cargar = true;
            }

 

        }

        private void Splash_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                timer1.Stop();
                e.Handled = true;
            }

                if (e.KeyCode == Keys.Space)
                {
                    timer1.Start();
                    e.Handled = true;
                }
        }
    }
}
