﻿/*
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
            bool foundNumber = false;

            for (int i= 1000; i <= 9999; i++)
            {
                int currentBulls = 0;
                int currentCows = 0;
                int currentNumber = i;

                int currentD = currentNumber % 10;
                currentNumber /= 10;
                int currentC = currentNumber % 10;
                currentNumber /= 10;
                int currentB = currentNumber % 10;
                currentNumber /= 10;
                int currentA = currentNumber % 10;
                currentNumber /= 10;

                if (currentA==0 || currentB == 0 || currentC == 0 || currentD == 0)
                {
                    continue;
                }

                int tempGuessNumber = guessNumber; //за да не е 0
                int guessNumberD = tempGuessNumber % 10;
                tempGuessNumber/= 10;
                int guessNumberC = tempGuessNumber % 10;
                tempGuessNumber/= 10;
                int guessNumberB = tempGuessNumber% 10;
                tempGuessNumber /= 10;
                int guessNumberA = tempGuessNumber% 10;
                tempGuessNumber /= 10;

                if (currentA==guessNumberA)
                {
                    currentBulls++;
                    currentA = -1; //за да не го използваме
                    guessNumberA = -2;
                }
                if (currentB == guessNumberB)
                {
                    currentBulls++;
                    currentB = -1; //за да не го използваме
                    guessNumberB = -2;
                }
                if (currentC == guessNumberC)
                {
                    currentBulls++;
                    currentC = -1; //за да не го използваме
                    guessNumberC = -2;
                }
                if (currentD == guessNumberD)
                {
                    currentBulls++;
                    currentA = -1; //за да не го използваме
                    guessNumberD = -2;
                }
                if (currentA ==guessNumberB)
                {
                    currentCows++;
                    currentA = -1;
                    guessNumberB = -2;
                }

                if (currentA == guessNumberC)
                {
                    currentCows++;
                    currentA = -1;
                    guessNumberC = -2;
                }

                if (currentA == guessNumberD)
                {
                    currentCows++;
                    currentA = -1;
                    guessNumberD = -2;
                }

                if (currentB == guessNumberA)
                {
                    currentCows++;
                    currentB = -1;
                    guessNumberA = -2;
                }

                if (currentB == guessNumberC)
                {
                    currentCows++;
                    currentB = -1;
                    guessNumberC = -2;
                }

                if (currentB == guessNumberD)
                {
                     currentCows++;
                     currentB = -1;
                     guessNumberD = -2;
                }

                if (currentC == guessNumberA)
                {
                    currentCows++;
                    currentC = -1;
                    guessNumberA = -2;
                }

                if (currentC == guessNumberB)
                {
                    currentCows++;
                    currentC = -1;
                    guessNumberB = -2;
                }

                if (currentC == guessNumberD)
                {
                    currentCows++;
                    currentC = -1;
                    guessNumberD = -2;
                }

                if (currentD == guessNumberA)
                {
                    currentCows++;
                    currentD = -1;
                    guessNumberA = -2;
                }

                if (currentD == guessNumberB)
                {
                    currentCows++;
                    currentD = -1;
                    guessNumberB = -2;
                }

                if (currentD == guessNumberC)
                {
                    currentCows++;
                    currentD = -1;
                    guessNumberC = -2;
                }


                if (currentBulls == bulls && currentCows == cows)
                {
                    foundNumber = true;
                    Console.Write(" {0}", i);
                }
            }
            if (foundNumber == false)//if (!foundNumber)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine();
            }

        }
    }
