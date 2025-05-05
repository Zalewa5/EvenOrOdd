using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            var number = GetInput();

            if (number % 2 == 0)
            {
                Console.WriteLine("Liczba parzysta");
            }
            else
            {
                Console.WriteLine("Liczba nieparzysta");
            }

            Console.ReadLine();
        }

        private static int GetInput() 
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out var number))
                {
                    Console.WriteLine("\nSpróbuj ponownie");
                    continue;
                }
                return number;
            }
        }
    }
}
