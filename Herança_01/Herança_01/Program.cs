using System;

namespace Herança_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciando a classe base Mamífero
            Mamifero animal = new Mamifero();

            // Instanciando as classes derivadas
            Humano homem = new Humano();
            Baleia baleia = new Baleia();
            Gato gato = new Gato();

            // Usando o objeto 'animal' da classe Mamifero
            Console.WriteLine("Animal:");
            animal.Mamar();          // Chamando método herdado de Mamifero
            animal.Respirar();       // Chamando método herdado de Mamifero

            Console.WriteLine("");    // Linha em branco para melhor visualização

            // Usando o objeto 'homem' da classe Humano
            Console.WriteLine("Humano: ");
            homem.Falar();           // Método específico da classe Humano
            homem.Mamar();           // Método herdado da classe Mamifero
            homem.Respirar();        // Método herdado da classe Mamifero

            Console.WriteLine("");    // Linha em branco para melhor visualização

            // Usando o objeto 'baleia' da classe Baleia
            Console.WriteLine("Baleia: ");
            baleia.Nadar();          // Método específico da classe Baleia
            baleia.Mamar();          // Método herdado da classe Mamifero
            baleia.Respirar();       // Método herdado da classe Mamifero

            Console.WriteLine("");    // Linha em branco para melhor visualização

            // Usando o objeto 'gato' da classe Gato
            Console.WriteLine("Gato: ");
            gato.Arranhar();         // Método específico da classe Gato
            gato.Mamar();            // Método herdado da classe Mamifero
            gato.Respirar();         // Método herdado da classe Mamifero
        }
    }

    // Classe base que representa um mamífero
    class Mamifero
    {
        // Método que simula o ato de respirar
        public void Respirar()
        {
            Console.WriteLine("Eu respiro!");
        }

        // Método que simula o ato de mamar
        public void Mamar()
        {
            Console.WriteLine("Eu mamo!");
        }
    }

    // Classe derivada que representa um humano, herda de Mamifero
    class Humano : Mamifero
    {
        // Método que simula o ato de falar
        public void Falar()
        {
            Console.WriteLine("Eu falo!");
        }
    }

    // Classe derivada que representa uma baleia, herda de Mamifero
    class Baleia : Mamifero
    {
        // Método que simula o ato de nadar
        public void Nadar()
        {
            Console.WriteLine("Eu nado!");
        }
    }

    // Classe derivada que representa um gato, herda de Mamifero
    class Gato : Mamifero
    {
        // Método que simula o ato de arranhar
        public void Arranhar()
        {
            Console.WriteLine("Eu arranho!");
        }
    }
}
