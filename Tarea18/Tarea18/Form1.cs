using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea18
{
    public partial class FRMSUELDO : Form
    {
        public FRMSUELDO()
        {
            InitializeComponent();
        }

        private void CMDAUMENTO_Click(object sender, EventArgs e)
        {
            //Programa que decide si recibes el aumento y ingresa datos de empleado
            //Silva Reyes Luis Adrian 19210549
            //Tarea#18

            //Declaracion de variables
            double Sueldo, Codigo,Sueldo1;
            string Nombre, Departamento;

            //Asignacion de valores
            Sueldo = System.Double.Parse(TXTSUELDO.Text);
            Codigo = System.Double.Parse(TXTCOD.Text);

            Nombre = (TXTNOM.Text);
            Departamento = (TXTDEP.Text);

            Sueldo1 = Sueldo * 1.08;
            //Condicion
            if (Sueldo < 1500)
            {
                { LBLAUMENTO.Text = "Recibe aumento"; }
                { TXTSUELDO2.Text = Sueldo1.ToString(); }
            }
            else
            {
                { LBLAUMENTO.Text = "No recibe aumento"; }
                { TXTSUELDO2.Text = Sueldo.ToString(); }
            }

            //Salida de datos
            TXTNOM2.Text = Nombre.ToString();
            TXTCOD2.Text = Codigo.ToString();
            TXTDEP2.Text = Departamento.ToString();


        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTNOM.Clear();
            TXTCOD.Clear();
            TXTDEP.Clear();
            TXTSUELDO.Clear();
            TXTNOM2.Clear();
            TXTCOD2.Clear();
            TXTDEP2.Clear();
            TXTSUELDO2.Clear();
            LBLAUMENTO.Text = "";
            TXTNOM.Focus();


        }
    }
}
