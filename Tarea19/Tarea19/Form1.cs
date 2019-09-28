using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea19
{
    public partial class FRMNUMPAR : Form
    {
        public FRMNUMPAR()
        {
            InitializeComponent();
        }

        private void CMDPAR_Click(object sender, EventArgs e)
        {
            //Programa que calcula si numero es par o impar
            //Silva Reyes Luis Adrian 19210549
            //Tarea#19

            //Declaracion de variables
            float Numero;

            //Asignacion de valor
            Numero = System.Single.Parse(TXTNUM.Text);

           //Condicion
           if((Numero%2)==0)
            {
                {
                    LBLPAROIMPAR.Text = "Numero par";
                        }
            }
           else
            {
                {
                    LBLPAROIMPAR.Text = "Numero impar";
                        }
            }

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNUM.Clear();
            LBLPAROIMPAR.Text = "";

        }
    }
}
