using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace UriOlineJudge.Iniciante
{
    class Uri1010
    {
        public void CalculoSimples()
        {
            int cod1, num1, cod2, num2;
            double preco1, preco2, total;

            string[] Peca1 = Console.ReadLine().Split(' ');
            cod1 = int.Parse(Peca1[0]);
            num1 = int.Parse(Peca1[1]);
            preco1 = double.Parse(Peca1[2], CultureInfo.InvariantCulture);

            string[] Peca2 = Console.ReadLine().Split(' ');
            cod2 = int.Parse(Peca2[0]);
            num2 = int.Parse(Peca2[1]);
            preco2 = double.Parse(Peca2[2], CultureInfo.InvariantCulture);

            total = num1 * preco1 + num2 * preco2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
