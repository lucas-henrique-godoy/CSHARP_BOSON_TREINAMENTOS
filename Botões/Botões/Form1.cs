using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Botões
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Este método é chamado quando o botão "Clique Me" é clicado.
        private void btnCliqueMe_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem dizendo que o botão 02 será habilitado.
            MessageBox.Show("Habilitando o botão 02");

            // Habilita o botão 02, permitindo que ele seja clicado.
            btnBotao02.Enabled = true;
        }

        // Este método é chamado quando o botão 02 é clicado.
        private void btnBotao02_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem informando que o botão foi ativado.
            MessageBox.Show("O botão foi ativado!");
        }

    }
}
