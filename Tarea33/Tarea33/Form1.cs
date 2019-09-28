using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea33
{
    public partial class FRMNUMERO : Form
    {
        public FRMNUMERO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Programa que da entrada a 15 numeros y determina cual es el mayor 
            //Silva Reyes Luis Adrian 19210549
            //Tarea#33

            //Declaracion de variables
            int Num ;
            int C = 0;
            int May = 0;

            //Generador de aleatorio enteros
            Random aleatorio = new Random();


            //While
            while (C<15)
            {

                C = C+1;
                Num = aleatorio.Next(15);

                if (May<Num)
                    {
                    May = Num;
                }

                //Salida 
                TXTNUM1.Text = TXTNUM1.Text +Num+"\t";

            }
            TXTNUM.Text = "El numero mayor es:" + May;
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            
            TXTNUM1.Clear();
            TXTNUM.Clear();
           
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TXTNUM1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
