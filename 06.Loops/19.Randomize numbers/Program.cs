using System;
using System.Collections.Generic;

class RandomizeNumbers
{
    static void Main()
    {
        Console.Write("Enter an integer n: ");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            numbers.Add(i + 1);
        }
        while (numbers.Count > 0)
        {
            int randomNumber = rnd.Next(0, numbers.Count);
            Console.Write(numbers[randomNumber]);
            if (numbers.Count > 1)
            {
                Console.Write(" ");
            }
            numbers.RemoveAt(randomNumber);
        }
        Console.WriteLine();
    }
}