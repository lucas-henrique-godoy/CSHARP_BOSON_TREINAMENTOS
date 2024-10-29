using System; // Importa o namespace System, que contém classes fundamentais.
using System.Collections.Generic; // Importa classes que definem coleções genéricas.
using System.ComponentModel; // Importa classes que implementam interfaces para componentes.
using System.Data; // Importa classes para trabalhar com dados.
using System.Drawing; // Importa classes para trabalhar com gráficos.
using System.Linq; // Importa classes para consultas em coleções.
using System.Text; // Importa classes para manipulação de strings.
using System.Threading.Tasks; // Importa classes para programação assíncrona.
using System.Windows.Forms; // Importa classes para criar aplicativos de interface gráfica (Windows Forms).

namespace Controle_TextBox // Define um namespace para organizar o código.
{
    public partial class Form1 : Form // Declara a classe Form1, que herda de Form.
    {
        public Form1() // Construtor da classe Form1.
        {
            InitializeComponent(); // Inicializa os componentes do formulário, como botões e caixas de texto.
        }

        private void btnTeste_Click(object sender, EventArgs e) // Manipulador de eventos para o botão de teste.
        {
            txtEntrada.Cut(); // Remove o texto selecionado no TextBox e copia para a área de transferência.
            //txtEntrada.Copy(); // Copia o texto selecionado para a área de transferência.
            //txtEntrada.Clear(); // Limpa o texto do TextBox de entrada ao clicar.
            //txtEntrada.Focus(); // Define o foco no campo de entrada, permitindo que o usuário digite.
            //txtEntrada.Text = "Bóson Treinamentos"; // Define um texto fixo no TextBox de entrada.
            //txtSaida.Text = txtEntrada.Text; // Copia o texto do TextBox de entrada para o de saída (código comentado).
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e) // Manipulador de eventos para quando o texto muda.
        {
            //txtSaida.Text = txtEntrada.Text; // Atualiza o TextBox de saída com o texto do de entrada conforme muda.
        }

        private void txtEntrada_Click(object sender, EventArgs e) // Manipulador de eventos para clique no TextBox de entrada.
        {
            txtEntrada.Text = ""; // Limpa o texto do TextBox ao clicar nele.
        }

        private void txtEntrada_MouseHover(object sender, EventArgs e) // Manipulador de eventos para quando o mouse passa sobre o TextBox.
        {
            txtEntrada.Text = "Digite seu nome aqui"; // Exibe uma dica ao passar o mouse sobre o TextBox.
        }

        private void btnColar_Click(object sender, EventArgs e) // Manipulador de eventos para o botão de colar.
        {
            txtSaida.Paste(); // Cola o conteúdo da área de transferência no TextBox de saída.
        }

        private void btnOculta_Click(object sender, EventArgs e) // Manipulador de eventos para o botão de ocultar.
        {
            txtSaida.Hide(); // Esconde o TextBox de saída.
        }

        private void btnMostrar_Click(object sender, EventArgs e) // Manipulador de eventos para o botão de mostrar.
        {
            txtSaida.Show(); // Exibe o TextBox de saída.
        }
    }
}
