using System;

    class PrimeNumberCheck
    {

        static void Main(string[] args)
        {
        Console.Write("Enter positive integer number here (between 0 and 100) to check if is prime \nn = ");
        int n = int.Parse(Console.ReadLine());
        int numberDividers = 0;

        if ((n < 0) || (n > 100))
        {
            Console.WriteLine("You have entered invaled number. \nPlease try again using positive number(n <= 100).");
        }

        else
        {
            if (n != 1)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        numberDividers = numberDividers + 1;

                    }
                    else
                    {
                        numberDividers = numberDividers + 0;
                    }
                }

                if (numberDividers == 0)
                {
                    Console.WriteLine("The number {0} is prime.", n);
                }
                else
                {
                    Console.WriteLine("The number {0} isn NOT prime.", n, numberDividers);
                }
            }
            else
            {
                Console.WriteLine("The number {0} isn NOT prime by definition.", n);
        }
    }
        }
    }

/*08. Prime Check
Write a program that reads an integer N (which will always be less than 100 or equal) and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
 

namespace PrimeCheck
{
    using System;

    class Prime
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());

            bool isPrime = false;

            if (numberN > 1 && numberN < 101)
            {
                if (numberN == 2 || numberN == 3 || numberN == 5 || numberN == 7)
                {
                    isPrime = true;
                }
                else if (numberN % 2 != 0 && numberN % 3 != 0 && numberN % 5 != 0 && numberN % 7 != 0)
                {
                    isPrime = true;
                }
            }
            Console.WriteLine(isPrime.ToString().ToLower());
        }
    }
}
 
 * using System;

class Program
{
    static void Main()

        {
            Console.Write("Enter positive integer number here (between 0 and 100) to check if is prime \nn = ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = ((number % 2 > 0)
                && (number % 3 > 0) && (number % 5 > 0)
                && (number % 7 > 0)) || ((number == 2) || (number == 3)
                || (number == 5) || (number == 7));

            Console.WriteLine("The number is prime:");
            Console.WriteLine(isPrime);
        }
    }
 * */
