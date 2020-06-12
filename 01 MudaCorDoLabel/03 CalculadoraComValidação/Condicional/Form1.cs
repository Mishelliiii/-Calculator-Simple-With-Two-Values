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
            int Numero01=0;
            int Numero02=0;

            if (txtValor01.Text != "")
            {
                // Convertendo os valres da tela para inteiros
                Numero01 = Convert.ToInt16(txtValor01.Text);
                if (txtValor02.Text != "")
                {
                    Numero02 = Convert.ToInt16(txtValor02.Text);
                    txtResultado.Text = Convert.ToString(Numero01 + Numero02);
                }
                else
                    txtResultado.Text = "Digite o Segundo Valor!";
            }
            else
                txtResultado.Text = "Digite o Primeiro Valor!";
            
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            int Numero01;
            int Numero02;
            int Resultado;


            if (txtValor01.Text != "")
            {
                Numero01 = Convert.ToInt16(txtValor01.Text);
                if (txtValor02.Text != "")
                {
                    Numero02 = Convert.ToInt16(txtValor02.Text);

                    // PRocessamento
                    Resultado = Numero01 - Numero02;

                    // Saida de Dados
                    txtResultado.Text = Convert.ToString(Resultado);
                }
                else
                    txtResultado.Text = "Digite o Segundo Valor";
            }
            else
                txtResultado.Text = "Digite o Valor 01";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            int Numero01;
            int Numero02;
            int Resultado;

            if (txtValor01.Text != "")
            {
                Numero01 = Convert.ToInt16(txtValor01.Text);
                if (txtValor02.Text != "")
                {
                    Numero02 = Convert.ToInt16(txtValor02.Text);
                    Resultado = Numero01 * Numero02;

                    txtResultado.Text = Convert.ToString(Resultado);
                }
                else
                    txtResultado.Text = "Digite o Segundo Valor";
            }
            else
                txtResultado.Text = "Digite o Primeiro Valor";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            int Numero01;
            int Numero02;
            int Resultado=0;

            if (txtValor01.Text != "")
            {
                Numero01 = Convert.ToInt16(txtValor01.Text);
                if (txtValor02.Text != "")
                {
                    Numero02 = Convert.ToInt16(txtValor02.Text);

                    if (Numero02 != 0)
                    {
                        Resultado = Numero01 / Numero02;
                        txtResultado.Text = Convert.ToString(Resultado);
                    }
                    else
                    {
                        txtResultado.Text = "Operação Inexistente!";
                    }
                }
                else
                    txtResultado.Text = "Digite o Segundo Valor";
            }
            else
                txtResultado.Text = "Digite o Primeiro Valor";

           
        }
    }
}
