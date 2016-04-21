/*In combinatorics, the Catalan numbers are calculated by the following formula: 
catalan-formula (2n)!/((n+1)!*n!)
Write a program to calculate the Nth Catalan number by given N*/
using System;
using System.Numerics;

public class CatalanNumbers
{
    public static void Main()
    {
        BigInteger numberN = BigInteger.Parse(Console.ReadLine());
        BigInteger firstFactorial = 1;
        BigInteger secondFactorial = 1;

        /// (2*N)!=1*2*3..*N*(N+1)..*(2*N-1)(2*N) and  N! = 1*2*3.....*K =>
        /// (2*N)!/(N+1)*N! = ( (N+1)*(N+2)..*(2*N))/(N+1)!
        for (BigInteger i = numberN + 1; i <= 2 * numberN; i++)
        {
            firstFactorial *= i;
            secondFactorial *= i - numberN + 1;
        }

        BigInteger numberOfCombinations = firstFactorial / secondFactorial;
        Console.WriteLine(numberOfCombinations);
    }
}

/*
 * namespace _08.Catalan_Numbers
{
    using System;
    using System.Numerics;

    public class CatalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result;

            result = (Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n));
            Console.WriteLine(result);
        }

        public static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = n; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
 * 
 * using System;
using System.Numerics;

class NthCatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (1 <= n && n <= 100)
        {
            BigInteger numerator = 1;

            for (int i = 1; i <= (2 * n); i++)
            {
                // (2*n)!
                numerator *= i; 
            }

            BigInteger denominator = 1;

            for (int i = 1; i <= (n + 1); i++)
            {
                // (n+1)!
                denominator *= i;
            }

            for (int i = 1; i <= n; i++)
            {
                // n!
                denominator *= i;
            }

            Console.WriteLine(numerator / denominator);
        }
        else            // n == 0
        {
            Console.WriteLine(1);
        }

    }
}
 * 
using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a Catalan number:");
        int n = int.Parse(Console.ReadLine());

        BigInteger divident = 1;
        BigInteger divider = 1;
        if (n > 0 && n < 100)
        {
            for (int i = 2 * n; i > n + 1; i--)
            {
                divident *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                divider *= i;
            }
            BigInteger result = divident / divider;
            Console.WriteLine("The {0} Catalan number is: {1}", n, result);
        }
        else
        {
            Console.WriteLine("The number must be bigger than zero");
        }
    }
}
*/