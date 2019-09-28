using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea14
{
    public partial class FRMFACTURA : Form
    {
        public FRMFACTURA()
        {
            InitializeComponent();
        }

        private void CMDTOTAL_Click(object sender, EventArgs e)
        {
            //Program que realizara factura por procedimientos
            //Silva Reyes Luis Adrian 19210549
            //Tarea#14
            
            //llamada a procedimiento
            Calculo();
           




        }
        //subprograma calculo
        void Calculo()
        {
            //Declaracion de variable local
            double precio;
            //Asignacion de valor
            precio = System.Double.Parse(TXTPRECIO.Text);

            //llamada a procedimiento
            Proceso(precio);



        }

        //Subprograma proceso
        void Proceso(double precio1)
        {
            //Declaracion de variables locales
            double gan, iva, total;

            //Calculo de datos
            gan = .10 * precio1;
            iva = .15 *precio1;
            total = iva + gan+ precio1;

            //llamada a procedimiento

            Resultado(total);

        
        }
        //Subprograma resultado
        void Resultado(double total1)
        {
            TXTTOTAL.Text = total1.ToString();
        }

        private void CMDSALIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTPRECIO.Clear();
            TXTTOTAL.Clear();
            TXTPRECIO.Focus();
        }
    }
}
