using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea44
{
    public partial class FRMCAL : Form
    {
        public FRMCAL()
        {
            InitializeComponent();
        }

        private void CMDCAP_Click(object sender, EventArgs e)
        {
            //Programa que da entrada a calificaciones de alumnos por medio de arreglo
            //Silva Reyes Luis Adrian 19210549
            //Tarea#44

            //Declaracion de variables
            int[] NC;
            NC = new int[5];
            string[] Nom;
            Nom = new string[5];
            int[,] Par;
            Par = new int[5,3];
            int[] Promf;
            Promf = new int[5];
            int R = 0, C = 0, A = 0;

            //Generador de numeros aleatorios
            Random aleatorio = new Random();

            //Crea un objeto de la clase FRMSEGUNDA
            FRMSEGUNDA FormaCaptura = new FRMSEGUNDA();

            //Desactivar boton de captura 
            CMDCAP.Enabled = false;

           

                //Entrada de numero aleatorios al arreglo tridimensional
                for (R = 0; R <= 5; R++)
                {
                    if (FormaCaptura.ShowDialog() == DialogResult.OK)
                    {
                        NC[R] = Convert.ToInt32(FormaCaptura.TXTNC.Text);
                        FormaCaptura.TXTNC.Text = NC[R].ToString();


                        Nom[R] = FormaCaptura.TXTNOM.Text;


                        TXTNUM.Text = TXTNUM.Text + NC[R] + "\t\n";
                        TXTNUM.Text = TXTNUM.Text + Nom[R] + "\t\n";

                        for (C = 0; C < 3; C++)
                        {
                            Par[R, C] = aleatorio.Next(100);
                            A = A + Par[R, C];
                            TXTNUM.Text = TXTNUM.Text + Par[R, C] + "\t\n";

                        }
                        Promf[R] = A / 3;
                        TXTPROM.Text=TXTPROM.Text+ Promf[R] + "\r\n";
                    }
                }


                
                
                

            

           
                    
            

        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNUM.Clear();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
