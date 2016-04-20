using System;

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