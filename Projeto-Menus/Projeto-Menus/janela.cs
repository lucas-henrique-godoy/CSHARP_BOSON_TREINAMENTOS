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
    public partial class janela : Form
    {
        public janela()
        {
            InitializeComponent();
        }

        private void janela_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Verifica se não há janelas abertas na aplicação
            if (Application.OpenForms.Count == 0)
            {
                // Se não houver janelas abertas, fecha a aplicação
                Application.Exit();
            }
            else
            {
                // Caso ainda haja janelas abertas, percorre todas as janelas abertas
                foreach (Form formAberto in Application.OpenForms)
                {
                    // Verifica se a janela aberta é do tipo Form1
                    if (formAberto is Form1)
                    {
                        // Se for Form1, exibe essa janela
                        formAberto.Show();
                        // Sai do loop, pois já encontramos a janela desejada
                        break;
                    }
                }
            }
        }

    }
}
