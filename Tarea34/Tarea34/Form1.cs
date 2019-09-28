using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea34
{
    public partial class FRMSALDO : Form
    {
        public FRMSALDO()
        {
            InitializeComponent();
        }

        private void FRMSALDO_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDGASTO_Click(object sender, EventArgs e)
        {
            //Programa que realiza compra con 1000 de saldo
            //Silva Reyes Luis Adrian 19210549
            //Tarea#34

            //Declaracion de variables
            int A = 1000;
            int Gasto = 0;
            int Res = 0;
            


            //Crea un objeto de la clase FRMSEGUNDA
            FRMSEGUNDA FormaCaptura = new FRMSEGUNDA();

           


            
                
                //While
                while (Gasto < 1000)
                {
                if (FormaCaptura.ShowDialog() == DialogResult.OK)
                {
                    
                    Gasto = Convert.ToInt32(FormaCaptura.TXTGASTO.Text);
                    FormaCaptura.TXTGASTO.Text = Gasto.ToString();

                    TXTSALDO.Text = Gasto.ToString();
                    if (Gasto <= A)
                    {
                        A = A - Gasto;
                        Res = A;
                        TXTRES.Text = "Compra realizada, resta:" + Res + "\t";

                    }
                    else
                    {
                        TXTSALDO.Text = TXTSALDO.Text + "Saldo insuficiente" + A + "\t";

                    }
                    
                }
                }

                
            

        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            
            TXTRES.Clear();
            TXTSALDO.Clear();
            TXTSALDO.Focus();

        }
    }
}
