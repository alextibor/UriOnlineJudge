using System;
using System.Collections.Generic;
using System.Text;

namespace UriOlineJudge.Iniciante
{
    class Uri1020
    {
        public void IdadeEmDias()
        { //10110
            int diasTotal, ano, meses, dias, restoMeses, restoAno;

            diasTotal = int.Parse(Console.ReadLine());

            //Calcular ano
            ano = diasTotal / 365;
            restoAno = diasTotal % 365;
            //Calcular meses
            meses = restoAno / 30;
            restoMeses = restoAno % 30;
            //Calcular dias
            dias = restoMeses;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
