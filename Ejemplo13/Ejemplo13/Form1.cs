using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo13
{
    public partial class FRMEJEMPLO : Form
    {
        public FRMEJEMPLO()
        {
            InitializeComponent();
        }

        private void CMDDESPLIEGUE_Click(object sender, EventArgs e)
        {
            //Program que imprime del 1 a 10
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#13

            //Declaracion de variables
            int C = 0;

            //Despliegue de resultado
            do
            {
                C = C + 1;
                TXTNUM.Text = TXTNUM.Text + C.ToString() ;
            } while (C < 10);
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

        private void FRMEJEMPLO_Load(object sender, EventArgs e)
        {

        }
    }
}
