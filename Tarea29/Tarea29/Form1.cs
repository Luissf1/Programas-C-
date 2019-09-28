using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea29
{
    public partial class FRMFAC : Form
    {
        public FRMFAC()
        {
            InitializeComponent();
        }

        private void CMDFAC_Click(object sender, EventArgs e)
        {
            //Programa que demuestra factorial de numero ingresado
            //Silva Reyes Luis Adrian 19210549
            //Tarea#29

            //Declaracion de variables
            int Num;
            int Tot = 1;
            //Asignasion de variable
            Num = System.Byte.Parse(TXTFAC.Text);

            //Do while
            do
            {
                Tot = Tot * Num;
                TXTFAC2.Text = TXTFAC2.Text + Num + "*";
                Num = Num - 1;

            } while (Num > 0);
            //Salida de resultado
            LBLSUMA.Text = "=" + Tot.ToString();
        
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTFAC.Clear();
            TXTFAC2.Clear();
            LBLSUMA.Text = "";
            TXTFAC.Focus();

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
