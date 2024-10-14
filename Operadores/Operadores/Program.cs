using System;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Operadores de Atribuição
             =, +=, -=, *=, /*

            int var01;
            var01 = 50;
            Console.WriteLine("Atribuição:  {0}", var01);
            var01 += 20;
            Console.WriteLine("Acumulando: {0}", var01);
            var01 *= 2;
            Console.WriteLine("Multiplicando: {0}", var01);
            */

            // Operadores de Incremento e Decremento

            // Incremento e Decremento Pré-fixos:
            // ++variável | variável = variável + 1 |  variável += 1
            // --variável |  variável = variável - 1 |  variável -= 1

            //Incremento e Decremento Pós- fixos:
            //variável++   |  variável = variável + 1  |   variável += 1
            //variável--   |  variável = variável - 1  |   variável -= 1

            //PÓS-FIXO
            int contador;
            contador = 50;
            Console.WriteLine(contador);
            Console.WriteLine(contador++);
            Console.WriteLine(contador);

            Console.WriteLine("---------------------------------\n");

            //PRÉ-FIXO
            contador = 50;
            Console.WriteLine(contador);
            Console.WriteLine(++contador);
            Console.WriteLine(contador);
        }
    }
}
