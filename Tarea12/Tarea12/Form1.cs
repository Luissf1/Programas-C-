using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea12
{
    public partial class FRMFACTURA : Form
    {
        public FRMFACTURA()
        {
            InitializeComponent();
        }

        private void CMDFACUTRA_Click(object sender, EventArgs e)
        {
            //Programa para hacer factura de automovil
            //Silva Reyes Luis Adrian 19210549
            //Tarea#12

            //Declaracion de variables 
            Double Precio, Ganancia, Comision, Iva, Subtotal,Total;
            string Descripciones;

            //Asignacion de variables
            Precio = System.Double.Parse(TXTPRE.Text);
            Descripciones = (TXTDES.Text);

            //Calculo de factura
            Ganancia = Precio * .20;
            Comision = Ganancia + 0.03;
            Subtotal = Ganancia +Precio+ Comision;
            Iva = Subtotal * .15;
            Total = Subtotal + Iva;

            //Salida de datos
            TXTDESC.Text = Descripciones.ToString();
            TXTSUB.Text = Subtotal.ToString();
            TXTIVA.Text = Iva.ToString();
            TXTTOTAL.Text = Total.ToString();


            

        

        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
