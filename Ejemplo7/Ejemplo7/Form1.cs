using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo7
{
    public partial class FRMEJEMPLO7 : Form
    {
        public FRMEJEMPLO7()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CMDELECCION_Click(object sender, EventArgs e)
        {
            //Programa que permite seleccionar un alumno para participar 
            //en un concurso.Los requisitos son que tenga promedio de 90 
            //o mas y que sea de 5to. semestre
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#7

            //Declaracion de variables
            int NC,S;
            float P;
            string Nom, C;

            //Asignacion de valores
            NC = System.Int32.Parse(TXTNUMC.Text);
            Nom = TXTNOM.Text;
            C = TXTCARR.Text;
            S = System.Int32.Parse(TXTSEM.Text);
            P = System.Single.Parse(TXTPROM.Text);

            //Condicion
            {
                if (P >= 90 && S == 5)
                { LBLDESPLIEGUE.Text = "Aceptado"; }
                else
                { LBLDESPLIEGUE.Text = "No aceptado "; }


            }
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNUMC.Clear();
            TXTNUMC.Focus();
            TXTNOM.Clear();
            TXTCARR.Clear();
            TXTSEM.Clear();
            TXTPROM.Clear();
            LBLDESPLIEGUE.Text = "";
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
