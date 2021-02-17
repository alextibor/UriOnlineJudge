using System;
using System.Collections.Generic;
using System.Text;

namespace UriOlineJudge.Iniciante
{
    class Uri1019
    {
        public void ConversaoDeTempo()
        { 
            // 1 min = 60 seg e 1 hora = 60 minutos = 3600 seg.

            int Duracao, horas, minutos, segundos, resto;
            
            Duracao = int.Parse(Console.ReadLine());

            //Obtendo hora.
            horas = Duracao / 3600;
            //Obtendo minutos.
            resto = Duracao % 3600;
            minutos = resto / 60;
            //Obtendo segundo.
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
