using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4
{
    public partial class FRMNOM : Form
    {
        public FRMNOM()
        {
            InitializeComponent();
        }

        private void TXTNOM_TextChanged(object sender, EventArgs e)
        {
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDNOM_Click(object sender, EventArgs e)
        {
            //Programa para entrada y salida de nombre de cuidad
            //Silva Reyes Luis Adrian 19210549
            //Tarea#4

            //Declaracion de variable
            string Nombre;

            //Asignacion de valores
            Nombre = (TXTNOM.Text);

            //Salida de nombre

            TXTNOMBRE.Text = Nombre.ToString();


        

        }

        private void FRMNOM_Load(object sender, EventArgs e)
        {

        }
    }
}
