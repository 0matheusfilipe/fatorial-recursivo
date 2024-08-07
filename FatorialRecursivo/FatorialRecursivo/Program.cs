using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular fatorial de qual número?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Fatorial de {num} é {Fatorial(num)}");

            Console.ReadKey();
        }

        static int Fatorial(int num)
        {
            if (num <= 0)
            {
                return 1;
            }
            return num * Fatorial(num - 1);
        }
    }
}
