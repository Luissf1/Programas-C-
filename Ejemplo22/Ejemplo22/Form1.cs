using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo22
{
    public partial class TXTEJE : Form
    {
        public TXTEJE()
        {
            InitializeComponent();
        }

        //Declaracion del registro"registro"
        struct tipoPersona
        {
            public long NC;
            public string Nom;
            public string Carr;
            public int Semestr;
        }
        private void CMDDES_Click(object sender, EventArgs e)
        {
            //Programa que inicializa los datos de un alumno en un registro "Struct"y
            //Posteriormente lo despliega
            //Silva reyes Luis Adrian 19210549
            //Ejemplo 22

            //Declaracion del tipo de dato registro "struct"
            tipoPersona persona;

            //Inicializacion de los campos o datos del registro "struct"
            persona.NC = 15210150;
            persona.Nom = "Juan Perez Lopez";
            persona.Carr = "Ing. En sistemas Computacionales";
            persona.Semestr = 5;
            //Despliegue de los campos o datos del registro "struct"
            TXTNC.Text = persona.NC.ToString();
            TXTNOM.Text = persona.Nom.ToString();
            TXTCARR.Text = persona.Carr;
            TXTSEME.Text = persona.Semestr.ToString(); 
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNC.Clear();
            TXTCARR.Clear();
            TXTNOM.Clear();
            TXTSEME.Clear();
            TXTNC.Focus();
        }
    }
}
