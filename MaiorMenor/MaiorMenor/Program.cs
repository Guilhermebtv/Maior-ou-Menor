using System;

namespace MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n1 = 0;
            int n2 = 0;

            Console.Write("Primeiro valor inteiro = ");
            int.TryParse(Console.ReadLine(), out n1);

            Console.Write("Segundo valor inteiro = ");
            int.TryParse(Console.ReadLine(), out n2);

            Console.WriteLine($"O maior valor entre {n1} e {n2} é {MathF.Max(n1, n2)}");
            Console.WriteLine($"O menor valor entre {n1} e {n2} é {MathF.Min(n1, n2)}");
            Console.ReadKey();
        }
    }
}
