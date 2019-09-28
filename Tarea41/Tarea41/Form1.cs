using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea41
{
    public partial class FRMNUM : Form
    {
        public FRMNUM()
        {
            InitializeComponent();
        }

        private void CMDCAPTURA_Click(object sender, EventArgs e)
        {

            //Programa que ingresa diez numero y los invierte
            //Silva Reyes Luis Adrian 19210549
            //Tarea#41

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
                TXNUM.Text =TXNUM.Text + N[R].ToString() + "\t";
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
            for (R = 0; R < 10; R++)
            {
                TXTORD.Text=TXTORD.Text + N[R].ToString() + "\t";
            }

        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTORD.Clear();
            TXNUM.Clear();
            TXNUM.Focus();

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

    

