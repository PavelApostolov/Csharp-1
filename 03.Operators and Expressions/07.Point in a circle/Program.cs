using System;

    class PointInCircle
    {
        static void Main()
        {
            Console.Write("Please enter point x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Please enter point y = ");
            double y = double.Parse(Console.ReadLine());
            double r = 2;
            bool isInsideACircle = false;

            if ((x * x) + (y * y) <= r * r)
            {
                isInsideACircle = true;
            }

            Console.WriteLine("The points x : {0} and y : {1} are inside the circle : {2}", x, y, isInsideACircle);
        }
    }
