using System;

namespace Prime.Services
{
   public class PrimeService
   {
      public bool IsPrime(int num)
      {
         // Assume true until proven false.
         bool isPrime = true;

         if (num <= 1)
         {
            isPrime = false;
         }
         else
         {
            for (int div = num / 2; div > 1; div -= 1)
            {
               if (num % div == 0)
               {
                  isPrime = false;
                  break;
               }
            }
         }

         return isPrime;
      }
   }
}
