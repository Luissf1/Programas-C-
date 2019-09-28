using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea17
{
    public partial class FRMCAL : Form
    {
        public FRMCAL()
        {
            InitializeComponent();
        }

        private void CMDAPORE_Click(object sender, EventArgs e)
        {
            //Programa que decide si apruebas o repruebas por calificacion
            //Silva Reyes Luis Adrian Silva 19210549
            //Tarea#17

            //Declaracion de variables
            float Cal;

            //Asignacion de variables
            Cal = System.Single.Parse(TXTCAL.Text);

            //Condicion
            if (Cal <70)
                {
                { LBLABORE.Text = "Reprobado"; }
            }
            else
            {
                { LBLABORE.Text = "Aprobado"; }
            }

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            LBLABORE.Text = "";
            TXTCAL.Clear();
            

        }
    }
}
