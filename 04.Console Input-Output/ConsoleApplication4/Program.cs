using System;

    class Program
    {
        static void Main()
        {
            // Input
            Console.WriteLine("Enter an integer a:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a floating-point b:");
            double secondNumnber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a floating-point c:");
            double thirdNumber = double.Parse(Console.ReadLine());

            // Printing the first number in HEX and Binary
            Console.Write("|" + Convert.ToString(firstNumber, 16).PadRight(10, ' ').ToUpper());
            Console.Write("|" + Convert.ToString(firstNumber, 2).PadLeft(10, '0') + "|");

            // Printing the second number with 2 digits after the decimal point, right aligned
            Console.Write("{0, 10:F2}" + "|", secondNumnber);

            // Printing the third number 3 digits after the decimal point, left aligned
            Console.WriteLine("{0, -10:F3}" + "|", thirdNumber);
        }
    }
