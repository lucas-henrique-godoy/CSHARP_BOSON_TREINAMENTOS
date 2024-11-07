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
            lstAnimais.Items.Add("Águia"); // Adiciona o item "Águia" à lista lstAnimais
            lstAnimais.Items.Add("Baleia"); // Adiciona o item "Baleia" à lista lstAnimais
            lstAnimais.Items.Add("Tamanduá"); // Adiciona o item "Tamanduá" à lista lstAnimais
            lstAnimais.Items.Add("Carpa"); // Adiciona o item "Carpa" à lista lstAnimais
            lstAnimais.Items.Add(txtItem.Text); // Adiciona o conteúdo do controle txtItem (texto digitado pelo usuário) à lista lstAnimais

            // Adiciona todos os itens de um array à lista de uma vez
            string[] animais = new string[7] { "Gato", "Cão", "Papagaio", "Lontra", "Golfinho", "Foca", "Tatu" };
            lstAnimais.Items.AddRange(animais);
        }
    }
}
