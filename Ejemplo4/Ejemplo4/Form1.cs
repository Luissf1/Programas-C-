using System;
using System.Windows.Forms;

namespace Ejemplo4
{
    public partial class FRMEJEMPLO : Form
    {
        public FRMEJEMPLO()
        {
            InitializeComponent();
        }

        //Declaracion de variables globales
        int N1, N2;

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void CMDSUMA_Click(object sender, EventArgs e)
        {
            //Programa que realiza suma por medio de funcion
            //Silva Reyes Luis ADrian 19210549
            //Ejemplo#4

            //Declaracion de variables locales
            int Res;

            //Asignacion de valores
            N1 = System.Int32.Parse(TXTNUM1.Text);
            N2 = System.Int32.Parse(TXTNUM2.Text);

            //llamada a la funcion Suma ()
            Res = Suma();

            //Salida de dato
            TXTSUMA.Text = Res.ToString();
        }


        //Subprograma (funcion sin recibir parametros)definido por el programador int Suma()
        int Suma()
        {


            //Calculo de suma

            return N1 + N2;

        }

    }
}


