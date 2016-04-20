using System;
using System.Text;

class ASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        byte length = 255;

        for (int i = 0; i <= length; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}
