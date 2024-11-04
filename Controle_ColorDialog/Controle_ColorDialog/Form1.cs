using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCorFundo_Click(object sender, EventArgs e) // Método chamado ao clicar no botão "btnCorFundo".
        {
            if (cdgCaixaCores.ShowDialog() == DialogResult.OK) // Verifica se o usuário selecionou uma cor.
            {
                txtCores.BackColor = cdgCaixaCores.Color; // Altera a cor de fundo do textbox para a cor selecionada.
            }
        }

        private void btnCorTexto_Click(object sender, EventArgs e) // Método chamado ao clicar no botão "btnCorTexto".
        {
            ColorDialog cdgCaixaCores2 = new ColorDialog(); // Cria uma nova instância da caixa de diálogo de cores.
            cdgCaixaCores2.AllowFullOpen = false; // Impede que o usuário selecione cores fora do padrão.
            cdgCaixaCores2.AnyColor = true; // Permite que o usuário escolha qualquer cor.
            cdgCaixaCores2.SolidColorOnly = false; // Permite que o usuário selecione cores sólidas e não sólidas.
            cdgCaixaCores2.Color = Color.Blue; // Define a cor inicial da caixa de diálogo como azul.

            if (cdgCaixaCores2.ShowDialog() == DialogResult.OK) // Exibe a caixa de diálogo e verifica se uma cor foi selecionada.
            {
                txtCores.ForeColor = cdgCaixaCores2.Color; // Altera a cor do texto do textbox para a cor selecionada.
            }
        }
    }
}
