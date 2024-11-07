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
        }
    }
}
