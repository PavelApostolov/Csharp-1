using System;

class DecimalToBinary
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        //Console.WriteLine(Convert.ToString(decimalNumber, 2));

        if (decimalNumber == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            string binaryNumber = ""; // the same like: string binaryNumber = null;         

            while (decimalNumber > 0)
            {
                int remainder = (int)decimalNumber % 2;
                binaryNumber = remainder + binaryNumber;
                decimalNumber /= 2;
            }

            Console.WriteLine(binaryNumber);
        }

    }
}

/*
using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter Decimal number:");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryNumber = String.Empty;
        if (decimalNumber != 0)
        {
            while (decimalNumber > 0)
            {
                binaryNumber += Convert.ToString(decimalNumber % 2);
                decimalNumber /= 2;
            }

            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(binaryNumber[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
*/