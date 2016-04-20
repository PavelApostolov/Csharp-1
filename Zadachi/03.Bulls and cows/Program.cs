/*
 * Problem 3 – Bulls and Cows
All we love the “Bulls and Cows” game (http://en.wikipedia.org/wiki/Bulls_and_cows). Given a 4-digit secret number and a 4-digit guess number we say that we have b bulls and c cows when we have b matching digits on their right positions (bulls) and c matching digits on different positions (cows). Examples are given below:
Secret number	1	4	8	1	Bulls  = 1
Cows = 2		Secret number	2	2	4	9	Bulls  = 0
Cows = 3
Guess number	8	8	1	1			Guess number	9	9	2	4	
Given the secret number and the number of bulls and cows your task is to write a program to find all matching guess numbers in increasing order.
Input
The input data should be read from the console. It will consist of exactly 3 lines. At the first line there the secret number will be given. At the second line the number of bulls b will be given. At the third line the number of cows c will be given.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console. It should consist of a single line holding all matched guess numbers, given in increasing order, separated by single space.
Constraints
•	The secret number will always consist of exactly 4 digits, each in the range [1…9].
•	The numbers b and c will be in the range [0…9].
*/

using System;

    class Program
    {
        static void Main()
        {
            int guessNumber = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());

            for (int currentNumber = 1000; currentNumber < 9999; currentNumber++)
            {
                int currentBulls = 0;
                int currentCows = 0;

                if (currentBulls == bulls && currentCows == cows)
                {
                    Console.Write(" {0}");
                }
            }
        }
    }
