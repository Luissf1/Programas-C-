using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea25
{
    public partial class FRMCON : Form
    {
        public FRMCON()
        {
            InitializeComponent();
        }

        private void CMDCON_Click(object sender, EventArgs e)
        {
            //Programa que realiza conversion por subprograma y seleccion multiple
            //Silva Reyes Luis Adrian 19210549
            //Tarea#25

            //Declaracion de variable
            double Opcion,Valor;
           

            //Asignacion de valores
            Opcion = System.Double.Parse(TXTC.Text);
            Valor = System.Double.Parse(TXTD.Text);
            LBLCON2.Text = "Conversiones";
            LBLF.Text = "1.C a F";
            LBLY.Text = "2.M a Y";
            LBLCM.Text = "3.P a CM";
            LBLSALIDA.Text = "4.Salida";
            //Seleccion multiple
            switch (Opcion)
            {
                case 1:
                    CF(Valor);
                    break;
                case 2:
                     MY(Valor);
                    break;
                case 3:
                    PC(Valor);
                    break;

                case 4:
                    Close();
                    break;
                default:
                    TXTC.Text = "No valida";
                    break;

                    



            }

            //Subrpogramas (procedimientos)

            //subprograma que convierte de celius a fahrenheit
            void CF(double C)
            {
                //Declaracion de variable
                double CF1;

                //Conversion
                CF1 = ((9 / 5) * C) + 32;

                //Salida
                TXTC2.Text = CF1.ToString();

            
            }
            //Subrpogramas (procedimientos)

            //subprograma que convierte de metros a yardas
            void MY(double M)
            {
                //Declaracion de variable
                double MY1;

                //Conversion
                MY1 = M*1.094;

                //Salida
                TXTC2.Text = MY1.ToString();


            }
            //Subrpogramas (procedimientos)

            //subprograma que convierte de centimetros a pulgadas
            void PC(double P)
            {
                //Declaracion de variable
                double PC1;

                //Conversion
                PC1 = P*2.54;

                //Salida
                TXTC2.Text = PC1.ToString();


            }







        }

        private void CMDOTRO_Click(object sender, EventArgs e)
        {
            TXTC.Clear();
            TXTC2.Clear();
            TXTD.Clear();
            TXTC.Focus();

        }

        private void FRMCON_Load(object sender, EventArgs e)
        {

        }
    }
}
