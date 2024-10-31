using System;
using System.Threading.Channels;

namespace Herança_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
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
