using System;
using System.Globalization;

namespace cSharpTests
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] entrada = Console.ReadLine().Split(' ');

            double codigo = double.Parse(entrada[0]);
            double quantidade = double.Parse(entrada[1]);

            double total;

            if (codigo == 1)
            {
                total = 4.0 * quantidade;
            }
            else if (codigo == 2)
            {
                total = 4.5 * quantidade;
            }
            else if (codigo == 3)
            {
                total = 5.0 * quantidade;
            }
            else if (codigo == 4)
            {
                total =  2.0 * quantidade;
            }
            else
            {
                total = 1.5 * quantidade;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}