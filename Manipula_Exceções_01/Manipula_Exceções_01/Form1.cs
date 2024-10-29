using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manipula_Exceções_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtEntrada1.Text);
                int num2 = int.Parse(txtEntrada2.Text);

                int resultado = num1 * num2;

                txtSaida.Text = resultado.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Bloco catch");
            }
            finally
            {
                MessageBox.Show("Este bloco sempre será executado, independente de erros", "Bloco finally");
            }
        }

        private void txtEntrada1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
