using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace UriOlineJudge.Iniciante
{
    class Uri1014
    {
        public void Consumo() {

            int KMtotal = int.Parse(Console.ReadLine());
            double Gas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double KML = KMtotal / Gas;

            Console.WriteLine(KML.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
