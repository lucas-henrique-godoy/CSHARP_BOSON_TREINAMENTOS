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
        }
    }
}
