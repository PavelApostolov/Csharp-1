using System;

class Get3rdBit
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        //Console.WriteLine("Binary representation: {0}", Convert.ToString(number, 2).PadLeft(16, '0'));

        uint numberRight3 = number >> 3;
        uint bit3 = numberRight3 & 1;
        Console.WriteLine(bit3); 
    }
}

/* 
using System;

class Bitwise
{
    static void Main()
    {
        Console.WriteLine("Enter the integer number:");
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine("Third bit of the number has value: " + bit);
    }
}
 * 
 *     using System;

    class ThirdBit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string numberToBinary = Convert.ToString(number, 2).PadLeft(32, '0');
            int length = numberToBinary.Length;
            var result = numberToBinary[length - 4];

            Console.WriteLine(result);

        }
    }
*/