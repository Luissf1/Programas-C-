using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea31
{
    public partial class FRMEDAD : Form
    {
        public FRMEDAD()
        {
            InitializeComponent();
        }

        private void CMDCAPTURA_Click(object sender, EventArgs e)
        {
            //Programa que captura edades y imprime si es mayor o menor
            //Silva Reyes Luis Adrian 19210549
            //Tarea#31

            //Declaracion de variables
            int C = 0;
            int Edad;
            
           

            //Segunda forma
            FRMSEGUNDA Formacaptura = new FRMSEGUNDA();

            //Desactivar boton de captura
            CMDCAPTURA.Enabled = false;

            //Ciclo do while
            do
            {
              if(Formacaptura.ShowDialog()== DialogResult.OK)
                {
                    C = C + 1;

                    Edad = Convert.ToInt32(Formacaptura.TXTEDAD2.Text);
                    Formacaptura.TXTEDAD2.Text = Edad.ToString();

                    
                    if (Edad <= 18)
                    {

                        TXTEDAD.Text = TXTEDAD.Text + " El numero es menor " + Edad + "\r\n";
                    }

                    else
                    {
                        TXTEDAD.Text = TXTEDAD.Text + " El numero es mayor " + Edad + "\r\n";
                    }


                }
            } while (C <= 10);
           


        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTEDAD.Clear();
            TXTEDAD.Focus();

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
