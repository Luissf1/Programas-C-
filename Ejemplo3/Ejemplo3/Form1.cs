using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3
{
    public partial class FRMSUMA : Form
    {
        public FRMSUMA()
        {
            InitializeComponent();
        }

        private void CMDSUMA_Click(object sender, EventArgs e)
        {
            //Programa para sumar dos numeros
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo 3

            //Declarcion de Variables
            int N1, N2, Res;

            //Asignacion de valores
            N1 = System.Int32.Parse(TXTNUM1.Text);
            N2 = System.Int32.Parse(TXTNUM2.Text);

            //llamada ala funcion y asignacion 
            //Del valor de retorno

            Res = Suma(N1,N2);


            //Salida de suma
            TXTSUMA.Text = Res.ToString();
        }

        private int Suma(int n1, int n2)
        {
          

            return n1 + n2;
        }

        

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
