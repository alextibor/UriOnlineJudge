using System;
using System.Collections.Generic;
using System.Text;

namespace UriOlineJudge.Iniciante
{
    class Uri1013
    {
        public void Omaior()
        {
            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);

            int MaiorAB = (A + B + Math.Abs(A - B)) / 2;
            
            if (MaiorAB == A && MaiorAB > C)
            {
                Console.WriteLine(A + " eh o maior");
            }
            else if (MaiorAB == B && MaiorAB > C)
            {
                Console.WriteLine(B + " eh o maior");
            }
            else
            {
                Console.WriteLine(C + " eh o maior");
            }
        }
    }
}
