﻿/* Problem 14. Bit Exchange
   Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console). On the only input line you will receive the valid 32-bit unsigned integer number whose bits you must exchange. On the only output line print the value of the integer with the exchanged bits.  
    |     Input  |         Binary representation       | Binary representation after exchange|   Output   |
    |------------|-------------------------------------|-------------------------------------|------------|
    |1140867093  |01000100 00000000 01000000 00010101  |01000010 00000000 01000000 00100101  |1107312677  |
    |255406592   |00001111 00111001 00110010 00000000  |00001000 00111001 00110010 00111000  |137966136   |
    |4294901775  |11111111 11111111 00000000 00001111  |11111001 11111111 00000000 00111111  |4194238527  |
    |5351        |00000000 00000000 00010100 11100111  |00000100 00000000 00010100 11000111  |67114183    |
    |2369124121  |10001101 00110101 11110111 00011001  |10001011 00110101 11110111 00101001  |2335569705  |  */

using System;

class ExchangeBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int positionOne = 3;
        int positionTwo = 24;

        int maskOne = 7 << positionOne;
        int maskTwo = 7 << positionTwo;

        int getNumbersOne = number & maskOne;
        int getNumbersTwo = number & maskTwo;
        int change = (number & ~maskOne) & ~maskTwo;

        int maskThree = (getNumbersOne >> positionOne) << positionTwo;
        int maskFour = (getNumbersTwo >> positionTwo) << positionOne;
        int result = (change | maskThree) | maskFour;

        Console.WriteLine(result);
    }
}
