using System;

    class TrapezoidArea
    {
        static void Main()
        {
            Console.Write("Please enter trapezoid's side a = ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Please enter trapezoid's side b = ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Please enter trapezoid's height = ");
            double height = double.Parse(Console.ReadLine());
            double area = ((sideA + sideB) / 2) * height;
            Console.WriteLine("The area of trapezoid is {0}", area);
        }
    }
