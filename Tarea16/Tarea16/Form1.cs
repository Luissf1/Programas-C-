using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea16
{
    public partial class FRMVENTAS : Form
    {
        public FRMVENTAS()
        {
            InitializeComponent();
        }

        private void CMDTOTAL_Click(object sender, EventArgs e)
        {
            //programa para calcular totales de tienda de electronica
            //Silva Reyes Luis Adrian 19210549
            //Tarea#16

            //Declaracion de variables
            double precio;

            //Asignacion de variables
            precio = System.Double.Parse(TXTPRECIO.Text);

            //llamar subprograma 
            Contado(precio);

            //llamar subprograma
            Abono(precio);
        }
        //subprograma contado
        void Contado(double precio1)
        {
            //Declaracion de variables locales
            double ivac, totalc;
            //Asignacion de valores
            ivac = Iva(precio1);
            totalc = ivac + precio1;

            //salida de dato
            TXTTOTAL.Text = totalc.ToString();

        }

        //Subprograma abono
        void Abono(double precio2)
        {
            //Declaracion de variables locales
            double totala, ivaa, interes, men;

            //Asignacion de valores
            interes = precio2 * .20;
            precio2 = precio2 + interes;
            ivaa = Iva(precio2);
            totala = precio2 + ivaa;
            men = totala / 6;

            //Salida de datos
            TXTTOTALA.Text = totala.ToString();
            TXTMENSUALIDAD.Text = men.ToString();

        }
        double Iva(double pre)
        {
            return pre * .16;

        }
        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTPRECIO.Clear();
            TXTTOTAL.Clear();
            TXTTOTALA.Clear();
            TXTMENSUALIDAD.Clear();
            TXTPRECIO.Focus();
        
        }
    }
}
