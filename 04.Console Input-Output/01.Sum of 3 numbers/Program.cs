using System;

    class SumOf3Numbers
    {
        static void Main()
        {
        Console.WriteLine("Enter first number here: ");
        int numberFirst = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number here: ");
        int numberSecond = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number here: ");
        int numberThird = int.Parse(Console.ReadLine());

        int sum = numberFirst + numberSecond + numberThird;

        Console.WriteLine("Thse sum of entered three numbers is: {0}", sum);
        }
    }
