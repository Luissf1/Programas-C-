using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea35
{
    public partial class FRMFIB : Form
    {
        public FRMFIB()
        {
            InitializeComponent();
        }

        private void CMDFIB_Click(object sender, EventArgs e)
        {
            //Programa que calcula el fib de numero ingresado 
            //Silva Reyes Luis Adrian 19210549
            //Tarea#35

            //Declaracion de variables
            int A=0 ;
            int B= 1;
            int FIB ;
            int N ;
            int C = 2;

            //Asignacion de variable
            N = System.Int32.Parse(TXTNUM.Text);

            //Condicion
            if (N == 0)
            {
                TXTFIB.Text = "Fib=" + A;

            }
            else if (N == 1)
            {
                TXTFIB.Text = "Fib=" + A + "+" + B;
            }
            else
            {


                //While
                while (C <= N)
                {
                    
                    FIB = A + B;
                    TXTFIB.Text = TXTFIB.Text + "Fib=" + A + "+" + B +"\r\n";
                    A = B;
                    B = C;
                    C++;

                }
            }

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTFIB.Clear();
            TXTNUM.Clear();
            TXTNUM.Focus();
        }
    }
}
