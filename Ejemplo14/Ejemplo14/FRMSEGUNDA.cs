using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo14
{
    public partial class FRMSEGUNDA : Form
    {
        public FRMSEGUNDA()
        {
            InitializeComponent();
        }

        private void FRMSEGUNDA_Load(object sender, EventArgs e)
        {
            TXTNOM.Clear();
            TXTNOM.Focus();
        }

        private void TXTNOM_TextChanged(object sender, EventArgs e)
        {

        }

        private void CMDACEPTAR_Click(object sender, EventArgs e)
        {

        }
    }
}
