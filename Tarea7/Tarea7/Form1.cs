using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea7
{
    public partial class FRMCELCIUS : Form
    {
        public FRMCELCIUS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void CMDCONVERSION_Click(object sender, EventArgs e)
        {
            //Programa Para convertir fahrenheit a celcius
            //Silva Reyes Luis Adrian 19210549
            //Tarea#7

            //Declaracion de variables
            double Fahrenheit, Celcius;

            //Asignacion de valores
            Fahrenheit = System.Double.Parse(TXTF.Text);

            //Calculo de celcius
            Celcius = (Fahrenheit - 32) * (5 / 9);

            //Salida de Celcius
            TXTC.Text = Celcius.ToString();
        }   

        

    }
}
