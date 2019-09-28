using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea8
{
    public partial class FRMCON : Form
    {
        public FRMCON()
        {
            InitializeComponent();
        }

        private void FRMCONVERSION_Load(object sender, EventArgs e)
        {

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDKILOGRAM_Click(object sender, EventArgs e)
        {
            //Program Para convertir libras a kilogramos
            //Silva Reyes Luis Adrian 19210549
            //Tarea#7

            //Declaracion de variables
            double Libras, Kilogramos;

            //Asignacion de valores
            Libras = System.Double.Parse(TXTLB.Text);

            //Conversion de libras
            Kilogramos = Libras / 2.245;

            //Salida de Kilograma
            TXTKILO.Text = Kilogramos.ToString();
        }
    }
}
