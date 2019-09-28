using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo11
{
    public partial class FRMEJEMPLO11 : Form
    {
        public FRMEJEMPLO11()
        {
            InitializeComponent();
        }

        private void CMDPROCESAR_Click(object sender, EventArgs e)
        {
            //Programa que convierte pulgadas a centimetros
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#11

            //Declaracion de variables
            double cm, inc;

            //Try-catch
            try
            {
                inc = System.Double.Parse(TXTCON.Text);
                cm = inc * 2.54;
                MessageBox.Show(inc + "  Pulgadas son " + cm +" centimetros ", " resultado ");

            }
            catch(System.FormatException)
            {
                //mensjes en caso de que la caja de texto quede vacia
                MessageBox.Show("Favor de teclear un valor", "Error");

            }
            finally
            {
                TXTCON.Clear();
                TXTCON.Focus();


            }
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
