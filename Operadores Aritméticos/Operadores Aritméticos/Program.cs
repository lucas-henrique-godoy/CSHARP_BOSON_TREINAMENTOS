using System;

class Program
{
    static void Main()
    {
        double a = 5.0;
        double b = 0.0;

        Console.WriteLine("Valor dividido por zero: " + (a / b));
        Console.WriteLine("Zero dividido por um valor qualquer: " + (b / a));
        Console.WriteLine("Zero dividido por zero: " + (b / b));
        Console.WriteLine("Soma de NaN com um valor qualquer, como 15: " + (15 + (b / b)));
        Console.WriteLine("Soma de Infinito com um valor qualquer, como 15: " + (15 + (a / b)));
        Console.WriteLine("Zero vezes Infinito: " + (0 * (a / b)));
        Console.WriteLine("Zero vezes NaN: " + (0 * (b / b)));

        Console.ReadKey();
    }
}
