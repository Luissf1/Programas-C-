using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo14
{
    public partial class FRMEJEMPLO : Form
    {
        public FRMEJEMPLO()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CMDCAPTURA_Click(object sender, EventArgs e)
        {
            //Programa que da entrada a 5 nombres invocando una segunda forma
            //y por medio del ciclo do while
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#14

            //Declaracion de variables
            int C = 0;
            string Nombre;

            //Crea un objeto de la clase FRMSEGUNDA
            FRMSEGUNDA FormaCaptura = new FRMSEGUNDA();

            //Desactivar boton de captura 
            CMDCAPTURA.Enabled = false;
            //Ciclo do-while
            do
            {
                if (FormaCaptura.ShowDialog() == DialogResult.OK)
                {
                    C = C + 1;
                    Nombre = FormaCaptura.TXTNOM.Text;
                    TXTNOMBRES.Text = TXTNOMBRES.Text + Nombre+"\r\n";

                }

            } while (C < 5);
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNOMBRES.Clear();
            CMDCAPTURA.Enabled = true;
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
