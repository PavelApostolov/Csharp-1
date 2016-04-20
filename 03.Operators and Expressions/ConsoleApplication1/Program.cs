using System;

    class GravitaionOnMoon
    {
        static void Main()
        {
            Console.WriteLine("Enter your weight on Earth: ");
            double weightOnEarth = double.Parse(Console.ReadLine());
            double weightOnMoon = ((double)0.17 * weightOnEarth);
            Console.WriteLine("Your weight on the moon will be: " + (double)(weightOnMoon));
        }
    }
