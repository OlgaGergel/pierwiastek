using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwiastek
{
    class Program
    {
       

        static void Main(string[] args)

        {
            double a, pierwiastek;
            try
            {
                Console.WriteLine("Ten program oblicza pierwiastek z podanej przez uzytownika liczbe");
                Console.WriteLine("Podaj liczbe a");
                a = int.Parse(Console.ReadLine());
                pierwiastek = Math.Sqrt(a);
                Console.WriteLine("pierwiastek = {0:#.##}", Math.Sqrt(a));
            }
            catch(FormatException)
            {
                Console.WriteLine("Nie wczytano liczby");
            }
            Console.ReadKey();



        }
    }
}
