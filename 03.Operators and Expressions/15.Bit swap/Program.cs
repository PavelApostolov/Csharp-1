/* Problem 15. Bit Swap (Advanced Bit Exchange)
   Write a program first reads 4 numbers n, p, q and k and then swaps bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit positive integer n. Print the resulting integer on the console. On the only four lines of the input you will receive the integers n, p, q and k in this order. Output a single value - the value of n after the bit swaps.
    |     Input                     |     Binary representation          |  Binary representation after swaps |   Output    |
    |-------------------------------|------------------------------------|------------------------------------|-------------|
    |1140867093<br/>3<br/>24<br/>3  |01000100 00000000 01000000 00010101 |01000010 00000000 01000000 00100101 |1107312677   |
    |4294901775<br/>24<br/>3<br/>3  |11111111 11111111 00000000 00001111 |11111001 11111111 00000000 00111111 |4194238527   |
    |2369124121<br/>2<br/>22<br/>10 |10001101 00110101 11110111 00011001 |01110001 10110101 11111000 11010001 |1907751121   |*/

using System;

class SwapBit
{
    static void Main()
    {
        uint numberN;
        bool checkUInteger = uint.TryParse(Console.ReadLine(), out numberN);

        if (checkUInteger == false)
        {
            Console.WriteLine("Out of unsigned integer range!");
        }
        else
        {
            int numberP = int.Parse(Console.ReadLine());
            int numberQ = int.Parse(Console.ReadLine());
            int numberK = int.Parse(Console.ReadLine());
            int lenght = Math.Min(numberP, numberQ) + numberK;

            if (Math.Min(numberP, numberQ) + numberK >= Math.Max(numberP, numberQ))
            {
                Console.WriteLine("Overlapping!");
            }
            else if (numberP < 0 || numberQ < 0 || numberP + numberK > 32 || numberQ + numberK > 32)
            {
                Console.WriteLine("Out of range!");
            }
            else
            {
                for (; Math.Min(numberP, numberQ) < lenght; numberP++, numberQ++)
                {
                    uint mask1 = (uint)(numberN & 1 << numberP);
                    uint mask2 = (uint)(numberN & 1 << numberQ);

                    if (mask1 != 0)
                    {
                        numberN = numberN | (uint)(1 << numberQ);
                    }
                    else
                    {
                        numberN = numberN & (uint)(~(1 << numberQ));
                    }

                    if (mask2 != 0)
                    {
                        numberN = numberN | (uint)(1 << numberP);
                    }
                    else
                    {
                        numberN = numberN & (uint)(~(1 << numberP));
                    }
                }

                Console.WriteLine(numberN);
            }
        }
    }
}
