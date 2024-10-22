using System;

namespace Modificador_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal.Mensagem(); // Executa o método estático Menssagem, não precisando instanciar a classe.
                               // É só usar a Nome_Classe.Nome_Método.

            
            
            
            // Executando o método estático PI da classe Math.
            double Pi;
            Pi = Math.PI;
            Console.WriteLine(Pi.ToString());
        }

    }
}
