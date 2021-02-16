using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace UriOlineJudge.Iniciante
{
    class Uri1008
    {
        public void Salario()
        {
            int Number, Horas;
            double ValorHora, Salario;

            Number = int.Parse(Console.ReadLine());
            Horas = int.Parse(Console.ReadLine());
            ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salario = Horas * ValorHora;

            Console.WriteLine("NUMBER = " + Number);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
