using System;
using Prime.Services;

namespace MyConsole
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Primes . . .");

         var prime = new PrimeService();

         for (int i = 1; i < 20; ++i)
         {
            Console.WriteLine($"i = {i}, prime = {prime.IsPrime(i)}");
         }
      }
   }
}
