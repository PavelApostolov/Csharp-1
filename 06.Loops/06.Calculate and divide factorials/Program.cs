using System;
using System.Numerics;

class FactorialDivision
{
    static void Main()
    {
        Console.WriteLine("Enter value of N > 1");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of K<n<100");
        int k = int.Parse(Console.ReadLine());

        BigInteger result = 1;
        if (1 < k && n > k && n < 100)
        {
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
        Console.WriteLine("N!/!K = {0}", result);
    }
}

/*
using System;
using System.Numerics;

public class CalculateAgainFactorial
{
    public static void Main()
    {
        BigInteger numberN = BigInteger.Parse(Console.ReadLine());
        BigInteger numberK = BigInteger.Parse(Console.ReadLine());

        BigInteger division = 1;

        /// N!=1*2*3..*K...*N and  K! = 1*2*3.....*K
        /// N!/K! = 1*2*3..*K*(K+1)...*N/1*2*3.....*K = (K+1)*(K+2)..*N
        for (BigInteger i = numberK + 1; i <= numberN; i++)
        {
            division *= i;
        }

        Console.WriteLine(division);
    }
}

    using System;

    public class CalculateAgain
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double result = 1;

            while (n - k >= 1)
            {
                result *= n;
                n--;
            }
            Console.WriteLine(result);
        }
    }
 
using System;
using System.Numerics;
class CalculateAgain
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            factorialK *= i;
        }
        Console.WriteLine(factorialN / factorialK);
    }
}
*/