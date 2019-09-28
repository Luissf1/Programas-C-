using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea42
{
    public partial class FRMSEGUNDA : Form
    {
        public FRMSEGUNDA()
        {
            InitializeComponent();
        }

        private void FRMSEGUNDA_Load(object sender, EventArgs e)
        {
            TXTNO.Clear();
            TXTNC.Clear();
            TXTNO.Focus();
        }

    }
}
