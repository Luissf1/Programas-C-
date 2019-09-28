using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea15
{
    public partial class FRMAREA : Form
    {
        public FRMAREA()
        {
            InitializeComponent();
        }

        private void CMDAREA_Click(object sender, EventArgs e)
        {
            //programa que calcula area de triangulo por medio de funcion
            //Silva Reyes Luis Adrian 19210549
            //Tarea#15

            //Declaracion de variables
            float b, h, res;

            //asignacion de variables
            b = System.Single.Parse(TXTBASE.Text);
            h = System.Single.Parse(TXTALTURA.Text);

            //llamada a funcion 
            res = Proceso(b, h);

            //Salida de datos
            TXTAREA.Text = res.ToString();
        }

        float Proceso(float b1, float h1)
        {
            return (b1 * h1 )/ 2;
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTBASE.Clear();
            TXTALTURA.Clear();
            TXTAREA.Clear();
            TXTBASE.Focus();


            
        }
    }
}
