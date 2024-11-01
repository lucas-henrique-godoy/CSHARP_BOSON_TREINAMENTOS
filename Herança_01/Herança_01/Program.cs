using System;

namespace Herança_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciando a classe base Mamífero
            Mamifero animal = new Mamifero();

            // Instanciando as classes derivadas que representam tipos específicos de mamíferos
            Humano homem = new Humano();   // Criando um objeto da classe Humano
            Baleia baleia = new Baleia();   // Criando um objeto da classe Baleia
            Gato gato = new Gato();         // Criando um objeto da classe Gato

            // Usando o objeto 'animal' da classe Mamifero
            Console.WriteLine("Animal:");
            animal.Mamar();          // Chamando método herdado de Mamifero para simular mamar
            animal.Respirar();       // Chamando método herdado de Mamifero para simular respirar

            Console.WriteLine("");    // Linha em branco para melhor visualização

            // Usando o objeto 'homem' da classe Humano
            Console.WriteLine("Humano: ");
            homem.Falar();           // Método específico da classe Humano que simula falar
            homem.Mamar();           // Método herdado da classe Mamifero para simular mamar
            homem.Respirar();        // Método herdado da classe Mamifero para simular respirar
            homem.Lutar();           // Método herdado que foi sobrescrito na classe Humano

            Console.WriteLine("");    // Linha em branco para melhor visualização

            // Usando o objeto 'baleia' da classe Baleia
            Console.WriteLine("Baleia: ");
            baleia.Nadar();          // Método específico da classe Baleia que simula nadar
            baleia.Mamar();          // Método herdado da classe Mamifero para simular mamar
            baleia.Respirar();       // Método herdado da classe Mamifero para simular respirar
            baleia.Lutar();          // Método herdado da classe Mamifero

            Console.WriteLine("");    // Linha em branco para melhor visualização

            // Usando o objeto 'gato' da classe Gato
            Console.WriteLine("Gato: ");
            gato.Arranhar();         // Método específico da classe Gato que simula arranhar
            gato.Mamar();            // Método herdado da classe Mamifero para simular mamar
            gato.Respirar();         // Método herdado da classe Mamifero para simular respirar
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

        // Método que pode ser sobrescrito em classes derivadas
        public virtual void Lutar()
        {
            Console.WriteLine("Mamíferos lutam entre si");
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

        // Sobrescrevendo o método Lutar da classe base
        public override void Lutar()
        {
            Console.WriteLine("Eu luto com armas!");
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
