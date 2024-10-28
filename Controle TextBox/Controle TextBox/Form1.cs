using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes do formulário.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEntrada.Clear(); // Limpa o texto do TextBox de entrada ao clicar.
            //txtEntrada.Focus();  Define o foco no campo de entrada de texto, permitindo que o usuário comece a digitar imediatamente.
            //txtEntrada.Text = "Bóson Treinamentos"; // Define um texto fixo no TextBox de entrada.
            // txtSaida.Text = txtEntrada.Text; // Exibe o mesmo texto no TextBox de saída (código comentado).
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            //txtSaida.Text = txtEntrada.Text; // Atualiza o TextBox de saída conforme o texto do de entrada muda.
            
        }

        private void txtEntrada_Click(object sender, EventArgs e)
        {
            txtEntrada.Text = ""; // Limpa o texto do TextBox de entrada ao clicar.
        }

        private void txtEntrada_MouseHover(object sender, EventArgs e)
        {
            txtEntrada.Text = "Digite seu nome aqui"; // Exibe uma dica ao passar o mouse sobre o TextBox.
        }
    }
}
