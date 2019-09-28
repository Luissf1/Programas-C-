using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea39
{
    public partial class FRMMAY : Form
    {
        public FRMMAY()
        {
            InitializeComponent();
        }

        private void FRMMAY_Load(object sender, EventArgs e)
        {

        }

        private void CMDCAPTURA_Click(object sender, EventArgs e)
        {
            //Programa que captura 15 numeros y decide mayor de los 15
            //Silva Reyes Luis Adrian 19210549
            //Tarea#39

            //Declaracion de variables
            int R, Nmar=0;

            int[] Nom = new int[15];


            //Generador de numeros aleatorios
            Random aleatorio = new Random();
            

            //Ciclo for
            for (R=1;R<15;R++)
            {

                Nom[R] = aleatorio.Next(100);

                TXTNUM.Text = TXTNUM.Text + Nom[R] + "\t";
                    if(Nmar<Nom[R])
                    {
                        Nmar = Nom[R];
                    }
                
                
                
            }
            TXTMAY.Text = "El numero mayor es:" + Nmar;
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTMAY.Clear();
            TXTNUM.Clear();
            TXTNUM.Focus();
        }
    }
}
