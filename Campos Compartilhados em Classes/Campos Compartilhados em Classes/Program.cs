using System; // Importa o namespace System, que contém classes fundamentais.

namespace Campos_Compartilhados_em_Classes // Define um namespace para organizar o código.
{
    internal class Program // Declara a classe 'Program' como interna.
    {
        // Método principal onde a execução do programa começa.
        static void Main(string[] args)
        {
            // Criar dois objetos do tipo Acumula:
            Acumula objeto01 = new Acumula(); // Cria a primeira instância da classe Acumula.
            Acumula objeto02 = new Acumula(); // Cria a segunda instância da classe Acumula.

            objeto01.incrementa(); // Chama o método incrementa na primeira instância, aumentando 'soma' em 1.
            // Exibe o valor atual de 'soma' após o incremento.
            Console.WriteLine("O valor é {0}", Acumula.soma.ToString());

            objeto02.incrementa(8); // Chama o método incrementa na segunda instância, aumentando 'soma' em 8.
            // Exibe o valor atual de 'soma' após o incremento.
            Console.WriteLine("O valor é {0}", Acumula.soma.ToString());
        }
    }
}
