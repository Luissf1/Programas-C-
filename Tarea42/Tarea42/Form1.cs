using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea42
{
    public partial class FRMCAL : Form
    {
        public FRMCAL()
        {
            InitializeComponent();
        }

        private void CMDCAP_Click(object sender, EventArgs e)
        {

            //Programa que almacena calificaciones de estudiantes 
            //Silva Reyes Luis Adrian 19210549
            //Tarea#42

            //Declaracion de variables\
            int[] NC;
            NC = new int[5];
            string[] Nom;
            Nom = new string[5];
            int[] C1;
            C1 = new int[5];
            int[] C2;
            C2 = new int[5];
            int[] Prom;
            Prom = new int[5];
            int Promg, C, A = 0;

            //Generador de aleatorio enteros
            Random aleatorio = new Random();

            //Crea un objeto de la clase FRMSEGUNDA
            FRMSEGUNDA FormaCaptura = new FRMSEGUNDA();

            //Desactivar boton de captura 
            CMDCAP.Enabled = false;

           
                for (C = 0; C < 5; C++)
                if (FormaCaptura.ShowDialog() == DialogResult.OK)
                {
                    {
                    NC[C] = Convert.ToInt32(FormaCaptura.TXTNC.Text);
                    FormaCaptura.TXTNC.Text = NC[C].ToString();

                    Nom[C] = FormaCaptura.TXTNO.Text;


                    C1[C] = aleatorio.Next(50,100);
                    C2[C] = aleatorio.Next(50,100);

                        Prom[C] = (C1[C] + C2[C]) / 2;



                        TXTFEM.Text = TXTFEM.Text + NC[C].ToString() + "\r\t" + Nom[C].ToString() + "\r\t" + C1[C].ToString() + "\r\t" + C2[C].ToString() + "\r\t"  ;


                        TXTPROM.Text=TXTPROM.Text+ Prom[C].ToString()+"\r\n";

                        A = A + Prom[C];

                        Prom[C] = 0;

                    }
            }
            //Salida de promedio general
            Promg = A / 5;
            TXTPROG.Text=Promg.ToString();
            
        }
        


        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            //Limpia cajas de texto y desactiva boton
            TXTFEM.Clear();
            TXTPROG.Clear();
            TXTFEM.Focus();
            

        }

        private void CMDOTRO_Click_1(object sender, EventArgs e)
        {
            TXTFEM.Clear();
            TXTPROM.Clear();
            TXTPROG.Clear();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

