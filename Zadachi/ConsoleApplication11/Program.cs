using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());
            int width = N * 2 + 1;
            int height = 6 + (N - 3) / 2 * 3;

            int topDots = (width - N) / 2; //on both sides

            Console.Write(new string('.', topDots));
            Console.Write(new string('*', N));
            Console.WriteLine(new string('.', topDots));

            int nextDots = topDots - 1;
            int topRows = topDots;

            for (int i = 0; i < topRows - 1; i++)
            {
                topDots--;
                Console.Write(new string('.', topDots));
                Console.Write('*');
                Console.Write(new string('.', nextDots));
                Console.Write('*');
                Console.Write(new string('.', nextDots));
                Console.Write('*');
                Console.WriteLine(new string('.', topDots));

                nextDots++;
            }
            Console.WriteLine(new string('*', width));

            int firstDots = 1;
            for (int i = 0; i < N - 1; i++)
            {
                nextDots--;
                Console.Write(new string('.', firstDots));
                Console.Write('*');
                Console.Write(new string('.', nextDots));
                Console.Write('*');
                Console.Write(new string('.', nextDots));
                Console.Write('*');
                Console.WriteLine(new string('.', firstDots));
                firstDots++;
            }
            Console.Write(new string('.', width/2));
            Console.Write('*');
            Console.WriteLine(new string('.', width / 2));
     
        }
    }
}
