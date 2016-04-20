using System;

    class StringsAndObjects
    {
        static void Main()
        {
        string firstWord = "Hello";
        string secondWord = "World!";
        object greeting = firstWord + " " + secondWord;
        string sayGreeting = (string)greeting;
        Console.WriteLine(sayGreeting);
        }
    }
