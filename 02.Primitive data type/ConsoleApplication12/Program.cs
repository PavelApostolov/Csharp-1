﻿using System;

    class NullValues
    {
        static void Main()
        {
            int? valueInt = null;
            double? valueDouble = null;
            Console.WriteLine(valueInt);
            Console.WriteLine(valueDouble);
            Console.WriteLine(valueInt + 4);
            Console.WriteLine(valueDouble + 4);
            Console.WriteLine(valueInt + null);
            Console.WriteLine(valueDouble + null);
        }
    }
