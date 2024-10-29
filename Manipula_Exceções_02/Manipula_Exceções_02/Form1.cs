using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manipula_Exceções_02
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
                MessageBox.Show("Digite apenas valores numéricos", "Bloco catch");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Segundo bloco catch");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Desconhecido", "Terceiro bloco catch");
            }
            finally
            {
                MessageBox.Show("Este bloco sempre será executado, independente de erros", "Bloco finally");
            }
        }
    }
}
