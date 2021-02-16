using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace UriOlineJudge.Iniciante
{
    class Uri1009
    {
        public void SalarioComBonus()
        {
            string Nome;
            double SalarioFixo, TotalVendas, TotalReceber;

            Nome = Console.ReadLine();
            SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TotalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TotalReceber = SalarioFixo + (0.15 * TotalVendas);

            Console.WriteLine("TOTAL = R$ " + TotalReceber.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
