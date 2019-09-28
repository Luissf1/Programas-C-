using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea13
{
    public partial class FRMDATOS : Form
    {
        public FRMDATOS()
        {
            InitializeComponent();
        }

        private void CMDDATOS_Click(object sender, EventArgs e)
        {
            //Programa para la entrada y salida de datos de alumno
            //Silva Reyes Luis Adrian 19210549
            //Tarea#13

            //Declaracion de variables
            float Edad;
            double Numero_Control;
            string Nombre, Carrera, Tipo_Sangre, Plantel;

            //Asignacion de valores
            Numero_Control = System.Double.Parse(TXTNUMC.Text);
            Edad = System.Single.Parse(TXTEDAD.Text);
            Nombre = (TXTNUM.Text);
            Carrera = (TXTCARRERA.Text);
            Tipo_Sangre = (TXTTIPOS.Text);
            Plantel = (TXTESCUELA.Text);

            //llamada al procedimiento
            Datos(Numero_Control, Nombre, Edad, Carrera, Tipo_Sangre, Plantel);



        } 

        void Datos (double Numc,string Nom,float Ed,string Carr,string TS,string P)
        {
            //Salida de datos
            TXTNUMC2.Text = Numc.ToString();
            TXTNUM2.Text = Nom.ToString();
            TXTEDAD2.Text = Ed.ToString();
            TXTCARRERA2.Text = Carr.ToString();
            TXTTIPOS2.Text = TS.ToString();
            TXTESCUELA2.Text = P.ToString();



        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNUMC.Clear();
            TXTNUM.Clear();
            TXTEDAD.Clear();
            TXTCARRERA.Clear();
            TXTTIPOS.Clear();
            TXTESCUELA.Clear();
            TXTNUMC2.Clear();
            TXTNUM2.Clear();
            TXTEDAD2.Clear();
            TXTCARRERA2.Clear();
            TXTTIPOS2.Clear();
            TXTESCUELA2.Clear();
            TXTNUMC.Focus();
        }
    }
}
