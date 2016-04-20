using System;

    class ModifyBit
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter a value(0 or 1):");
            byte value = byte.Parse(Console.ReadLine());
            Console.Write("Enter a position:");
            byte position = byte.Parse(Console.ReadLine());

            if ((number >> position & 1) != value)
            {
                Console.WriteLine(number ^ (1 << position));
            }
            else
                Console.WriteLine(number);
        }
    }
