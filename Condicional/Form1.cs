using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            // Declarando variáveis
            int Numero01;
            int Numero02;

            // Convertendo os valres da tela para inteiros
            Numero01 =  Convert.ToInt16(txtValor01.Text);
            Numero02 = Convert.ToInt16(txtValor02.Text);

            
            txtResultado.Text = Convert.ToString(Numero01 + Numero02);
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            int Numero01;
            int Numero02;
            int Resultado;

            Numero01 = Convert.ToInt16(txtValor01.Text);
            Numero02 = Convert.ToInt16(txtValor02.Text);
            Resultado = Numero01 - Numero02;

            txtResultado.Text = Convert.ToString(Resultado);
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            int Numero01;
            int Numero02;
            int Resultado;

            Numero01 = Convert.ToInt16(txtValor01.Text);
            Numero02 = Convert.ToInt16(txtValor02.Text);
            Resultado = Numero01 * Numero02;

            txtResultado.Text = Convert.ToString(Resultado);
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            int Numero01;
            int Numero02;
            int Resultado;

            Numero01 = Convert.ToInt16(txtValor01.Text);
            Numero02 = Convert.ToInt16(txtValor02.Text);

            if  (Numero02!=0)
                Resultado = Numero01 / Numero02;
            else
                Resultado = 0;

            txtResultado.Text = Convert.ToString(Resultado);
        }
    }
}
