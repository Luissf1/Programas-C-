using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea24
{
    public partial class FRMEDAD : Form
    {
        public FRMEDAD()
        {
            InitializeComponent();
        }

        private void CMDEDAD_Click(object sender, EventArgs e)
        {
            //Programa que clasifica para un maraton
            //Silva Reyes Luis Adrian 19210549
            //Tarea#24

            //Declaracion de variables
            Byte Edad;

            //Asignacion de valores
            Edad = System.Byte.Parse(TXTEDAD.Text);

            //Condicion
            if (Edad >= 15 && Edad <= 20)
            { LBLDESPLIEGUE.Text = "Su clasificacion es A";
        }
            else if (Edad >= 21 && Edad <= 25)
            {
                LBLDESPLIEGUE.Text = "Su clasificacion es B";
            }
            else if(Edad >=26 && Edad<= 45)
            {
                LBLDESPLIEGUE.Text = "Su clasificacion es C";

            }
            else
            { LBLDESPLIEGUE.Text = "No clasdifica";
            }


        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTEDAD.Clear();
            LBLDESPLIEGUE.Text = "";
            TXTEDAD.Focus();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
