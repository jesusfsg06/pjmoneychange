using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PjMoneyChange
{
    public partial class Spere : Form
    {
       int sg=0;
        public Spere()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sg = sg + 1; 
            progressBar1.Value = sg;
            timer1.Stop();

        }

        private void Spere_Load(object sender, EventArgs e)
        {
         
            timer1.Start();
           
        }
    }
}
