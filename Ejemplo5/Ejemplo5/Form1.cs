﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo5
{
    public partial class FRMEDAD : Form
    {
        public FRMEDAD()
        {
            InitializeComponent();
        }

        private void FRMEDAD_Load(object sender, EventArgs e)
        {

        }

        private void CMDMAYOR_Click(object sender, EventArgs e)
        {
            //Progtama que determina si una persona es mayor de edad
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#5

            //Declaracion de variables
            byte Edad;

            //Asignacion de valores
            Edad = System.Byte.Parse(TXTEDAD.Text);

            //Condicion que determina mayor de edad
            if (Edad >= 18)
            { LBLMAYMEN.Text = "Mayor de Edad"; }


        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            LBLMAYMEN.Text = "";
            TXTEDAD.Clear();


        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
