/*
Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
    Use the Euclidean algorithm
    The numbers A and B will always be valid integers in the range [2, 500].
*/
namespace _15.GCD
{
    using System;

    public class GCD
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            int a = Math.Abs(int.Parse(input[0]));
            int b = Math.Abs(int.Parse(input[1])); ;

            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                Console.WriteLine(b);
            else
                Console.WriteLine(a);
        }
    }
}

/*
        string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int firstNum = int.Parse(splitNumbers[0]);
        int secondNum = int.Parse(splitNumbers[1]);

        int numBigger = Math.Abs(firstNum);
        int numSmaller = Math.Abs(secondNum);

        if (numSmaller > numBigger)
        {
            // exchange the values - first way
            numSmaller += numBigger;
            numBigger = numSmaller - numBigger;
            numSmaller = numSmaller - numBigger;

            // exchange the values - second way
            //int helpingExchangeVar = numSmaller;
            //numSmaller = numBigger;
            //numBigger = helpingExchangeVar;
        }

        // first way
        int remainder = numBigger % numSmaller;
        while (remainder != 0)
        {
            numBigger = numSmaller;
            numSmaller = remainder;
            remainder = numBigger % numSmaller;
        }
        int gcd = numSmaller;

        // second way
        //while (numSmaller > 0)
        //{
        //    int remainder = numBigger % numSmaller;
        //    numBigger = numSmaller;
        //    numSmaller = remainder;
        //}
        //int gcd = numBigger;

        Console.WriteLine(gcd);
*/
