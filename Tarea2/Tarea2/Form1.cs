using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class FRMHIP : Form
    {
        public FRMHIP()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRMHIP_Load(object sender, EventArgs e)
        {

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDHIPOTENUSA_Click(object sender, EventArgs e)
        {
            //Program Para calcular Hipotenusa
            //Silva Reyes Luis Adrian 19210549
            //Tarea#2

            //Declaracion de variables
            double HipotenusA, HipotenusaB, Hipotenusa;

            //Asignacion de valores
            HipotenusA = System.Double.Parse(TXTHA.Text);
            HipotenusaB = System.Double.Parse(TXTHB.Text);


            //Calculo de Hipotenusa
            Hipotenusa = Math.Sqrt(Math.Pow(HipotenusA, 2) + Math.Pow(HipotenusaB, 2));

            //Salida de Hipotenusa
            TXTH.Text = Hipotenusa.ToString();



        }
    }
}
