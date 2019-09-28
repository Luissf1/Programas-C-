using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea23
{
    public partial class FRMTIEMPO : Form
    {
        public FRMTIEMPO()
        {
            InitializeComponent();
        }

        private void CMDTIEMPO_Click(object sender, EventArgs e)
        {
            //Programa que pide tres teimpos para saber si su tiempo es seleccionado
            //Silva Reyes Luis Adrian 19210549
            //Tarea#23

            //Declaracion de variables
            double P1, P2, P3, TP;

            //Asignacion de valores
            P1 = System.Double.Parse(TXTP1.Text);
            P2 = System.Double.Parse(TXTP2.Text);
            P3 = System.Double.Parse(TXTP3.Text);

            //Calculo
            TP = (P1 + P2 + P3) / 3;

            //condicion
            if (TP >= 25 && TP <= 35)
            { LBLDESPLIEGUE.Text = "Seleccionado"; }
            else
            {
                LBLDESPLIEGUE.Text = "No seleccionado";
            }

        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTP1.Clear();
            TXTP2.Clear();
            TXTP3.Clear();
            LBLDESPLIEGUE.Text = "";
            TXTP1.Focus();


        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
