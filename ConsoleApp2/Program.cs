using System;

namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammla är du?");
            int age = int.Parse(Console.ReadLine());
            if (age <= 16)
            {
                Console.WriteLine("Du är för ung");
            }
            else if (age >= 16 & age <= 20)
            {
                Console.WriteLine("Du är i rätt åldersgrupp");
            }
            else
            {
                Console.WriteLine("Du är för gammal");
            }
            
        }
    }
}