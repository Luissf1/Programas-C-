using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo17
{
    public partial class FRMEJE : Form
    {
        public FRMEJE()
        {
            InitializeComponent();
        }

        private void CMDDESPLIEGUE_Click(object sender, EventArgs e)
        {
            //Programa que imprime los numeros pares entre 1 y 40
            //utilizando ciclo for
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#17

            //Declaracion de variables
            int C;
            //Despliegue de resultados 
            for (C = 2; C <= 40; C = C + 2)
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
