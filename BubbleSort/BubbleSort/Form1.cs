using System; // Importa o namespace System para acesso a classes básicas
using System.Collections.Generic; // Importa o namespace para usar coleções genéricas
using System.ComponentModel; // Importa para componentes do Windows Forms
using System.Data; // Importa para manipulação de dados
using System.Drawing; // Importa para trabalhar com gráficos
using System.Linq; // Importa para uso de LINQ (Language Integrated Query)
using System.Text; // Importa para manipulação de strings
using System.Threading.Tasks; // Importa para suporte a programação assíncrona
using System.Windows.Forms; // Importa para criar aplicações de interface gráfica do Windows

namespace BubbleSort // Declara um namespace para organizar o código
{
    public partial class Form1 : Form // Classe principal do formulário que herda de Form
    {
        // Declaração de dois arrays de inteiros com valores iniciais
        int[] x = { 2, 1, 8, 7, 5, 9, 15, 3, 6 };
        int[] y = { 4, 2, 9, 7, 6, 18, 11, 4, 8 };

        public Form1() // Construtor da classe Form1
        {
            InitializeComponent(); // Inicializa os componentes do formulário
        }

        private void btnCriaArray_Click(object sender, EventArgs e) // Método chamado ao clicar no botão para mostrar o array original
        {
            // Exibe os itens do array 'x' na label lblArrayOriginal
            lblArrayOriginal.Text = "Itens do array na ordem original:\n";
            for (int i = 0; i < x.Length; i++)
            {
                lblArrayOriginal.Text += " " + x[i]; // Adiciona cada elemento ao texto da label
            }

            // Exibe os itens do array 'y' na label lblArrayOriginal2
            lblArrayOriginal2.Text = "Itens do array na ordem original:\n";
            for (int i = 0; i < y.Length; i++)
            {
                lblArrayOriginal2.Text += " " + y[i]; // Adiciona cada elemento ao texto da label
            }
        }

        private void btnOrdenaArray_Click(object sender, EventArgs e) // Método chamado ao clicar no botão para ordenar o array 'x'
        {
            // Chama o método bubblesort para ordenar o array 'x'
            bubblesort(x);
            lblOrdenado.Text = "Itens do array ordenados:\n"; // Define o texto inicial da label
            for (int i = 0; i < x.Length; i++)
            {
                lblOrdenado.Text += " " + x[i]; // Adiciona cada elemento do array ordenado à label
            }
        }

        // Método que implementa o algoritmo Bubble Sort
        public void bubblesort(int[] y)
        {
            // Loop externo controla o número de passagens pelo array
            for (int i = 1; i < y.Length; i++)
            {
                // Loop interno compara elementos adjacentes
                for (int j = 0; j < y.Length - 1; j++)
                {
                    // Se o elemento atual for maior que o próximo, troca-os
                    if (y[j] > y[j + 1])
                    {
                        troca(y, j); // Chama o método de troca para realizar a troca
                    }
                }
            }
        }

        // Método para trocar os valores de dois elementos do array
        public void troca(int[] g, int primeiro)
        {
            int aux; // Variável auxiliar para a troca
            aux = g[primeiro]; // Guarda o valor do primeiro elemento
            g[primeiro] = g[primeiro + 1]; // Substitui o primeiro elemento pelo segundo
            g[primeiro + 1] = aux; // Atribui o valor guardado ao segundo elemento
        }

        private void btnMetodoSort_Click(object sender, EventArgs e) // Método chamado ao clicar no botão para ordenar o array 'y' usando o método nativo
        {
            Array.Sort(y); // Usa o método nativo para ordenar o array 'y'
            lblArraySort.Text = "Itens do array ordenados"; // Define o texto inicial da label

            // Adiciona cada item do array 'y' ordenado à label
            foreach (int item in y)
            {
                lblArraySort.Text += " " + item.ToString(); // Adiciona cada elemento ao texto da label
            }
        }
    }
}
