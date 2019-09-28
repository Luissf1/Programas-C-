using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea38
{
    public partial class FRMCAL : Form
    {
        public FRMCAL()
        {
            InitializeComponent();
        }

        private void CMDCAL_Click(object sender, EventArgs e)
        {
            //Programaque ingresa calificaciones ,saca la media y la menor
            //Silva Reyes Luis Adrian 19210549
            //Tarea#38

            //Declaracion de variables
            int C, Cal, Med;
            int Suma=0;
            int Menor=0;

            //Generador de aleatorio enteros
            Random aleatorio = new Random();
            

            //Despliegue de resultado
            for (C = 1; C <= 40; C = C + 1)
            {
                //Asignacion de variables
                Cal = aleatorio.Next(100);
                //Calculo
                Suma = Suma + Cal;

                if(Menor<Cal)
                {
                    Menor = Cal;

                }
                TXTNUM1.Text = TXTNUM1.Text + Cal.ToString() + "\t";
            }

            //Media
            Med = Suma / 40;
            //Salida
            
            TXTMED.Text = "La media es: " + Med;
            TXTMENOR.Text = "El numero menor es:" + Menor;

        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTMED.Clear();
            TXTMENOR.Clear();
            TXTNUM1.Clear();
            TXTNUM1.Focus();
            
                
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
