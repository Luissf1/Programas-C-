using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea21
{
    public partial class FRMPOSITIVO : Form
    {
        public FRMPOSITIVO()
        {
            InitializeComponent();
        }

        private void FRMPOSITIVO_Load(object sender, EventArgs e)
        {

        }

        private void CMDNUM_Click(object sender, EventArgs e)
        {
        //Programa que decide si numero es positivo o negativo
        //Silva Reyes Luis Adrian 19210549
        //Tarea#21

        //Declaracion de variables
        float Num;

        //Asignacion de variables
        Num = System.Single.Parse(TXTNUM.Text);

            //Condicion
            if (Num == 0)
            {
                LBLPOSNEG.Text = "Es igual a cero: " + Num.ToString();
            }
            else
            {
                if(Num>0)
                { LBLPOSNEG.Text = "El numero es positivo : " + Num.ToString();
                }
                else
                { LBLPOSNEG.Text = "El numero es negativo : " + Num.ToString(); }
            }


        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            LBLPOSNEG.Text = "";
            TXTNUM.Clear();
            TXTNUM.Focus();
        }
    }
}
