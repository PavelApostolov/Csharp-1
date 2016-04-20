using System;

    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Enter integers a, b and c:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 || a < 0 && b < 0 && c > 0 || a > 0 && b < 0 && c < 0 ||
                a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("The sign will be \"+\"");
            }
            else if (a < 0 && b > 0 && c > 0 || a > 0 && b < 0 && c > 0 || a > 0 && b > 0 && c < 0 ||
                a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("The sign will be \"-\"");
            }
            else
            {
                Console.WriteLine(0);
        }
    }
}

/*
using System;
using System.Globalization;
using System.Threading;

class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        int negativeNumbersCount = 0; // counter to keep the number of negative numbers 
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            if (a < 0)
            {
                negativeNumbersCount++;
            }
            if (b < 0)
            {
                negativeNumbersCount++;
            }
            if (c < 0)
            {
                negativeNumbersCount++;
            }

            if (negativeNumbersCount % 2 == 0)
            {
                //If the negative multiples are even number, the product is positive.
                Console.WriteLine("+");      
            }
            else
            {
                //If the count of the negative numbers is odd, the product is negative.
                Console.WriteLine("-");      
            }
        }
    }
}
*/