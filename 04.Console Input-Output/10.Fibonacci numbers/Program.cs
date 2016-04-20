/*10. Fibonacci Numbers
Description
Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence (at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Input
On the only line you will receive the number N
Output
On the only line you should print the first N numbers of the sequence, separated by ", " (comma and space)
Constraints
1 <= N <= 50
N will always be a valid positive integer number
Time limit: 0.1s
Memory limit: 16MB
 */

namespace FibonacciNumbers
{
    using System;

    class FibonacciNums
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long currentNumber;
            long firstNumber = 0;
            long secondNumber = 1;

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    currentNumber = firstNumber;
                }
                else if (i == 1)
                {
                    currentNumber = secondNumber;
                }
                else
                {
                    currentNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = currentNumber;
                }

                if (i < n - 1)
                {
                    Console.Write("{0}, ", currentNumber);
                }
                else
                {
                    Console.Write(currentNumber);
                }

            }

            //int n = int.Parse(Console.ReadLine());
            //
            //int firstNumber = 0;
            //int secondNumber = 1;
            //int sum;
            //
            //for (int i = 0; i < n; i++)
            //{
            //    //if (i < n)
            //    //{
            //    //    Console.Write("{0}, ", firstNumber);
            //    //}
            //    //else if (i == n - 1)
            //    //{
            //    //    Console.Write("{0}", firstNumber);
            //    //}
            //
            //    Console.Write("{0}, ", firstNumber);
            //
            //    sum = firstNumber + secondNumber;
            //    firstNumber = secondNumber;
            //    secondNumber = sum;
            //}
        }
    }
}

/*
        int length = int.Parse(Console.ReadLine());
        long current;
        long previous = 1;
        long beforePrevious = 0;
        for (int i = 0; i < length; i++)
        {
            if (i == 0)
            {
                current = beforePrevious;
            }
            else if (i == 1)
            {
                current = previous;
            }
            else
            {
                current = beforePrevious + previous;
                beforePrevious = previous;
                previous = current;
            }
            if (i < length - 1)
            {
                Console.Write("{0}, ", current);
            }
            else
            {
                Console.Write(current);
            }
        }

 using System;

class FibonacciNumbers
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        if (n > 0)
        {
            Console.Write("0"); // prints the first member of the Fibonacci sequence
        }

        if (n > 1)
        {
            Console.Write(", 1"); // prints the second member of the Fibonacci sequence    
        }

        if (n > 2)
        {
            long memberN = 0;
            long memberNplus1 = 1;
            for (int i = 3; i <= n; i++)
            {
                long memberNplus2 = memberN + memberNplus1;
                Console.Write(", {0}", memberNplus2); // prints the i-member of the Fibonacci sequence
                memberN = memberNplus1;
                memberNplus1 = memberNplus2;
            }
        }
    }
}
 
 */