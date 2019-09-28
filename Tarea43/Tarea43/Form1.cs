using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea43
{
    public partial class FRMDIAG : Form
    {
        public FRMDIAG()
        {
            InitializeComponent();
        }
         
        private void CMDCAP_Click(object sender, EventArgs e)
        {
            {

                //Programa que almacena numeros en un 4x4 y da salida diagonalmente y punto especifico 
                //Silva Reyes Luis Adrian 19210549
                //Tarea#43

                //Declaracion de variables\
                int[,] Num;
                Num = new int[4,4];
              
                int R,C;


                //Generador de aleatorio enteros
                Random aleatorio = new Random();


                //Entrada de numero aleatorios al arreglo tridimensional
                for (R = 0; R < 4; R++)

                {
                    for (C = 0; C < 4; C++)

                    {

                        


                        //Salida de diagonal
                        if (R == C)
                        {
                            Num[R, C] = aleatorio.Next(0, 100);
                            
                        }
                        else
                        {
                            Num[R, C] = 0;
                        }

                        TXTNUM.Text = TXTNUM.Text + Num[R, C] + "\t\n";
                        //Salida de (2,3)
                        if (R == 2 && C == 3)
                        {

                            TXTPROG.Text = "Numero:" + Num[R, C];
                        }
                    }
                }

                

                
                

            }
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNUM.Clear();
            TXTPROG.Clear();
            TXTNUM.Focus();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
