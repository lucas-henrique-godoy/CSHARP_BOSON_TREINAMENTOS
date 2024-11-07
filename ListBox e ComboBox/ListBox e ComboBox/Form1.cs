using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_e_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdicionaItem.Text)) // Verifica se o texto é nulo, vazio ou contém apenas espaços em branco
            {
                MessageBox.Show("Digite um item para adicionar à lista", "Caixa vazia"); // Exibe uma mensagem de alerta ao usuário
            }
            else
            {
                lstAnimais.Items.Add(txtAdicionaItem.Text); // Adiciona o texto inserido à lista de animais(Add adicona apenas 1 iten)
                txtAdicionaItem.Clear(); // Limpa o campo de texto
                txtAdicionaItem.Focus(); // Coloca o foco de volta no campo de texto para o próximo input
            }

        }

        private void btnPreenche_Click(object sender, EventArgs e)
        {
            if (lstAnimais.Items.Count == 0) // Verifica se a lista lstAnimais está vazia (se o número de itens na lista é 0)
            {
                string[] bichos = new string[10] { "Jacaré", "Onça", "Elefante", "Gato", "Cão", "Papagaio", "Lontra", "Golfinho", "Foca", "Tatu" }; // Cria um array de strings com 10 elementos (nomes de animais)
                lstAnimais.Items.AddRange(bichos); // Adiciona todos os elementos do array bichos à lista lstAnimais de uma vez.(AddRange adiciona um conjunto de itens)
            }
            else
            {
                MessageBox.Show("Lista já preenchida!", "Lista Preenchida"); // Exibe uma mensagem informando que a lista já está preenchida
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstAnimais.Items.Clear(); //Limpa todos os itens da lista lstAnimais, removendo qualquer conteúdo atual
        }
    }
}
