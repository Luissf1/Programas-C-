using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea6
{
    public partial class FRMPESO : Form
    {
        public FRMPESO()
        {
            InitializeComponent();
        }

        private void CMDDOLAR_Click(object sender, EventArgs e)
        {
            //Program Para calcular de pesos a dolar
            //Silva Reyes Luis Adrian 19210549
            //Tarea#6


            //Declaracion de variables
            double Pesos, TPC, Dolar;

            //Asiganacion de valores
            Pesos = System.Double.Parse(TXTPESOS.Text);
            TPC = System.Double.Parse(TXTTPC.Text);

            //Calculo de dolar
            Dolar = Pesos / TPC;

            //Salida de dolar
            TXTDOLAR.Text = Dolar.ToString();

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
