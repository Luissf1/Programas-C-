using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea22
{
    public partial class FRMSEMANA : Form
    {
        public FRMSEMANA()
        {
            InitializeComponent();
        }

        private void CMDDIA_Click(object sender, EventArgs e)
        {
            //programa que al ingresar numero te dira el dia
            //Silva Reyes Luis Adrian 19210549
            //Tarea#22

            //Declaracion de variables
            byte Num;

            //Asignacion de valor
            Num = System.Byte.Parse(TXTDIA.Text);

            //condicion
            if (Num== 1)
            {
                LBLDIA1.Text = "Domingo";
            }
            else
                 if (Num == 2)
            {
                LBLDIA1.Text = "Lunes";
            }
            else
                 if (Num == 3)
            {
                LBLDIA1.Text = "Martes";
            }
            else
                 if (Num == 4)
            {
                LBLDIA1.Text = "Miercoles";
            }
            if (Num == 5)
            {
                LBLDIA1.Text = "Jueves";
            }
            if (Num == 6)
            {
                LBLDIA1.Text = "Viernes";
            }
            if (Num == 7)
            {
                LBLDIA1.Text = "Sabado";
            }
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDCLEAR_Click(object sender, EventArgs e)
        {
            TXTDIA.Clear();
            LBLDIA1.Text = "";
        }
    }
}
