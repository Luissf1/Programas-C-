using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea20
{
    public partial class FRMMAYOROMENOR : Form
    {
        public FRMMAYOROMENOR()
        {
            InitializeComponent();
        }

        private void CMDMAYOR_Click(object sender, EventArgs e)
        {
            //Programa que calcula que numero es mayor
            //Silva Reyes Luis Adrian 19210549
            //Tarea#20

            //Declaracion de variables
            float Numero1, Numero2;

            //Asignacion de valores
            Numero1 = System.Single.Parse(TXTNUM.Text);
            Numero2 = System.Single.Parse(TXTNUM2.Text);

            //Condicion
            if (Numero1 > Numero2)
            {
                {
                    LBLMAYOR.Text = "El numero mayor es :" +Numero1.ToString();
            }
            }
            else
            {
                { LBLMAYOR.Text = "El numero mayor es:"+Numero2.ToString(); }
            }
        
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNUM.Clear();
            TXTNUM2.Clear();
            LBLMAYOR.Text = "";
            TXTNUM.Focus();
        }
    }
}
