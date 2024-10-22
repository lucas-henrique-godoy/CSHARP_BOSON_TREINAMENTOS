using System;

namespace Modificador_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            double peso;

            Animal bicho = new Animal();
            idade = bicho.ObterIdade();
            peso = bicho.ObterPeso;

            Console.WriteLine("A idade é {0}", idade);
            Console.WriteLine("O peso é {0:F}", peso);

            Animal.Mensagem();
        }
    }
}
