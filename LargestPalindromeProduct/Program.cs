using System;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            // palindroom leest hetzelfde in elke richting
            // grootste palindroom van het product van twee 3 cijferige getallen xxx * xxx = TxxxxT
            GetAnswer();

            Console.ReadLine();

            #region Functions

            void GetAnswer()
            {
                int startNumber = 999;
                int answer = 0;

                for(int i = 999; i > 0; i--)
                {
                    answer = startNumber * i;

                    if(IsPalindrome(answer))
                    {
                        Console.WriteLine($"{answer} is the greatest 3 digit product palindrone");
                    }
                    for (int j = 999; i > 0; j--)
                    {
                        answer = startNumber * i;

                        if (IsPalindrome(answer))
                        {
                            Console.WriteLine($"{answer} is the greatest 3 digit product palindrone");
                        }
                        startNumber--;
                    }
                }

            }

            bool IsPalindrome(int number)
            {
                string str = number.ToString();
                for(int i = 0, j=str.Length-1; i<3; i++)
                {
                    if (str[i] != str[j])
                    {
                        return false;
                    }
                    j--;
                }
                return true;
            }

            #endregion
        }
    }
}
