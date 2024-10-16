using System;

namespace Laço_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int contador = 1;
            do
            {
                Console.WriteLine(contador);
                contador++;
            }
            while (contador <= 50);
            */


            // PSEUDO-LOOP INFINITO: O código continua pedindo ao usuário para digitar números até que ele digite o número 10. Quando isso acontece, o loop se encerra e uma mensagem de fim é exibida.
            
            int contador;
            do
            {
                Console.WriteLine("Digite um número: ");
                contador = int.Parse(Console.ReadLine());
                Console.WriteLine("O número digitado foi: {0}", contador);
            }
            while (contador != 10);

            Console.WriteLine("Fim do loop!");
        }
    }
}
