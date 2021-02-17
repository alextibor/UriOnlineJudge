using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace UriOlineJudge.Iniciante
{
    class Uri1017
    {
        public void GastoDeCombustivel()
        {
            int tempo = int.Parse(Console.ReadLine());
            int VelMedia = int.Parse(Console.ReadLine());
            double Kml = 12;

            double Gas = (tempo * VelMedia) / Kml;

            Console.WriteLine(Gas.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
