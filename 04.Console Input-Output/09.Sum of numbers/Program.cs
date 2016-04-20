using System;

    class SumOfnNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter N-numbers to be summed: ");
            double N = double.Parse(Console.ReadLine());

            double sum = 0;

            Console.WriteLine("Please enter the numbers: ");
            for (double i = 0; i < N; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The sum of entered numbers is {0}\n", sum);
        }
    }
