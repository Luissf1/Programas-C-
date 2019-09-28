using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class FRMVEL : Form
    {
        public FRMVEL()
        {
            InitializeComponent();
        }

        private void CMDVELOCIDAD_Click(object sender, EventArgs e)
        {
            //Programa para calcular la velocidad
            //Silva Reyes Luis Adrian 19210549
            //Tarea#1

            //Declarcion de variables 
            float Distancia, Tiempo, Velocidad;

            //Asignacion de valores
            Distancia = System.Single.Parse(TXTDISTANCIA.Text);
            Tiempo = System.Single.Parse(TXTTIEMPO.Text);

            //Calculo de velocidad
            Velocidad = Distancia / Tiempo;

            //Salida de Velocidad
            TXTVELOCIDAD.Text = Velocidad.ToString();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
