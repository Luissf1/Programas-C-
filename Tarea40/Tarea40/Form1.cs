using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea40
{
    public partial class FRMMED : Form
    {
        public FRMMED()
        {
            InitializeComponent();
        }

        public object TXTNUM { get; private set; }

        private void CMDMED_Click(object sender, EventArgs e)
        {
            
                //Programa que ingresa 20 numeros y obtiene la mediana
                //Silva Reyes Luis Adrian 19210549
                //Tarea#40

                //Declaracion de variables
                int C=0, Med;
                int A, B ;
                int Temp;
                int[] Num;
                Num= new int[20];


            //Generador de aleatorio enteros
            Random aleatorio = new Random();
            

            //Despliegue de resultado
            for (C = 1; C < 20; C = C + 1)
                {
                //Asignacion de variables
                Num[C] = aleatorio.Next(100);
                TXTN.Text = TXTN.Text + Num[C] + "\t";
             
            }
            for (A = 1; A <20; A = A + 1)
            {
               

                    for (B = 1; B < 20; B = B + 1)
                    {
                        if (Num[B - 1] > Num[B])
                        {
                            Temp = Num[B - 1];
                            Num[B - 1] = Num[B];
                            Num[B] = Temp;


                        }

                    
                }


            }

            //Mediana
            Med = ((Num[10]) + (Num[11])) / 2;

            //Salida
            TXTMED.Text ="La mediana es:"+ Med.ToString();



        }

        private void FRMMED_Load(object sender, EventArgs e)
        {

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTMED.Clear();
            TXTN.Clear();
            TXTMED.Focus();
        }
    }
}
