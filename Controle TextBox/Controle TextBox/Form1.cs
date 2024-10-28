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

        private void btnTeste_Click(object sender, EventArgs e)
        {
            txtEntrada.Cut(); // O método Cut() é chamado para remover o texto atualmente selecionado no controle e copiá-lo para a área de transferência. Isso permite que o usuário transfira o texto para outro lugar e também o remova do campo de entrada.
            //txtEntrada.Copy();// O método Copy() é chamado para copiar o texto selecionado no controle para a área de transferência. Isso permite que o usuário cole esse texto em outro lugar, como em um documento ou outro campo de entrada.                              
            //txtEntrada.Clear(); // Limpa o texto do TextBox de entrada ao clicar.
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

        private void btnColar_Click(object sender, EventArgs e)
        {
            txtSaida.Paste(); // O método Paste() é chamado para colar o conteúdo que está atualmente na área de transferência
        }
    }
}
