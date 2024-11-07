using System;
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
                lstAnimais.Items.Add(txtAdicionaItem.Text); // Adiciona o texto inserido à lista de animais
                txtAdicionaItem.Clear(); // Limpa o campo de texto
                txtAdicionaItem.Focus(); // Coloca o foco de volta no campo de texto para o próximo input
            }

        }
    }
}
