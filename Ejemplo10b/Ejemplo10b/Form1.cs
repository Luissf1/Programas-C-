using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo10b
{
    public partial class FRMEJEMPLO10B : Form
    {
        public FRMEJEMPLO10B()
        {
            InitializeComponent();
        }

        private void CMDVAL_Click(object sender, EventArgs e)
        {
            //Programa que valida una division entre cero
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#10b

            //Declaracion de variables
            int Dividiendo, Divisor, Resultado;
            //Asignacion de valor
            Dividiendo = System.Int32.Parse(TXTDIVIDIENDO.Text);
            Divisor = System.Int32.Parse(TXTDIVISOR.Text);

            //Try-catch
            try
            {
                Resultado = (Dividiendo / Divisor);

            }
            catch(System.DivideByZeroException aviso)
            {
                MessageBox.Show("Error: " + aviso);

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
