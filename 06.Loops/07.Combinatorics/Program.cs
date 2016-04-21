/*In combinatorics, the number of ways to choose N different members out of a group of N 
different elements (also known as the number of combinations) is calculated by the following 
formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard 
deck of 52 cards. Your task is to write a program that calculates N! / (K! * (N - K)!) for 
given N and K.
Try to use only two loops.*/
using System;
using System.Numerics;

public class CalculateThreeFactorial
{
    public static void Main()
    {
        BigInteger numberN = BigInteger.Parse(Console.ReadLine());
        BigInteger numberK = BigInteger.Parse(Console.ReadLine());
        BigInteger firstFactorial = 1;
        BigInteger secondFactorial = 1;

        for (BigInteger i = numberK + 1; i <= numberN; i++)
        {
            firstFactorial *= i;
            secondFactorial *= i - numberK;
        }

        BigInteger numberOfCombinations = firstFactorial / secondFactorial;
        Console.WriteLine(numberOfCombinations);
    }
}

/*
using System;
using System.Numerics;

class Combinations
{
    static void Main()
    {
        Console.WriteLine("Enter value of N > 1");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of K<n<100");
        int k = int.Parse(Console.ReadLine());

        BigInteger fact1 = 1;
        BigInteger fact2 = 1;

        if (1 < k && n > k && n < 100)
        {
            for (int i = k + 1; i <= n; i++)
            {
                fact1 *= i;
            }
            for (int j = 1; j <= (n - k); j++)
            {
                fact2 *= j;
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
        BigInteger result = fact1 / fact2;
        Console.WriteLine("N! / K!(N-K)! = {0}", result);
    }
}
 * 
 * using System;
using System.Numerics; 

class CalculateCombinaions
{
    static void Main()
    {
        //Console.Write("Enter an integer number n: 1 < n < 100   n= ");
        int n = int.Parse(Console.ReadLine());
        //Console.Write("Enter an integer number k: 1 < k < {0}   k= ", n);
        int k = int.Parse(Console.ReadLine());

        //if (1 < k && k < n && n < 100)
        //{

            BigInteger numerator = 1;
            BigInteger denominator = 1;

            for (int i = k + 1; i <= n; i++)
            {
                numerator *= i;
            }

            for (int j = 2; j <= (n - k); j++)
            {
                denominator *= j;
            }

            BigInteger result = numerator / denominator;
            Console.WriteLine(result);

        //}
        //else
        //{
        //    Console.WriteLine("Invalid input!");
        //}
    }
}
*/