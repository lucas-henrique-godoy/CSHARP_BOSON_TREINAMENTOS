using System;

namespace Modificadores_de_Acesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            double peso;

            Animal bicho = new Animal();
            idade = bicho.obterIdade();
            peso = bicho.obterPeso;           

            Console.WriteLine("A idade é: {0}", idade);
            Console.WriteLine("O peso é {0:F}", peso);
        }
    }
}
