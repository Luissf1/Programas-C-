using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo19
{
    public partial class FRMEJE : Form
    {
        public FRMEJE()
        {
            InitializeComponent();
        }

        private void FRMEJE_Load(object sender, EventArgs e)
        {

        }

        private void CMDNUM_Click(object sender, EventArgs e)
        {
            //Programa que ordena numeros 
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#19

            //Declaracion devariables
            int R, A, B, TEMP;
            int cont = 10;
            int[] N;

            //Generador de aleatorio enteros
            Random aleatorio = new Random();

            //Creacion de la referencia al arreglo
            N = new int[10];
            //Entrada de numero aleatorios al vector y despegado
            for (R = 0; R < 10; R++)
            {
                N[R] = aleatorio.Next(100);
                TXTNUM1.Text = TXTNUM1.Text + N[R].ToString() + "\r\n";
            }
            //Ordenamiento de burbuja 
            for (A = 1; A < cont; ++A)
                for (B = cont - 1; B >= A; --B)
                    if (N[B - 1] > N[B])
                    {
                        TEMP = N[B - 1];
                        N[B - 1] = N[B];
                        N[B] = TEMP;
                    }
            //Desplegado del vector ordenado
            for(R=0;R<10;R++)
            {
                TXTNum2.Text = TXTNum2.Text + N[R].ToString() + "\r\n";
            }

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNUM1.Clear();
            TXTNum2.Clear();
            TXTNUM1.Focus();

        }
    }
}
