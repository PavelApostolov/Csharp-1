using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char symbol = '\u00A9';
        Console.SetCursorPosition(4, 1);
        Console.Write(symbol);
        Console.SetCursorPosition(3, 2);
        Console.Write(symbol);
        Console.SetCursorPosition(5, 2);
        Console.Write(symbol);
        Console.SetCursorPosition(6, 3);
        Console.Write(symbol);
        Console.SetCursorPosition(2, 3);
        Console.Write(symbol);
        Console.SetCursorPosition(1, 4);
        Console.Write(symbol);
        Console.SetCursorPosition(3, 4);
        Console.Write(symbol);
        Console.SetCursorPosition(5, 4);
        Console.Write(symbol);
        Console.SetCursorPosition(7, 4);
        Console.Write(symbol);
        Console.WriteLine();
    }
}