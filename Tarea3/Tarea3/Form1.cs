using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3
{
    public partial class FRMTIEMPO : Form
    {
        public FRMTIEMPO()
        {
            InitializeComponent();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDTIEMPO_Click(object sender, EventArgs e)
        {
            //Programa que calcula el tiempo
            //Silva Reyes Luis Adrian
            //Tarea#3

            //Declaracion de variables
            double Tiempo,Conversion;

            //Conversion de 80 km a millas
            Conversion = 80 * 0.62;
            //Calculo de tiempo
            Tiempo = Conversion / 60;

            //Salida de Tiempo
            TXTTIEMPO.Text = Tiempo.ToString();

            
        }
    }
}
