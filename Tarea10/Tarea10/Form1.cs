using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea10
{
    public partial class FRMNOMS : Form
    {
        public FRMNOMS()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDNOM_Click(object sender, EventArgs e)
        {
            //Programa para salida de nombre
            //Silva Reyes Luis Adrian 19210549
            //Tarea#10

           
            //Salida de nombre

            TXTNOMBRE.Text = "Silva Reyes Luis Adrian";

        }
    }
}
