using System;
using System.Collections.Generic;
using System.Numerics;

namespace LargestPrimeConsoleUi
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Opdrachtomschrijving: Vind de grootste priemfactor voor het opgegeven getal.
            
            // Het basisgetal is te groot voor ints -> BigInt
            BigInteger basis = 600851475143;
            //BigInteger smallerBasis = GetSmallerPartOfBase(basis,10000);

            // NEE KIJK NAAR PRIEMGETALLEN

            BigInteger answer = new BigInteger();
            // zoek deler het dichtste bij de helft van het te delen getal
            // een deler is een getal waarvan bij deling de rest 0 is.
            // Exact de helft kan niet want dan is het getal deelbaar door 2, 1 en zichzelf ( tenzij het 2 is maar het gaat om grote getallen)
            //for(BigInteger i = smallerBasis-1;i > 0;i--)
            //{
            //    if(IsDivisor(basis,i))
            //    {
            //        Console.WriteLine($"deler: {i}");
            //        // kijk na of het een priemgetal is - Priemgetal is enkel deelbaar door zichzelf en 1
            //        if(IsPrime(basis,i))
            //        {
            //            Console.WriteLine($"prime: {i}");
            //            answer = i;
            //            break;
            //        }
            //        // Zoja, gevonden
            //        // Zonee, zoek naar de volgende deler
            //    }
            //    Console.WriteLine($"*{i}");
            //}

            FindAnswer(basis);

            //Console.WriteLine(answer);
            Console.ReadLine();

            #region Functions



            List<BigInteger> FindAnswer(BigInteger baseNumber)
            {
                List<BigInteger> output = new List<BigInteger>();
                List<BigInteger> primes = new List<BigInteger>();

                for (int i = 1; i < baseNumber; i++)
                {
                    if(baseNumber % i == 0)
                    {
                        output.Add(i);
                        Console.WriteLine($"Deler gevonden: {i}");

                        if(IsPrime(i))
                        {
                            primes.Add(i);
                            Console.WriteLine($"{i} is prime!");
                        }
                    }
                }

                return output;
            }

            #region Probeersels

            BigInteger GetSmallerPartOfBase(BigInteger baseNumber, decimal divisor)
            {
                decimal part = Math.Ceiling(((decimal)baseNumber / divisor));

                BigInteger output = new BigInteger(part);
                return output;
            }

            bool IsDivisor(BigInteger baseNumber, BigInteger testnumber)
            {
                if ((baseNumber % testnumber) != 0)
                    return false;
                else return true;
            }

            bool IsPrime(BigInteger baseNumber)
            {
                int divisorCounter = 0;
                for (BigInteger i = 1; i <= baseNumber; i++)
                {
                    if (IsDivisor(baseNumber, i))
                    {
                        divisorCounter++;
                    }

                    if (divisorCounter > 2)
                        return false;
                }
                return true;
            }  
            #endregion

            #endregion

        }
       
    }
}
