/// You are given N integers (given in a single line, separated by a space).
/// Write a program that checks whether the product of the odd elements is equal to the product of the
/// even elements.Elements are counted from 1 to N, so the first element is odd, the second is even, etc.
/// 

using System;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        var arrayOfNumbers = input.Split(' ');
        long oddSum = 1;
        long evenSum = 1;

        for (int i = 1; i < arrayOfNumbers.Length + 1; i++)
        {
            if (i % 2 != 0)
            {
                oddSum *= int.Parse(arrayOfNumbers[i - 1]);
            }
            else
            {
                evenSum *= int.Parse(arrayOfNumbers[i - 1]);
            }
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("yes {0}", evenSum);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddSum, evenSum);
        }
    }
}

/*
 *     static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        BigInteger oddProduct = 1;
        BigInteger evenProduct = 1;

        for (int i = 0; i < n; i += 2)    // i < splitNumbers.Length
        {
            oddProduct *= int.Parse(splitNumbers[i]);
        }

        for (int i = 1; i < n; i += 2)    // i < splitNumbers.Length
        {
            evenProduct *= int.Parse(splitNumbers[i]);
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }

    }
}*/
