using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea36
{
    public partial class FRMMULTI : Form
    {
        public FRMMULTI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CMDMULT_Click(object sender, EventArgs e)
        {
            //Programa que realiza tabla de multiplicar de numero ingresado
            //Silva Reyes Luis Adrian 19210549
            //Tarea#36

            //Declaracion de variable
            int C ;
            int Res ;
            int Num ;

            //Asignacion de variable
            Num = System.Int32.Parse(TXTNUM.Text);
            //Despliegue de resultado
            for(C = 1; C <= 10; C = C + 1)
            {
                Res = Num * C;

                TXTMULTI.Text =TXTMULTI.Text+Num.ToString()+"*"+C.ToString()+"=" + Res.ToString()+"\r\n" ;
            }


        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTMULTI.Clear();
            TXTNUM.Clear();
            TXTNUM.Focus();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
