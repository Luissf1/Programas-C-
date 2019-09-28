using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea37
{
    public partial class FRMPAR : Form
    {
        public FRMPAR()
        {
            InitializeComponent();
        }

        private void CMDPAR_Click(object sender, EventArgs e)
        {
             //Programa que captura 10 numeros y menciona los pares,su suma y media
            //Silva Reyes Luis Adrian 19210549
            //Tarea#37

            //Declaracion de variables
            int C, Med, Par,Par1=0;
            int Num;
            int Suma=0;

            //Generador de numeros aleatorios
            Random aleatorio = new Random();



            //Despliegue de resultados
            for (C = 1; C <= 10; C ++)
            {
                
                    Num =aleatorio.Next(100);

                //Par
               Par = Num % 2;

                    if (Par==0)
                        {
                        
                        TXTPAR.Text = TXTPAR.Text + "Numero es par:"+ Num + "\r\n";
                        Par1 = Par1 + 1;
                        Suma = Suma + Num;

                    
                                      
                }
                    else
                {
                    TXTPAR.Text = TXTPAR.Text + "Numero es impar:" + Num + "\r\n";
                }
             
           
            }
            //Media
            Med = Suma / 10;

            //Salida de datos
            TXTSUMA.Text = "La suma es:"+Suma.ToString();
            TXTPAR1.Text = "Los numeros pares son:" + Par1.ToString();
            TXTMED.Text = "La media es:"+ Med.ToString();


        }

        private void TXTPAR1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CMOTRO_Click(object sender, EventArgs e)
        {
            TXTMED.Clear();
            TXTPAR.Clear();
            TXTSUMA.Clear();
            TXTPAR1.Clear();
            TXTPAR.Focus();


        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
