using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo20
{
    public partial class FRMEJE : Form
    {
        public FRMEJE()
        {
            InitializeComponent();
        }
        //Declaracion global de los contadores y el arreglo
        int R = 0, C = 0;
        string[,] Nom = new string[5, 3];

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDDES_Click(object sender, EventArgs e)
        {
            //Despliegue de los nombres en la caja de texto
            for(R=0; R<5; R++)
            {
                for(C=0;C<3; C++)
                {
                    TXTNUM1.Text = TXTNUM1.Text + Nom[R, C] + "\t";
                }
                TXTNUM1.Text = TXTNUM1.Text + "\r\n";
            }
        }

        private void CMDINI_Click(object sender, EventArgs e)
        {
            CMDCAPTURA.Enabled = false;
            //Inicializacion del arreglo
            string[,] N = new string[5, 3] {{ "Ana", "Juan", "Mario" },
                { "Irma","Emma","Jose"},{"Alan","David","Elsa" },{ "Gizeh","Natan","Zuly"},
            { "Pedro","Tania","Maria"} };
            //Despliegue de los nombres en la caja de texto
            for(R=0;R<5;R++)
            {
                for (C = 0; C < 3; C++)
                {
                    TXTNUM1.Text = TXTNUM1.Text + N[R, C] + "\t";
                }
                TXTNUM1.Text = TXTNUM1.Text + "\r\n";
            }
        }

        private void CMDNUEVCAP_Click(object sender, EventArgs e)
        {
            TXTNUM.Enabled = true;
            CMDCAPTURA.Enabled = true;
            CMDINI.Enabled = true;
            CMDDES.Enabled = false;
            LBLTXT.Text = "";
            TXTNUM1.Text = "";
            TXTNUM.Clear();
            TXTNUM.Focus();
            C = 0;R = 0;
        }

        private void FRMEJE_Load(object sender, EventArgs e)
        {

        }

        private void CMDCAPTURA_Click(object sender, EventArgs e)
        {
            //Programa que captura de nombres
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#20

            //Desactiva el boton de inicializacion
            CMDINI.Enabled = false;
            //Captura de nombres
            LBLTXT.Text = "[" + R.ToString() + "," + C.ToString() + "]";
            Nom[R, C] = TXTNUM.Text;     
            TXTNUM.Focus();
            TXTNUM.Clear();
            C++;

            //Prueba para incrementar los renglones
            if(C==3)
            {
                R++;
                C = 0;

            }
            //Condicion que termina con la captura de los nombres
            if(R==5)
            {
                TXTNUM.Text = "";
                TXTNUM.Enabled = false;
                CMDCAPTURA.Enabled = false;
                CMDDES.Enabled = true;
                C = 0;
                R = 0;


            }

        }
    }
}
