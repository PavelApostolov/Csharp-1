/*You are given a list of N numbers.
Get the most right 30 bits of every number and concatenate them.
Write a program to find the length of the longest sequence of zeroes and the length of the longest sequence of ones from the obtained concatenated sequence.
See examples for clarification.
Input
The input data should be read from the console.
On the first line there will be the number N.
On each of the next N lines there will be a number from the list.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
On the first output line print the length of the longest sequence of zeroes.
On the third output line print the length of the longest sequence of ones.
*/

using System;
namespace BitsToBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxZeroCount = 0;
            int currZeroCount = 0;

            int maxOneCount = 0;
            int currOneCount = 0;

            int lastBit = 5;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                for (int j = 29; j >= 0; j--) //чете от 29 бит до нулевия
                {
                    int bit = ((1 << j) & num) >> j;

                    if (bit == 1)
                    {
                        if (lastBit == 1)
                        {
                            currOneCount++;
                            maxOneCount = Math.Max(maxOneCount, currOneCount);
                        }
                        else
                        {
                            currZeroCount = 0;
                            currOneCount = 1;
                        }
                    }
                    else // bit == 0
                    {
                        if (lastBit == 0)
                        {
                            currZeroCount++;
                            maxZeroCount = Math.Max(maxZeroCount, currZeroCount);
                        }
                        else
                        {
                            currOneCount = 0;
                            currZeroCount = 1;
                        }
                    }

                    lastBit = bit;
                }
            }

            Console.WriteLine(maxZeroCount);
            Console.WriteLine(maxOneCount);
        }
    }
}