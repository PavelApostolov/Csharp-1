﻿/* Problem 13. Modify Bit  
   We are given an integer number N(read from the console), a bit value v(read from the console as well) (v = 0 or 1) and a position P(read from the console). Write a sequence of operators (a few lines of C# code) that modifies N to hold the value v at the position P from the binary representation of N while preserving all other bits in N. Print the resulting number on the console.
   The input will consist of exactly 3 lines containing the following:
        First line - the integer number N.
        Second line - the position P.
        Third line - the bit value v.
   Output a single line containing the value of the number N with the modified bit.
   Constraints:
        N will always be a valid 64-bit unsigned integer.
        P will always be between in the range [0, 64).
        v will be always either 0 or 1.
        |     Input         |Binary representation|Modified value    |    Output     |
        |-------------------|---------------------|------------------|---------------|
        |5    <br/>2 <br/>0 |00000000 00000101    |00000000 00000001 |1              |
        |0    <br/>9 <br/>1 |00000000 00000000    |00000010 00000000 |512            |
        |15   <br/>1 <br/>1 |00000000 00001111    |00000000 00001111 |15             |
        |5343 <br/>7 <br/>0 |00010100 11011111    |00010100 01011111 |5215           |
        |62241<br/>11<br/>0 |11110011 00100001    |11110011 00100001 |62241          |  */

using System;

class ModifyPBitToValue
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());

        //Console.WriteLine("Binary representation: " + Convert.ToString(number, 2).PadLeft(16, '0'));

        if (value == 0)
        {
            ulong mask = (ulong)~(1 << position);
            ulong result = number & mask;
            //Console.WriteLine("Modified value:        " + Convert.ToString(result, 2).PadLeft(16, '0'));      
            Console.WriteLine(result);
        }
        else
        {
            ulong mask = (ulong)1 << position;
            ulong result = number | mask;
            //Console.WriteLine("Modified value:        " + Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine(result);
        }
    }
}

/*
    using System;

    class ModBit
    {
        static void Main()
        {
            ulong numberN = ulong.Parse(Console.ReadLine());
            int positionP = int.Parse(Console.ReadLine());
            byte valueV = byte.Parse(Console.ReadLine());
         
            ulong result;
            ulong mask = 1;

            if (valueV == 0)
            {
                result = ~(mask << positionP) & numberN;
            }
            else
            {
                result = numberN | mask << positionP;
            }

            Console.WriteLine(result);
        }
    }
*/