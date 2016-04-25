using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagHard
{
    public class Flag
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char leftDiagonal = '\\';
            char rightDiagonal = '/';
            char leftToRight = '-';
            char upperToLower = '|';
            char middle = '*';
            char fill = '.';

            int leftDiagonalPosition = 0;
            int rightDiagonalPosition = n - 1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == (n / 2) && col == (n / 2))
                    {
                        Console.Write(middle);
                    }
                    else if (row == (n / 2))
                    {
                        Console.Write(leftToRight);
                    }
                    else if (col == (n / 2))
                    {
                        Console.Write(upperToLower);
                    }
                    else if (col == leftDiagonalPosition)
                    {
                        Console.Write(leftDiagonal);
                    }
                    else if (col == rightDiagonalPosition)
                    {
                        Console.Write(rightDiagonal);
                    }
                    else
                    {
                        Console.Write(fill);
                    }
                }
                Console.WriteLine();
                leftDiagonalPosition++;
                rightDiagonalPosition--;
            }
        
            //вариант 2
            int num = int.Parse(Console.ReadLine());
            int innerDots = num / 2 - 1;
            int outerDots = 0;

            for (int i = 0; i < num/2; i++)
            {
                Console.Write(new string('.', outerDots));
                Console.Write('\\');
                Console.Write(new string('.', innerDots));
                Console.Write('|');
                Console.Write(new string('.', innerDots));
                Console.Write('/');
                Console.Write(new string('.', outerDots));

                    Console.WriteLine();
                    outerDots++;
                    innerDots--;
            }
            Console.Write(new string('-', num/2));
            Console.Write('*');
            Console.WriteLine(new string('-', num / 2));

            outerDots = n/2 - 1;
            innerDots = 0;
            for (int i = 0; i < num / 2; i++)
            {
                Console.Write(new string('.', outerDots));
                Console.Write('/');
                Console.Write(new string('.', innerDots));
                Console.Write('|');
                Console.Write(new string('.', innerDots));
                Console.Write('\\');
                Console.Write(new string('.', outerDots));

                Console.WriteLine();
                outerDots--;
                innerDots++;
            }
            
        }
    }
}
