using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5
{
    public partial class FRMIVA : Form
    {
        public FRMIVA()
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

        private void CMDIVA_Click(object sender, EventArgs e)
        {
            //Program Para calcular iva 16% y total
            //Silva Reyes Luis Adrian 19210549
            //Tarea#5


            //Declaracion de variables
            double Iva, Precio;

            //Asignacion de valores
            Precio = System.Double.Parse(TXTPRECIO.Text);

            //Calculo de IVA

            Iva = Precio * 0.16;

            //Salida de IVA

            TEXTIVA.Text = Iva.ToString();



      
        }

        private void CMDTOTAL_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            double Iva, Precio,total;

            //Asignacion de valores
            Precio = System.Double.Parse(TXTPRECIO.Text);

            //Calculo de IVA

            Iva = Precio * 0.16;

            //Calculo de Total

            total = Iva + Precio;

            //Salida de total
            TEXTTOTAL.Text = total.ToString();
        }
    }
}
