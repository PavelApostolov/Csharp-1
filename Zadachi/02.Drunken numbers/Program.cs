/*
 * Problem 2 – Drunken Numbers
Everyone knows that the second most important thing in the programmer’s life is to write code, but the most important thing is to drink beer. Mitko and Vladko are very famous programmers. In the XIX world computer programming contest they faced each other. The contest consists of exactly N rounds. In each round both competitors must drink beer. Mitko and Vladko are very good programmers and that’s why they drink really a lot of beer. The judges are drunk too and can’t count how much beer is drunken by each competitor and determine the better programmer.
Mitko and Vladko decide to help the judges by giving them for each round an integer number called drunken number. The drunken number consists of no more than nine significant digits. The sum of the left digits of drunken number represents drunken beers by Mitko and the sum of the right digits of drunken number represents drunken beers by Vladko. For example number 1234 means that Mitko drank 1 + 2 = 3 beers and Vladko 3 + 4 = 7 beers. If the drunken number consists of odd number of digits, the middle digit is shared between both competitors. For example number 123 means that Mitko drank 1 + 2 = 3 beers and Vladko 2 + 3 = 5 beers. Drunken number’s leading zeros aren’t significant and should be ignored (e.g. 00789 must be processed as 789).
Drunken beers from each round are summed. The winner in the competition is the one who drank more beers. If both drank the same number of beers there is no winner. 
Your task is to write a program that computes and compares all drunken beers by both competitors and help judges to determine who the better programmer is. 
Input
The input data should be read from the console.
The number or rounds N is given on the first input line.
An each of the next N lines one number is given – the drunken number for the corresponding round.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
On the only output line your program should print the first letter of the winner’s name (“M” for Mitko and “V” for Vladko) and a space followed by a number representing how much more beers the winner has drank. If there is no winner print “No” followed by a space and the total drunken beers.
Constraints
•	1 ≤ N ≤ 100.
•	All drunken numbers will be integers and will contain no more than 9 significant digits. 
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
*/

using System;

    class DrunkenNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long m = 0;
            long v = 0;

            for (int i = 0; i < n; i++)
            {
                long roundInfo = long.Parse(Console.ReadLine());
                if (roundInfo < 0)
                {
                    roundInfo = -roundInfo;
                }

                int digits = 0;
                long tempRoundInfo = roundInfo;
                while (tempRoundInfo > 0) ;
                {
                    tempRoundInfo /= 10;
                    digits++;
                }
                if (digits % 2 == 0)
                {
                    for (int j = 0; j < digits / 2; j++)
                    {
                        v += roundInfo % 10;
                        roundInfo /= 10;
                    }
                    for (int j = 0; j < digits / 2; j++)
                    {
                        m += roundInfo % 10;
                        roundInfo /= 10;
                    }
                }
                        else
                        {
                        for (int j = 0; j < digits / 2; j++)
                    {
                        v += roundInfo % 10;
                        roundInfo /= 10;
                        }
                    long middle = roundInfo % 10;
                    v += middle;
                    m += middle;
                    roundInfo /= 10;
                    }
                        for (int j = 0; j < digits / 2; j++)
                    {
                        m += roundInfo % 10;
                        roundInfo /= 10;
                    }
                }
            }
    }
         if (m > v)
    {
        Console.WriteLine ("M {0}", m - v);
    }
    else if (m < v)
    {
        Console.WriteLine ("V {0}", v - m);

    }
