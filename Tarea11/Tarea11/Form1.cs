using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea11
{
    public partial class FRMTIEMPO : Form
    {
        public FRMTIEMPO()
        {
            InitializeComponent();
        }

        private void CMDTIEMPO_Click(object sender, EventArgs e)
        {
            //Programa para calcular el tiempo que tardara floripondio
            //Silva Reyes Luis Adrian 19210549
            //Tarea#11

            //Asignacion de variables
            double Velocidad,Velocidad_Luz,Distancia,Tiempo1,Tiempo2,TiempoTotal;

            //Asignacion de Variables
            Velocidad_Luz = 300000;
            Distancia = 4500000;

           
            //Calculo de tardancia
            Velocidad = Velocidad_Luz * (9 / 10);
            Tiempo1 = Distancia / Velocidad_Luz;
            Tiempo2 = Distancia / Velocidad;
            TiempoTotal = Tiempo1 + Tiempo2 + 5;

            //Salida de tardancia
            TXTTIEMPO.Text = TiempoTotal.ToString();

            
     
            



            

      
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
