using System;

namespace Modificador_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal.Mensagem(); // Executa o método estático Menssagem, não precisando instanciar a classe.
        }                      // É só usar a classe.método.
    }
}
