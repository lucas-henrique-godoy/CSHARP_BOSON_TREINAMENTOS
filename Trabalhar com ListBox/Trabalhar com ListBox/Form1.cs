using System; // Importa o namespace System, que contém classes básicas para trabalhar com tipos básicos, como String, Int, etc.
using System.Collections.Generic; // Importa o namespace para coleções genéricas, como listas, dicionários, etc.
using System.ComponentModel; // Importa o namespace para componentes e eventos relacionados ao design do formulário.
using System.Data; // Importa o namespace que contém classes para trabalhar com dados, como DataTables, DataSets, etc.
using System.Drawing; // Importa o namespace para trabalhar com gráficos, imagens e desenhos.
using System.Linq; // Importa o namespace que contém LINQ, uma forma de consulta para coleções.
using System.Text; // Importa o namespace para trabalhar com codificação e manipulação de strings.
using System.Threading.Tasks; // Importa o namespace para trabalhar com tarefas assíncronas.
using System.Windows.Forms; // Importa o namespace que contém classes para criar aplicações com formulários e controles gráficos.

namespace Trabalhar_com_ListBox // Define o namespace do projeto, onde o código está contido.
{
    public partial class Form1 : Form // Define a classe Form1, que herda de 'Form', representando o formulário (janela gráfica).
    {
        public Form1() // Construtor da classe Form1
        {
            InitializeComponent(); // Inicializa os componentes do formulário, como botões, caixas de texto, etc.
        }

        // Método que é chamado quando o botão 'btnAdicionaItens' é clicado.
        private void btnAdicionaItens_Click(object sender, EventArgs e)
        {
            // Comentado, pois foi substituído por outras implementações. Aqui, os itens são adicionados manualmente.
            /*lstAnimais.Items.Add("Águia"); // Adiciona o item "Águia" à lista lstAnimais
            lstAnimais.Items.Add("Baleia"); // Adiciona o item "Baleia" à lista lstAnimais
            lstAnimais.Items.Add("Tamanduá"); // Adiciona o item "Tamanduá" à lista lstAnimais
            lstAnimais.Items.Add("Carpa"); // Adiciona o item "Carpa" à lista lstAnimais
            lstAnimais.Items.Add(txtItem.Text); // Adiciona o conteúdo do controle txtItem (texto digitado pelo usuário) à lista lstAnimais*/
        }

        // Método que é chamado quando o botão 'btnMaisItem' é clicado.
        private void btnMaisItem_Click(object sender, EventArgs e)
        {
            // Insere o texto digitado no TextBox (txtItem) no início da lista 'lstAnimais'.
            lstAnimais.Items.Insert(0, txtItem.Text); // Insere o texto digitado em txtItem no início da lista lstAnimais
        }

        // Método que é chamado quando o botão 'btnRemoveItens' é clicado.
        private void btnRemoveItens_Click(object sender, EventArgs e)
        {
            /*if (lstAnimais.SelectedIndex != -1) // Verifica se um item foi selecionado na lista
            {
                lstAnimais.Items.RemoveAt(lstAnimais.SelectedIndex); // Remove o item selecionado da lista lstAnimais
            }
            else
            {
                MessageBox.Show("Selecione um elemento!"); // Exibe uma mensagem de erro se nenhum item estiver selecionado
            }*/

            /*lstAnimais.Items.Remove(lstAnimais.SelectedItem); // Remove o item selecionado diretamente
            lstAnimais.Items.Remove("Gato"); // Remove especificamente o item "Gato" da lista*/

            /*Loop que percorre os itens selecionados da lista e os remove.
            Fazemos isso de trás para frente para evitar problemas com a alteração do índice à medida que os itens são removidos.
            for (int i = lstAnimais.SelectedIndices.Count - 1; i >= 0; i--) // Itera pelos índices selecionados da lista, do último para o primeiro.
            {
                lstAnimais.Items.RemoveAt(lstAnimais.SelectedIndices[i]); // Remove o item na posição selecionada na lista
            }
            */

            lstAnimais.Items.Clear();
        }

        // Método que é chamado quando o formulário é carregado (ao iniciar o programa).
        private void Form1_Load(object sender, EventArgs e)
        {
            // Adiciona os itens de um array à lista, mas somente se a lista estiver vazia.
            string[] animais = new string[7] { "Gato", "Cão", "Papagaio", "Lontra", "Golfinho", "Foca", "Tatu" }; // Cria um array de strings com 7 nomes de animais

            lstAnimais.Items.AddRange(animais); // Adiciona todos os itens do array 'animais' à lista lstAnimais de uma vez
        }
    }
}
