using System;
using System.Dynamic;

namespace Projekt1
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
               
            Console.WriteLine(x + " " + y);

            Console.ReadKey();
           
        }
    }
}
