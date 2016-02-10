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
    public partial class FrmCalculadora : Form
    {
        double Valor1;                      //-----------Declaracion de Variables
        double Valor2;
        double Resultado;
        bool Inicio = true;
        bool Operacion = true;
        bool Igual = true;
        bool TOperacion = true;
        string TipoOperacion;
        double Memoria = 0;
        double a, b, c;


        public FrmCalculadora()
        {
            InitializeComponent();
        }
        //--------------------------------Botones Numericos
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Inicio)
            {
                TxtPrincipal.Text = "";
                TxtPrincipal.Text = "1";
                Inicio = false;
            }
            else
                TxtPrincipal.Text = TxtPrincipal.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (Inicio)
            {
                TxtPrincipal.Text = "";
                TxtPrincipal.Text = "2";
                Inicio = false;
            }
            else
                TxtPrincipal.Text = TxtPrincipal.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (Inicio)
            {
                TxtPrincipal.Text = "";
                TxtPrincipal.Text = "3";
                Inicio = false;
            }
            else
                TxtPrincipal.Text = TxtPrincipal.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (Inicio)
            {
                TxtPrincipal.Text = "";
                TxtPrincipal.Text = "4";
                Inicio = false;
            }
            else
                TxtPrincipal.Text = TxtPrincipal.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (Inicio)
            {
                TxtPrincipal.Text = "";
                TxtPrincipal.Text = "5";
                Inicio = false;
            }
            else
                TxtPrincipal.Text = TxtPrincipal.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (Inicio)
            {
                TxtPrincipal.Text = "";
                TxtPrincipal.Text = "6";
                Inicio = false;
            }
            else
                TxtPrincipal.Text = TxtPrincipal.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (Inicio)
            {
                TxtPrincipal.Text = "";
                TxtPrincipal.Text = "7";
                Inicio = false;
            }
            else
                TxtPrincipal.Text = TxtPrincipal.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (Inicio)
            {
                TxtPrincipal.Text = "";
                TxtPrincipal.Text = "8";
                Inicio = false;
            }
            else
                TxtPrincipal.Text = TxtPrincipal.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (Inicio)
            {
                TxtPrincipal.Text = "";
                TxtPrincipal.Text = "9";
                Inicio = false;
            }
            else
                TxtPrincipal.Text = TxtPrincipal.Text + "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (!Inicio)
            {
                TxtPrincipal.Text = TxtPrincipal.Text + "0";
                Inicio = false;
            }
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if (TxtPrincipal.Text.Contains(".")) { }
            else
            {
                TxtPrincipal.Text = TxtPrincipal.Text + ".";
                Inicio = false;
            }
        }
        //------------------------Botones C, CE, Retroceso, Cambio de signo y botones de Memoria
        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtPrincipal.Text = "";
            Inicio = true;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtPrincipal.Text = "0";
            TxtPrevio.Text = "";
            Inicio = true;
            Operacion = true;
            Igual = true;
            TOperacion = true;
            Valor1 = 0;
            Valor2 = 0;
            Resultado = 0;
        }

        private void BtnRetroceso_Click(object sender, EventArgs e)
        {
            if (TxtPrincipal.Text.Length > 1)
                TxtPrincipal.Text = TxtPrincipal.Text.Remove(TxtPrincipal.Text.Length - 1, 1);

            if (TxtPrincipal.Text.Length == 1)
            {
                TxtPrincipal.Text = "0";
                Inicio = true;
            }

            if (TxtPrincipal.Text == "0") { }

        }

        private void BtnSigno_Click(object sender, EventArgs e)
        {
            TxtPrincipal.Text = Convert.ToString(0 - Convert.ToDouble(TxtPrincipal.Text));
        }

        private void BtnMmenos_Click(object sender, EventArgs e)
        {
            Memoria = Memoria - Convert.ToDouble(TxtPrincipal.Text);
            this.LblMemoria.Visible = true;
        }

        private void BtnMmas_Click(object sender, EventArgs e)
        {
            Memoria = Memoria + Convert.ToDouble(TxtPrincipal.Text);
            this.LblMemoria.Visible = true;
        }

        private void BtnMS_Click(object sender, EventArgs e)
        {
            Memoria = Convert.ToDouble(TxtPrincipal.Text);
            this.LblMemoria.Visible = true;
        }

        private void BtnMR_Click(object sender, EventArgs e)
        {
            TxtPrincipal.Text = Memoria.ToString();
        }

        private void BtnMC_Click(object sender, EventArgs e)
        {
            Memoria = 0;
            this.LblMemoria.Visible = false;
        }
        //---------------------------------------Operaciones Basicas
        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Inicio = true;
            Igual = true;
            if (Operacion)
            {
                Valor1 = Convert.ToDouble(TxtPrincipal.Text);
                TxtPrevio.Text = "";
                TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text + " + ";
                Operacion = false;
            }
            else
            {
                if (TOperacion)
                {
                    Valor2 = Convert.ToDouble(TxtPrincipal.Text);
                    TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text + " + ";
                    Operaciones(Valor1, Valor2); //---------------------------Llama ala funcion Operaciones para realizar la operacion indicada
                    TOperacion = false;
                }
                else
                {
                    TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text + " + ";
                    Operaciones(Resultado, Valor2);
                    //TxtPrevio.Text = "";
                }
            }
            TipoOperacion = "+";
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            Inicio = true;
            Igual = true;
            if (Operacion)
            {
                Valor1 = Convert.ToDouble(TxtPrincipal.Text);
                TxtPrevio.Text = "";
                TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text + " - ";
                Operacion = false;
            }
            else
            {
                if (TOperacion)
                {
                    Valor2 = Convert.ToDouble(TxtPrincipal.Text);
                    TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text + " - ";
                    Operaciones(Valor1, Valor2);
                    TOperacion = false;
                }
                else
                {
                    TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text + " - ";
                    Operaciones(Resultado, Valor2);
                    //TxtPrevio.Text = "";
                }
            }
            TipoOperacion = "-";
        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            Inicio = true;
            Igual = true;
            if (Operacion)
            {
                Valor1 = Convert.ToDouble(TxtPrincipal.Text);
                TxtPrevio.Text = "";
                TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text + " * ";
                Operacion = false;
            }
            else
            {
                if (TOperacion)
                {
                    Valor2 = Convert.ToDouble(TxtPrincipal.Text);
                    TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text + " * ";
                    Operaciones(Valor1, Valor2);
                    TOperacion = false;
                }
                else
                {
                    TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text + " * ";
                    Operaciones(Resultado, Valor2);
                    //TxtPrevio.Text = "";
                }
            }
            TipoOperacion = "*";
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            Inicio = true;
            Igual = true;
            if (Operacion)
            {
                Valor1 = Convert.ToDouble(TxtPrincipal.Text);
                TxtPrevio.Text = "";
                TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text + " / ";
                Operacion = false;
            }
            else
            {
                if (TOperacion)
                {
                    Valor2 = Convert.ToDouble(TxtPrincipal.Text);
                    TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text + " / ";
                    Operaciones(Valor1, Valor2);
                    TOperacion = false;
                }
                else
                {
                    TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text + " / ";
                    Operaciones(Resultado, Valor2);
                }
            }
            TipoOperacion = "/";
        }

        private void BtnPorcentaje_Click(object sender, EventArgs e)
        {
            Valor2 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text;
            TxtPrincipal.Text = Convert.ToString((Valor1 * Valor2) / 100);
            Igual = true;
        }

        //------------------------Operaciones Cientificas

        //Realiza la operacion del boton 1/x
        private void Btn1x_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = "";
            TxtPrincipal.Text = Convert.ToString(1 / Valor1);
        }

        //Raiz Cuadrada
        private void BtnRaizCuadrada_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            if (Valor1 >= 0)
            {
                TxtPrevio.Text = "√ " + Valor1;
                TxtPrincipal.Text = Convert.ToString(Math.Sqrt(Valor1));
            }

            else
                TxtPrincipal.Text = "Error";
        }

        //Log10 de x
        private void Btnlog_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = "log( " + Valor1 + " )";
            TxtPrincipal.Text = Convert.ToString(Math.Log10(Valor1));
        }

        //Eleva a x al cuadrado
        private void BtnCuadrado_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = Valor1 + " ^ 2";
            TxtPrincipal.Text = Math.Pow(Valor1, 2).ToString();
        }

        //Eleva a x al cubo
        private void BtnCubo_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = Valor1 + " ^ 3";
            TxtPrincipal.Text = Math.Pow(Valor1, 3).ToString();
        }

        //Eleva a x a la -1
        private void BtnXmenos1_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = Valor1 + " ^ -1";
            TxtPrincipal.Text = Math.Pow(Valor1, -1).ToString();
        }

        //Eleva un numero a x Potencia
        private void BtnExponente_Click(object sender, EventArgs e)
        {
            Inicio = true;
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = Valor1 + " ^ ";
            TipoOperacion = "potencia";
            Operacion = false;
            Igual = true;

        }

        //Devuelve el valor de Pi
        private void BtnPi_Click(object sender, EventArgs e)
        {
            TxtPrevio.Text = "";
            TxtPrincipal.Text = Math.PI.ToString();
        }

        //Raiza cubica
        private void BtnRaizCubica_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            a = 1;
            b = 3;
            c = a / b;
            TxtPrincipal.Text = Math.Pow(Valor1, c).ToString();
            TxtPrevio.Text = "3√ " + Valor1;
        }

        //Raiz x de un numero
        private void BtnRaizX_Click(object sender, EventArgs e)
        {
            Inicio = true;
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = " √ " + Valor1;
            TipoOperacion = "raizX";
            Operacion = false;
            Igual = true;
        }

        //Boton EXP
        private void BtnEXP_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrincipal.Text = Convert.ToString(Math.Exp(Valor1));
        }

        //Eleva 10 a la x potencia
        private void Btn10alaX_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = "Potnecia( " + Valor1 + " )";
            TxtPrincipal.Text = Convert.ToString(Math.Pow(10, Valor1));
        }

        //Devuelve el factorial de un numero
        private void BtnFactorial_Click(object sender, EventArgs e)
        {
            a = 1;
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = Valor1 + "!";
            for (b = 1; b <= Valor1; b++)
            {
                a = a * b;
            }
            TxtPrincipal.Text = Convert.ToString(a);
        }

        //Devuelve el valor de e
        private void Btne_Click(object sender, EventArgs e)
        {
            TxtPrevio.Text = "";
            TxtPrincipal.Text = Convert.ToString(Math.E);
        }
        //Funciones Trigonometricas
        //Devuelve Sin de un numero
        private void BtnSin_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = "sin( " + Valor1 + " )";
            TxtPrincipal.Text = Convert.ToString(Math.Sin(Valor1));
        }

        //Devuelve Sin hiperbolico de un numero
        private void BtnSinh_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = "sinh( " + Valor1 + " )";
            TxtPrincipal.Text = Convert.ToString(Math.Sinh(Valor1));
        }

        //Devuelve Cos de un numero
        private void BtnCos_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = "cos( " + Valor1 + " )";
            TxtPrincipal.Text = Convert.ToString(Math.Cos(Valor1));
        }

        //Devuelve Cos hiperbolico de un numero
        private void BtnCosh_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = "cosh( " + Valor1 + " )";
            TxtPrincipal.Text = Convert.ToString(Math.Cosh(Valor1));
        }

        //Devuelve Tan de un numero
        private void BtnTan_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = "tan( " + Valor1 + " )";
            TxtPrincipal.Text = Convert.ToString(Math.Tan(Valor1));
        }

        //Devuelve Tan hiperbolico de un numero
        private void BtnTanh_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(TxtPrincipal.Text);
            TxtPrevio.Text = "tanh( " + Valor1 + " )";
            TxtPrincipal.Text = Convert.ToString(Math.Tanh(Valor1));
        }
        //-----------------------Boton de Igualdad
        private void BtnIgual_Click(object sender, EventArgs e)
        {
            Inicio = true;
            Operacion = true;

            if (Igual)
            {
                if (TipoOperacion == null) { }
                else
                {
                    Valor2 = Convert.ToDouble(TxtPrincipal.Text);
                    TxtPrevio.Text = TxtPrevio.Text + TxtPrincipal.Text;
                    Operaciones(Valor1, Valor2);
                    Igual = false;
                }
            }

            else
            {
                TxtPrevio.Text = "";
                Operaciones(Resultado, Valor2);
            }
        }
        //-------------------Funcion que realiza las operaciones
        private void Operaciones(double Valor1, double Valor2)
        {
            switch (TipoOperacion)
            {
                case "+":
                    Resultado = Valor1 + Valor2;
                    TxtPrincipal.Text = Resultado.ToString();
                    Valor1 = Convert.ToDouble(TxtPrincipal.Text);
                    break;

                case "-":
                    Resultado = Valor1 - Valor2;
                    TxtPrincipal.Text = Resultado.ToString();
                    Valor1 = Convert.ToDouble(TxtPrincipal.Text);
                    break;

                case "*":
                    Resultado = Valor1 * Valor2;
                    TxtPrincipal.Text = Resultado.ToString();
                    Valor1 = Convert.ToDouble(TxtPrincipal.Text);
                    break;

                case "/":
                    if (Valor2 == 0)
                    {

                        TxtPrincipal.Text = "Error";
                        break;
                    }
                    else
                    {
                        Resultado = Valor1 / Valor2;
                        TxtPrincipal.Text = Resultado.ToString();
                        Valor1 = Convert.ToDouble(TxtPrincipal.Text);
                        break;
                    }

                case "potencia":
                    {
                        Resultado = Math.Pow(Valor1, Valor2);
                        TxtPrincipal.Text = Resultado.ToString();
                        break;
                    }

                case "raizX":
                    {
                        if (Valor2 <= 0)
                        {
                            TxtPrincipal.Text = "Error";
                            break;
                        }
                        else
                        {
                            TxtPrevio.Text = Valor2 + " " + TxtPrevio.Text;
                            TxtPrevio.Text = TxtPrevio.Text.Remove(TxtPrevio.Text.Count() - TxtPrincipal.Text.Count());
                            double a = 1;
                            double c = a / Valor2;
                            TxtPrincipal.Text = Math.Pow(Valor1, c).ToString();
                            break;
                        }
                    }
            }
        }
        //-----------------------------Botones del Menu
        private void copiarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(TxtPrincipal.Text);
        }

        private void pegarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TxtPrincipal.Text = "";
            TxtPrincipal.Paste();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  Acercade Acercade = new Acercade();
           // Acercade.Show();
        }


        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(405, 325);
            this.panel1.Size = new System.Drawing.Size(381, 54);
            this.TxtPrevio.Size = new System.Drawing.Size(375, 22);
            this.TxtPrincipal.Size = new System.Drawing.Size(375, 22);
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(254, 325);
            this.panel1.Size = new System.Drawing.Size(235, 54);
            this.TxtPrevio.Size = new System.Drawing.Size(228, 22);
            this.TxtPrincipal.Size = new System.Drawing.Size(228, 22);
        }

        private void basicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(254, 325);
            this.panel1.Size = new System.Drawing.Size(235, 54);
            this.TxtPrevio.Size = new System.Drawing.Size(228, 22);
            this.TxtPrincipal.Size = new System.Drawing.Size(228, 22);
        }
    }
}

