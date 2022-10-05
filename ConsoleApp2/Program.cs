using System;

namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur länge hade du tänkt hyra bilen? timmar ");
            int svar = int.Parse(Console.ReadLine());
            int pris = svar * 80;
            if (pris > 950)
            {
                pris = 950;
            }
            Console.WriteLine("Bilen kommer att kosta " + pris + " kronor. ");

        }
    }
}
