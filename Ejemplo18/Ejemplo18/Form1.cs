using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo18
{
    public partial class FRMEJE : Form
    {
        public FRMEJE()
        {
            InitializeComponent();
        }

        private void CMDCAPTURA_Click(object sender, EventArgs e)
        {
            //Programa que utiliza arrelgo para nombres
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#18

            //Declaracion de variables
            int R;

            //Inicializacion del vector
            string[] Nom =new string[5] { "Ana", "Jaime", "Erika", "Eduardo", "Elena" };

            //Desplegado del vector
            for(R=0;R<5;R++)
            {
                TXTNUM.Text = TXTNUM.Text + Nom[R] + "\r\n";
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
