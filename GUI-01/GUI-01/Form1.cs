using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_01
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evento Load disparado!"); // Mostra uma mensagem ao carregar(Rodar) o Form 1
        }

        private void frmInicial_Click(object sender, EventArgs e) // Event de click
        {
            Janela2 Tela = new Janela2(); // Crio uma instância da classe do Janela 2 chamada Tela.
            Tela.Show(); // Uso o método de mostrar elemento(show)
            //Quando o usuário clicar no Form 1 ele abrirá o Janela 2.
        }
    }

}