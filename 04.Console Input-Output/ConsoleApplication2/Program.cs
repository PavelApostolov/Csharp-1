using System;

    class CirclePerimeterArea
    {
        static void Main()
        {
            Console.Write("Please enter circle's radius: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * (r * r);
            double perimeter = Math.PI * (2 * r);
            Console.WriteLine("The area of the circle is: {0}\nThe perimeter of circle is {1}", area, perimeter);
        }
    }
