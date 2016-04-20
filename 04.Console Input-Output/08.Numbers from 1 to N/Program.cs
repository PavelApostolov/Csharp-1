using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}
