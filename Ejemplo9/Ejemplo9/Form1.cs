using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo9
{
    public partial class FRMEJEMPLO9 : Form
    {
        public FRMEJEMPLO9()
        {
            InitializeComponent();
        }

        private void FRMEJEMPLO9_Load(object sender, EventArgs e)
        {

        }

        private void CMDCAl_Click(object sender, EventArgs e)
        {
            //Programa que asigne valor numerico a las calificaciones
            //dadas en literal. A=10, M=9, B=8, R=7, S=6, N=5
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#9

            //Declaracion de variables
            int CN;
            char CL;

            //Asignacion de valor
            CL = System.Char.Parse(TXTCAL.Text);
            CN = 0;
            
            //Seleccion multiple
            switch(CL)
            {
                case 'A':
                    CN = 10;
                    break;
                case 'M':
                    CN = 9;
                    break;
                case 'B':
                    CN = 8;
                    break;
                case 'R':
                    CN = 7;
                    break;
                case 'S':
                    CN = 6;
                    break;
                case 'N':
                    CN = 5;
                    break;
                default:
                    LBLCAL1.Text = "No valida";
                    break;






            }
            LBLCAL1.Text = CN.ToString();

        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTCAL.Clear();
            LBLCAL1.Text = "";
            TXTCAL.Focus();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
