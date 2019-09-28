using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea26
{
    public partial class FRMDIA : Form
    {
        public FRMDIA()
        {
            InitializeComponent();
        }

        private void CMDDIA_Click(object sender, EventArgs e)
        {
            //Programa de dia con selleccion multiple
            //Silva Reyes Luis Adrian 19210549
            //Tarea#26

            //Declaracion de variables
            Byte Num;
            String Dia;

            //Asignacion de valores
            Num = System.Byte.Parse(TXTDIA.Text);
            Dia = "";

            //seleccion multiple
            switch(Num)
            {
                case 1:
                    Dia= "Domingo";
                    break;
                case 2:
                    Dia= "Lunes";
                    break;
                case 3:
                    Dia = "Martes";
                    break;
                case 4:
                    Dia = "Miercoles";
                    break;
                case 5:
                    Dia = "Jueves";
                    break;
                case 6:
                    Dia = "Viernes";
                    break;
                case 7:
                    Dia = "Sabado";
                    break;
                default:
                    LBLDIA2.Text = "Dia no valido";
                    break;


            }
            LBLDIA2.Text = Dia.ToString();
        }

        private void CMDCLEAR_Click(object sender, EventArgs e)
        {
            TXTDIA.Clear();
            LBLDIA2.Text = "";
            TXTDIA.Focus();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
