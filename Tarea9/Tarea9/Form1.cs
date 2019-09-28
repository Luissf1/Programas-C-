using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea9
{
    public partial class FRMPESOS : Form
    {
        public FRMPESOS()
        {
            InitializeComponent();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDDOLAR_Click(object sender, EventArgs e)
        {
            //Program Para calcular de dolar a pesos
            //Silva Reyes Luis Adrian 19210549
            //Tarea#9


            //Declaracion de variables
            double Pesos, TPC, Dolar;

            //Asiganacion de valores
            Dolar = System.Double.Parse(TXTDOLAR.Text);
            TPC = System.Double.Parse(TXTTPC.Text);

            //Calculo de dolar
            Pesos = Dolar * TPC;

            //Salida de dolar
            TXTPESOS.Text = Pesos.ToString();
        }
    }
}
