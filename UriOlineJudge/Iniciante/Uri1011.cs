using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace UriOlineJudge.Iniciante
{
    class Uri1011
    {
        public void Esfera()
        {
            double R, V, pi = 3.14159;

            R = double.Parse(Console.ReadLine());
            V = (4.0 / 3) * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + V.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
