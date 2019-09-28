using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo9B
{
    public partial class FRMEJEMPLO9B : Form
    {
        public FRMEJEMPLO9B()
        {
            InitializeComponent();
        }

        private void CMDCAl_Click(object sender, EventArgs e)
        {
            //Programa que asigne el valor numerico a las calificaciones dadas
            //en literal.
            //Excelente =10, Muy bien =9, Bien =8, Regular =7, Suficiente =6 y No 
            //Acreditado=5
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#9B

            //Declaracion de variables
            int CN;
            string CL;

            //Asignacion de valor
            CL = TXTCAL.Text;
            CN = 0;

            //Seleccion multiple
            switch (CL)
            {
                case "Excelente":
                    CN = 10;
                    break;
                case "Muy bien":
                    CN = 9;
                    break;
                case "Bien":
                    CN = 8;
                    break;
                case "Regular":
                    CN = 7;
                    break;
                case "Suficiente":
                    CN = 6;
                    break;
                case "No acreditado":
                    CN = 5;
                    break;
                default:
                    LBLERROR.Text = "No valida";
                    break;






            }
            LBLCAL1.Text = CN.ToString();

        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            LBLCAL1.Text = "";
            LBLERROR.Text = "";
            TXTCAL.Clear();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
