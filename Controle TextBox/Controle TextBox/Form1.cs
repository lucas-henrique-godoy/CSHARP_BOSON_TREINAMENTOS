using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtEntrada.Text = "Bóson Treinamentos"; -> Inserindo um texto no textbox(a propriedade text so aceita strings, as vezes é necessário fazer conversões. )
            //txtSaida.Text = txtEntrada.Text; // O que for digitado no TextBox1 sera mostrado tambem no Textox 2
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            txtSaida.Text = txtEntrada.Text;
        }
    }
}
