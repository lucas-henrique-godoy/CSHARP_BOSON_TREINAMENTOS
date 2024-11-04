using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha a aplicação quando clicado.
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            janela Tela = new janela(); // Cria uma nova instância da classe 'janela'
            Tela.Show(); // Abre o form chamado janela quando clicado
            this.Hide(); // Fecha a primeira janela mas a aplicação continua aberta

        }
    }
}
