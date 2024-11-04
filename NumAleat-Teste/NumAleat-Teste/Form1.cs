using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumAleat_Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeraNumero_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next();
            double valorDecimal = numAleatorio.NextDouble();
            lblNumeroIntGerado.Text = valorInteiro.ToString();
            lblNumeroDoubleGerado.Text = valorDecimal.ToString();
        }
    }
}
