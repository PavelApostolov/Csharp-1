using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter Binary number: ");
        string binaryNumber = Console.ReadLine();

        int count = binaryNumber.Length - 1;
        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            decimalNumber += long.Parse(binaryNumber[i].ToString()) * (long)Math.Pow(2, (count - i));
        }

        Console.WriteLine(decimalNumber);
    }
}

/*
using System;

class BinaryToDecimal
{
    static void Main()
    {
        //Console.Write("Enter a binary number (consisted of 0 and 1): ");
        string binaryNumber = Console.ReadLine();

        //long numDec = Convert.ToInt64(binaryNumber, 2);
        //Console.WriteLine(numDec);   

        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[binaryNumber.Length - i - 1] == '1')
            {
                decimalNumber += (long)Math.Pow(2, i);
            }
        }

        Console.WriteLine(decimalNumber);
    }
}
*/