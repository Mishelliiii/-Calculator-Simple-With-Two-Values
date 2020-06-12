using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class frmPrimeiroFormulario : Form
    {
        public frmPrimeiroFormulario()
        {
            InitializeComponent();
        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {
            lblCor.BackColor = Color.Red;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            lblCor.BackColor = Color.Blue;
        }

        private void btnPadrao_Click(object sender, EventArgs e)
        {
            lblCor.BackColor = Color.Green;
        }
    }
}
