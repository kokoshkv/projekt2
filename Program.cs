using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace PrimeTest
{
    class Program
    {
        static ulong counter;
       // private static bool IsPrimeExample(BigInteger n)
       // {

            // counter = 1;
       //     if (n < 2) return false;
       //     else if (n < 4) return true;
       //     else if (n % 2 == 0) 
       //     { 
       //         return false; 
       //     }

       //     else
       //     {
       //         for (BigInteger i = 3; i < n / 2; i += 2)
       //        {
       //             counter++;
       //             if (n % i == 0) 
       //             {
       //                 return false;
       //             }
       //         }
       //     }

       //     return true;
       // }

        private static bool IsPrimeDecent(BigInteger n)
        {
            counter = 1;
            if (n < 2) return false;
            else if (n < 4) return true;
            else if (n % 2 == 0)
            {
                return false;
            }
            else
            {
                for (BigInteger i = 3; i * i <= n; i += 2)
                {
                    counter++;
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }


        static void Main(string[] args)
        {
            // *** Przykładowy ""
            // BigInteger[] LiczbyPierwsze = new BigInteger[] { 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399 };
            // Stopwatch Czas = new Stopwatch();
            // Czas.Reset();
            // Czas.Start();
            // for (int i = 0; i < LiczbyPierwsze.Length; i++)
            // {
            // * Przykładowy - Czas *
            // Console.WriteLine(IsPrimeExample(LiczbyPierwsze[i]));
            // Console.WriteLine("Liczba: " + LiczbyPierwsze[i]);
            // Console.WriteLine("Czas: "+Czas.ElapsedTicks);

            // * Przykładowy - Liczba operacji *
            // Console.WriteLine(IsPrimeExample(LiczbyPierwsze[i]));
            // Console.WriteLine("Liczba: " + LiczbyPierwsze[i]);
            //Console.WriteLine("Licznik: " + counter);

            // }
            // Czas.Stop();

            // ** Przyzwoity **

            BigInteger[] LiczbyPierwsze = new BigInteger[] { 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399 };
           // Stopwatch Czas = new Stopwatch();
           // Czas.Reset();
           // Czas.Start();
            for (int i = 0; i < LiczbyPierwsze.Length; i++)
            {
                // * Przyzwoity - Czas
              //  Console.WriteLine(IsPrimeDecent(LiczbyPierwsze[i]));
              //  Console.WriteLine("Liczba: " + LiczbyPierwsze[i]);
              //  Console.WriteLine("Czas: " + Czas.ElapsedTicks);

                // * Przyzwoity - Liczba operacji *
                Console.WriteLine(IsPrimeDecent(LiczbyPierwsze[i]));
                Console.WriteLine("Liczba: " + LiczbyPierwsze[i]);
                Console.WriteLine("Licznik: " + counter);

            }
           // Czas.Stop();
        }
    }
}