using System;

namespace pierwszyprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj szerokość: ");
            string a = Console.ReadLine();
            Console.Write("Podaj wysokość: ");
            string b = Console.ReadLine();

            int x = int.Parse(a);
            int y = int.Parse(b);

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
