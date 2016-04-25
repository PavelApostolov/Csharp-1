using System;

namespace _04.Persian_rugs
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int width = 2 * N + 1;

            for (int row = 0; row < N; row++)
            {
                Console.Write(new string('#', row));
                //
                //for (int i = 0; i < row; i++)
                //{
                //Console.Write('#');
                //}
                Console.Write('\\');


                int spaceLeft = width - width - 1 - 1 - D - D;
                if (spaceLeft >= 2)
                {
                    Console.Write(new string(' ', D));
                    Console.Write('\\');
                    Console.Write(new string('.', spaceLeft - 2));
                    Console.Write('/');
                    Console.Write(new string(' ', D));
                }
                else
                {
                    Console.Write(new string(' ', width - row - row - 1 - 1)); // широчина - леви диези - десни диези - накл черта - накл. черта
                }

                Console.Write('/');
                Console.Write(new string('#', row));

                Console.WriteLine();
            }
            Console.WriteLine(new string('#', N) + 'X' + new string('#', N));

            for (int row = N-1; row >= 0; row--)
            {
                Console.Write(new string('#', row));
                Console.Write('/');


                int spaceLeft = width - width - 1 - 1 - D - D;
                if (spaceLeft >= 2)
                {
                    Console.Write(new string(' ', D));
                    Console.Write('/');
                    Console.Write(new string('.', spaceLeft - 2));
                    Console.Write('\\');
                    Console.Write(new string(' ', D));
                }
                else
                {
                    Console.Write(new string(' ', width - row - row - 1 - 1)); // широчина - леви диези - десни диези - накл черта - накл. черта
                }

                Console.Write('\\');
                Console.Write(new string('#', row));

                Console.WriteLine();
            }
        }
    }
}

/*namespace Persian_rug
{
    using System;
    using System.Text;

    class Solution
    {
        const char Blank = ' ';
        const char Full = '#';
        const char Ex = 'X';
        const char LeftSym = '\\';
        const char RightSym = '/';
        const char Dot = '.';

        //const int n = 10;
        //const int div = 2;

        static void Main()
        {
            //new TestsGenerator().GenerateTests();

            int size = int.Parse(Console.ReadLine());
            int div = int.Parse(Console.ReadLine()) + 1;

            StringBuilder sb = new StringBuilder();
            int fieldSize = 2 * size + 1;
            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    if (col == size && row == size)
                    {
                        sb.Append(Ex);
                    }
                    else if (row + col == 2 * size ||
                        row + col == 2 * size + div && col < size ||
                        row + col == 2 * size - (div) && col > size ||
                        row + col == 4 * size + 2)
                    {
                        sb.Append(RightSym);
                    }
                    else if (row - col == 0 ||
                        row - col == -(div) && col < size ||
                        row - col == (div) && col > size ||
                        row - col == 2 * size + 2)
                    {
                        sb.Append(LeftSym);
                    }
                    else if (row - col >= 0 && row + col <= 2 * size ||
                        row + col >= 2 * size && row - col <= 0)
                    {
                        sb.Append(Full);
                    }
                    else if (row + col >= 2 * size + div &&
                        row - col > div ||
                        row + col <= 2 * size - (div) &&
                        row - col < -(div))
                    {
                        sb.Append(Dot);
                    }
                    else
                    {
                        sb.Append(Blank);
                    }
                }

                if (row != fieldSize - 1)
                {
                    sb.AppendLine();
                }
            }

            Console.WriteLine(sb);
        }
    }
}
 * */
