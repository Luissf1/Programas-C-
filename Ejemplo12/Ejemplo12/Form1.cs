using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo12
{
    public partial class FRMEJEMPLO12 : Form
    {
        public FRMEJEMPLO12()
        {
            InitializeComponent();
        }
        //Declaracion variables globales
        int N1 = 0, N2 = 0;

        //Codigo para la caja de texto TXTNUM1
        private void TXTNUM1_TextChanged(object sender, EventArgs e)
        {//Try-catch
            try
            {
                N1 = Convert.ToInt32(TXTNUM1.Text);

            }
            catch (Exception)
            {
                TXTNUM1.Focus();
                TXTNUM1.Select();
                MessageBox.Show(" Introduce valor correcto ", " Error ");
            }

        }
        //Codigo para la caja de texto TXTNUM2
        private void TXTNUM2_TextChanged(object sender, EventArgs e)
        {
            //Try-catch
            try
            {
                N2 = Convert.ToInt32(TXTNUM2.Text);

            }
            catch(Exception)
            {
                TXTNUM2.Focus();
                TXTNUM2.SelectAll();
                MessageBox.Show(" Introduce un valor correcto ", " Error ");
            }
        }

        private void CMDSAL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CMDCAL_Click(object sender, EventArgs e)
        {
            //Programa que suma de dos numeros 
            //Silva Reyes Luis Adrian 19210549
            //Ejemplo#12
            //Declaracion de variables
            int R = 0;

            //Try-catch
            try
            {
                R = (N1 / N2);

            }
            catch(System.DivideByZeroException)
            {
                MessageBox.Show("Error trataste de dividir entre cero");
                TXTNUM1.Focus();
                TXTNUM1.SelectAll();
            }
            TXTRES.Text = R.ToString();
        }
       

    }
}
