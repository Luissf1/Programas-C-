using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo16
{
    public partial class FRMEJEMPLO : Form
    {
        public FRMEJEMPLO()
        {
            InitializeComponent();
        }

        private void CMDDESPLIEGUE_Click(object sender, EventArgs e)
        {
            //Programa que imprime los numeros del 1 a 10
            //Utilizando el ciclo for
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#16

            //Declaracion de variables
            int C;

            //Despliegue de resultados
            for(C=1; C<=10; C=C+1)
            {
                TXTNUM.Text = TXTNUM.Text + C.ToString() + "\r\n";
            }
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNUM.Clear();
            TXTNUM.Focus();
        }
    }
}
