using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea32
{
    public partial class FRMMAYMEN : Form
    {
        public FRMMAYMEN()
        {
            InitializeComponent();
        }

        private void Captura_Click(object sender, EventArgs e)
        {
            //Programa de adivinanza de numeros
            //Silva Reyes Luis Adrian 19210549
            //Tarea#32

            //Declaracion de variables
            int N = 10;
            int Num ;
            int C = 0;

            //Crea un objeto de la clase FRMSEGUNDA
            FRMSEGUNDA FormaCaptura = new FRMSEGUNDA();

            
            
            if (FormaCaptura.ShowDialog() == DialogResult.OK)
            {
                
                //Do-While
                do
                {

                    Num = Convert.ToInt32(FormaCaptura.TXTNUM.Text);
                    FormaCaptura.TXTNUM.Text = Num.ToString();

                    if (Num > N)
                    {

                        TXTNUM.Text = TXTNUM.Text + "Es mayor:"+Num + "\r\n";

                    }
                    if (Num < N)
                    {
                        TXTNUM.Text = TXTNUM.Text + "Es menor:" + Num + "\r\n";

                    }

                    if (Num == 10)
                    {

                        TXTMAYMEN.Text = TXTMAYMEN.Text + "Felecidades,ganaste" + "\r\n";


                    }
                    else
                    {
                        TXTMAYMEN.Text = TXTMAYMEN.Text + "Perdiste" + "\r\n";
                    }


                    //Contador 
                    C = C + 1;

                } while ( C<1);

                if(C<=5)
                {
                    LBLA.Text = "Bueno";

                }
                else if(C>5 && C<=15)
                {
                    LBLA.Text = "Regular";
                }
                else
                {
                    LBLA.Text = "Malo";
                }
               
            }
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNUM.Clear();
            TXTMAYMEN.Clear();
            TXTNUM.Focus();

        }

        private void Salida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
