using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea45
{
    public partial class FRMTRABA : Form
    {
        public FRMTRABA()
        {
            InitializeComponent();
        }

        //Declaracion del registro"registro"
        struct tipoPersona
        {
            public long C;
            public string Nom;
            public string DEP;
            public int Sue;
            public int TAB;
            public string PUES;


        }
        private void CMDDES_Click(object sender, EventArgs e)
        {
            //Programa que inicializa los datos de un empleado y calcula su sueldo neto
            //Silva reyes Luis Adrian 19210549
            //Tarea#45

            //Declaracion de variable 
            int sueldo;
            
     
            //Declaracion del tipo de dato registro "struct"
            tipoPersona persona;

            //Generador de numeros aleatorios
            Random aleatorio = new Random();

            persona.Sue = aleatorio.Next(100,1000);

            //Inicializacion de los campos o datos del registro "struct"
            persona.C = 19210549;
            persona.Nom = "Luis Adrian Silva Reyes";
            persona.DEP = "Sistemas Computacionales";
            persona.PUES = "Soporte";
            persona.TAB = 8;
            //Despliegue de los campos o datos del registro "struct"
            TXTC.Text = persona.C.ToString();
            TXTNOM.Text = persona.Nom.ToString();
            TXTDEP.Text = persona.DEP.ToString();
            TXTTAB.Text = persona.TAB.ToString();
            TXTPUES.Text = persona.PUES.ToString();
            TXTHOR.Text = persona.Sue.ToString();

            //Salida de sueldo neto
            sueldo = persona.Sue * persona.TAB;

            TXTNETO.Text = sueldo.ToString();

        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTC.Clear();
            TXTNOM.Clear();
            TXTDEP.Clear();
            TXTTAB.Clear();
            TXTPUES.Clear();
            TXTHOR.Clear(); ;
            TXTNETO.Clear();
            TXTC.Focus();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
