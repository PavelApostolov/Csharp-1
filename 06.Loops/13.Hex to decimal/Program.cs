using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a hexadecimal integer number :");
        string hex = Console.ReadLine();
        long number = 0;
        long power = 1;

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            int sign;
            switch (hex[i])
            {
                case 'A': sign = 10;
                    break;
                case 'B': sign = 11;
                    break;
                case 'C': sign = 12;
                    break;
                case 'D': sign = 13;
                    break;
                case 'E': sign = 14;
                    break;
                case 'F': sign = 15;
                    break;
                default: sign = hex[i] - 48;
                    break;
            }
            number += sign * power;
            power *= 16;
        }
        Console.WriteLine(number);
    }
}

/*
using System;

class HexToDecimal
{
    static void Main()
    {
        //Console.Write("Enter a hexadecimal number: ");
        string hexNumber = Console.ReadLine();

        //Console.WriteLine(Convert.ToInt64(hexNumber, 16));

        long decimalNumber = 0;

        for (int i = 0; i < hexNumber.Length; i++)
        {
            int multiplier;

            switch (hexNumber[hexNumber.Length - i - 1])
            {
                case 'A': multiplier = 10; break;
                case 'B': multiplier = 11; break;
                case 'C': multiplier = 12; break;
                case 'D': multiplier = 13; break;
                case 'E': multiplier = 14; break;
                case 'F': multiplier = 15; break;
                default: multiplier = int.Parse(hexNumber[hexNumber.Length - i - 1].ToString()); break;
                //default: multiplier = (int)hexNumber[hexNumber.Length - i - 1] - 48; break; // other way for default
            }

            decimalNumber += multiplier * (long)Math.Pow(16, i);
        }

        Console.WriteLine(decimalNumber);

    }
}
*/