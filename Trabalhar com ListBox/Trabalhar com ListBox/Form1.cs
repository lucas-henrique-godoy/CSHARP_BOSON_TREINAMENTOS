using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalhar_com_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionaItens_Click(object sender, EventArgs e)
        {
            /*lstAnimais.Items.Add("Águia"); // Adiciona o item "Águia" à lista lstAnimais
            lstAnimais.Items.Add("Baleia"); // Adiciona o item "Baleia" à lista lstAnimais
            lstAnimais.Items.Add("Tamanduá"); // Adiciona o item "Tamanduá" à lista lstAnimais
            lstAnimais.Items.Add("Carpa"); // Adiciona o item "Carpa" à lista lstAnimais
            lstAnimais.Items.Add(txtItem.Text); // Adiciona o conteúdo do controle txtItem (texto digitado pelo usuário) à lista lstAnimais*/

            // Adiciona os itens de um array à lista, se a lista estiver vazia
            string[] animais = new string[7] { "Gato", "Cão", "Papagaio", "Lontra", "Golfinho", "Foca", "Tatu" }; // Cria um array com 7 nomes de animais

            if (lstAnimais.Items.Count == 0) // Verifica se a lista está vazia (não possui itens)
            {
                lstAnimais.Items.AddRange(animais); // Adiciona todos os itens do array 'animais' à lista lstAnimais
            }
            else
            {
                MessageBox.Show("Lista já preenchida!"); // Exibe uma mensagem caso a lista já tenha itens
            }


        }

        private void btnMaisItem_Click(object sender, EventArgs e)
        {
            lstAnimais.Items.Insert(0, txtItem.Text); // Insere o texto digitado em txtItem no início da lista lstAnimais
        }
    }
}
