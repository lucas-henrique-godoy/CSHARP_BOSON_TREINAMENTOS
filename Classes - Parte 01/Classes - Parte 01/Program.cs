using System;

namespace Classes___Parte_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma instância da classe Caixa usando o construtor padrão
            // Este construtor inicializa o lado com um valor fixo de 10
            Caixa cx = new Caixa();

            // Criação de uma instância da classe Caixa usando o construtor sobrecarregado
            // Este construtor permite ao usuário especificar um valor para o lado (neste caso, 8)
            Caixa cx2 = new Caixa(8);

            double volumeCaixa;
            double volumeCaixa2;

            // Calcula o volume da primeira caixa usando o método Volume
            volumeCaixa = cx.Volume();

            // Calcula o volume da segunda caixa usando o método Volume
            volumeCaixa2 = cx2.Volume();

            // Exibe o volume da primeira caixa
            Console.WriteLine(volumeCaixa.ToString());

            // Exibe o volume da segunda caixa
            Console.WriteLine(volumeCaixa2.ToString());            
        }

    }
}
