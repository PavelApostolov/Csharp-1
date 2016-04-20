using System;

    class NumberComparer
    {
        static void Main()
        {
        Console.WriteLine("Please enter 2 numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("The greater numbers is: ");
        Console.WriteLine(Math.Max(a, b));
        }
    }
