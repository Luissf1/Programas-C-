using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea28
{
    public partial class FRMPAR : Form
    {
        public FRMPAR()
        {
            InitializeComponent();
        }

        private void CMDLISTA_Click(object sender, EventArgs e)
        {
            //Programa que muestra los numeros pares entre 200 y 300
            //Silva Reyes Luis Adrian 19210549 
            //Tarea#28

            //Declaracion de variables
            int Num = 198;
            
            int A = 198;

            //Do while
            do
            {
                Num = Num + 2;
                TXTPAR.Text = TXTPAR.Text + Num.ToString()+"\t";
                A = A +Num;
            } while (Num <= 300);

            //Salida de suma
            TXTSUMA.Text = TXTSUMA.Text + A.ToString();
            
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTPAR.Clear();
            TXTSUMA.Clear();

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
