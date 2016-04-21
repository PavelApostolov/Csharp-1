﻿/* 16. Trailing Zeroes in N!
   Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
   Your program should work well for very big numbers, e.g. N = 100000.
   On the only input line, you will receive a single integer - the number N
   Output a single number - the count of trailing zeroes for the N!
   Constraints: N will always be a valid positive integer number. */

//The simple method is to first calculate factorial of number, then count trailing 0s in the result.

using System;

class ZeroesInTheEndOfFactorialFaster
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int counterZeroes = 0;

        if (number == 5)
        {
            counterZeroes = 1;
        }
        else
        {
            // first way
            for (int i = 5; number / i >= 1; i *= 5)
            {
                counterZeroes += number / i;
            }

            // second way
            //for (int power5 = 5; power5 <= number; power5 *= 5)
            //{
            //    counterZeroes += number / power5;
            //}
        }

        Console.WriteLine(counterZeroes);
    }
}

/*using System;
using System.Numerics;
using System.Text.RegularExpressions;

public class TralingZeroInNFactorial
{
    public static void Main()
    {
       int number = int.Parse(Console.ReadLine());
                  
            int zerosCounter = 0;
            int divider = 5;
            while (number / divider >= 1)
            {
                zerosCounter += number / divider;
                divider *= 5;
            }

            Console.WriteLine(zerosCounter);
    }
}
 * */
