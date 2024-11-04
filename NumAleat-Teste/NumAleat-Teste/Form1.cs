using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumAleat_Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeraNumero_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância da classe Random para gerar números aleatórios
            Random numAleatorio = new Random();

            // Gera um número inteiro aleatório entre 1 e 100 (101 é excluído)
            int valorInteiro = numAleatorio.Next(1, 101);

            // Gera um número decimal aleatório entre 0.0 e 1.0
            double valorDecimal = numAleatorio.NextDouble();

            // Converte o número inteiro gerado para string e exibe no label lblNumeroIntGerado
            lblNumeroIntGerado.Text = valorInteiro.ToString();

            // Converte o número decimal gerado para string e exibe no label lblNumeroDoubleGerado
            lblNumeroDoubleGerado.Text = valorDecimal.ToString();
        }

    }
}
