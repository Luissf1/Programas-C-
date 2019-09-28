using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class FRMEJEMPLO1 : Form
    {
        public FRMEJEMPLO1()
        {
            InitializeComponent();
        }

        private void CMDAREA_Click(object sender, EventArgs e)
        {
            //Programa que calcula el area de un triangulo
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo 1

            //Declaracion de variables
            float Base, Altura;

            float Area;

            //Asignacion de valores  
            Base = System.Single.Parse(TXT_BASE.Text);
            Altura = System.Single.Parse(TXT_ALTURA.Text);

            //Calculo de area 
            Area =Base * Altura /2;

            //Salida del area
            TXT_AREA.Text = Area.ToString();



        
      }
        
        private void CMDSALIDA_Click(object sender, EventArgs e) => 
            Close();

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXT_BASE.Clear();
            TXT_ALTURA.Clear();
            TXT_AREA.Clear();
            TXT_BASE.Focus();
        }
    }
}
