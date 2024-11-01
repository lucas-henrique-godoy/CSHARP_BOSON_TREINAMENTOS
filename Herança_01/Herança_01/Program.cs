using System;
using System.Threading.Channels;

namespace Herança_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciando as classes
            Humano homem = new Humano();
            Baleia baleia = new Baleia();
            Gato gato = new Gato();

            //Usando os objetos e acessando os métodos herdados e específicos
            Console.WriteLine("Humano: ");
            homem.Falar(); // Específico da classe Humano
            homem.Mamar();// Herdado de Mamífero
            homem.Respirar();// Herdado de Mamífero

            Console.WriteLine("");

            Console.WriteLine("Baleia: ");
            baleia.Nadar(); // Específico da classe Baleia
            baleia.Mamar();// Herdado de Mamífero
            baleia.Respirar();// Herdado de Mamífero

            Console.WriteLine("");

            Console.WriteLine("Gato: ");
            gato.Arranhar(); // Específico da classe Gato
            gato.Mamar(); // Herdado de Mamífero
            gato.Respirar();// Herdado de Mamífero
        }
    }

    class Mamifero
    {
        public void Respirar()
        {
            Console.WriteLine("Eu respiro!");
        }
        public void Mamar()
        {
            Console.WriteLine("Eu mamo!");
        }
    }

    class Humano : Mamifero
    {
        public void Falar()
        {
            Console.WriteLine("Eu falo!");
        }
    }

    class Baleia : Mamifero
    {
        public void Nadar()
        {
            Console.WriteLine("Eu nado!");
        }
    }

    class Gato : Mamifero
    {
        public void Arranhar()
        {
            Console.WriteLine("Eu arranho!");
        }
    }    
}
