using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea30
{
    public partial class FRMEX : Form
    {
        public FRMEX()
        {
            InitializeComponent();
        }

        private void CMDPON_Click(object sender, EventArgs e)
        {
            //Programa que calcula potencia 
            //Silva Reyes Luis Adrian 19210549
            //Tarea#30

            //Declaracion de variables
            int Num, Pot;
            int R=1;
            int C = 0;

            //Asignacion de variables
            Num = System.Int32.Parse(TXTNUM.Text);
            Pot = System.Int32.Parse(TXTPON.Text);

            //Do while
            do
            {
                R = Num * R;
                C = C + 1;
                TXTPOT1.Text = TXTPOT1.Text + R + "*";
            } while (Pot > C);
            //Salida de Resultado 
            TXTPOT.Text = "El resultado es :" + R;
            
     
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNUM.Clear();
            TXTPON.Clear();
            TXTPOT.Clear();
            TXTPOT1.Clear();
            TXTNUM.Focus();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
