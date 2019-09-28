using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo21
{
    public partial class FRMEJE : Form
    {
        public FRMEJE()
        {
            InitializeComponent();
        }
        //Declaracion global de variables
        int R, C, P;
        int[, ,] Uni;

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDCAP_Click_1(object sender, EventArgs e)
        {
            //Programa que almacena numero de estudiantes de universidad
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#21

            //Generador de numeros aleatorios
            Random aleatorio = new Random();
            //Creacion de la referencia al arreglo
            Uni = new int[6, 5, 2];

            //Entrada de numero aleatorios al arreglo tridimensional
            for (R = 0; R < 6; R++)
                for (C = 0; C < 5; C++)
                    for (P = 0; P < 2; P++)
                    {
                        Uni[R, C, P] = aleatorio.Next(100);
                    }
            LBLCAP.Text = "Datos Capturados";
            CMDDES.Enabled = true;
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            //Limpia cajas de texto y desactiva boton
            TXTFEM.Clear();
            TXTMASC.Clear();
            CMDDES.Enabled = false;

        }

        private void CMDDES_Click(object sender, EventArgs e)
        {
            //Salida de numero de estudiantes del arreglo tridimensional de mujeres
            LBLCAP.Text = "";

            for (R = 0; R < 6; R++)
            {
                for (C = 0; C < 5; C++)
                {
                    TXTFEM.Text = TXTFEM.Text + Uni[R, C, 0] + "\t";

                }
                TXTFEM.Text = TXTFEM.Text + "\r\n";

            }
            //Salida de numero de estudiantes del arreglo tridimensional de hombres
            for (R = 0; R < 6; R++)
            {
                for (C = 0; C < 5; C++)
                {
                    TXTMASC.Text = TXTMASC.Text + Uni[R, C, 1] + "\t";

                }
                TXTMASC.Text = TXTMASC.Text + "\r\n";

            }


        }
    }
}

