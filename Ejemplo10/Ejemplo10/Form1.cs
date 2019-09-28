using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo10
{
    public partial class FRMEJEMPLO10 : Form
    {
        public FRMEJEMPLO10()
        {
            InitializeComponent();
        }

        private void FRMEJEMPLO10_Load(object sender, EventArgs e)
        {

        }

        private void LBLVAL_Click(object sender, EventArgs e)
        {

        }

        private void CMDVALIDAR_Click(object sender, EventArgs e)
        {
            //Programa que valida una division entre cero
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#10

            //Declaracion de variables
            int dividiendo = 10;
            int divisor = 0;
            int resultado=0;

            //Uso del try catch
            try
            {
                resultado = (dividiendo / divisor);

            }
            
                catch (System.DivideByZeroException aviso)
                {
                MessageBox.Show("Error    " + aviso);
            }
            finally
            {
                LBLVAL.Text = "Fin de validacion";
            }
            


        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
