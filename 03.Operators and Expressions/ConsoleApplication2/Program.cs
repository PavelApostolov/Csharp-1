using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Insert number here: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("The number can be divided (without remainder) by 7 and 5 in the same time");
        }
        else
        {
            Console.WriteLine("The number can NOT be divided (without remainder) by 7 and 5 in the same time");
        }
    }
}

