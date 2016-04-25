 using System;
    using System.Text;

    class Solution
    {
        const char Blank = '.';
        const char Full = '#';
        const char Ex = 'X';
        const char LeftSym = '\\';
        const char RightSym = '/';

        // for hardcoded testing
        //const int N = 5;
        //const int D = 1;

        static void Main()
        {
            //new TestsGenerator().GenerateTests();

            int N = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int width = 2 * N + 1;
            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col - row <= D / 2 && col - row >= -D / 2 ||
                        col + row <= 2 * N + D / 2 && col + row >= 2 * N - D / 2)
                    {
                        sb.Append(Full);
                    }
                    else if ((col == N + D / 2 + 1 || col == N - (D / 2 + 1)) && row == N ||
                        (row == N + (D / 2 + 1) || row == N - (D / 2 + 1)) && col == N)
                    {
                        sb.Append(Ex);
                    }
                    else if (col - row == D / 2 + 1 ||
                        col - row == -(D / 2 + 1))
                    {
                        sb.Append(LeftSym);
                    }
                    else if (col + row == 2 * N + (D / 2 + 1) ||
                        col + row == 2 * N - (D / 2 + 1))
                    {
                        sb.Append(RightSym);
                    }
                    else
                    {
                        sb.Append(Blank);
                    }
                }

                if (row != width - 1)
                {
                    sb.AppendLine();
                }
            }

            Console.WriteLine(sb);
        }
    }

/*
using System;
class ExRugs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        string[,] matrix = new string[2 * n + 1, 2 * n + 1];

        if ((d + 1) / 2 < n)
        {
            for (int i = 0; i < 2 * n + 1; i++) for (int j = 0; j < 2 * n + 1; j++) matrix[i, j] = ".";

            for (int i = 0; i < 2 * n + 1; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    if (((1 - d) / 2 + i + j >= 0) && ((1 - d) / 2 + i + j < 2 * n + 1)) matrix[i, (1 - d) / 2 + i + j] = "#";
                    if (((1 - d) / 2 + i + j >= 0) && ((1 - d) / 2 + i + j < 2 * n + 1)) matrix[2 * n - i, (1 - d) / 2 + i + j] = "#";
                }
            }

            for (int i = (d + 1) / 2; i < n; i++)
            {
                matrix[i - (d + 1) / 2, i] = "\\";
                matrix[i - (d + 1) / 2, 2 * n - i] = "/";
                matrix[i, i - (d + 1) / 2] = "\\";
                matrix[2 * n - i, i - (d + 1) / 2] = "/";
                matrix[2 * n - i + (d + 1) / 2, i] = "/";
                matrix[2 * n - i + (d + 1) / 2, 2 * n - i] = "\\";
                matrix[i, 2 * n - i + (d + 1) / 2] = "/";
                matrix[2 * n - i, 2 * n - i + (d + 1) / 2] = "\\";
            }
            matrix[n - (d + 1) / 2, n] = "X";
            matrix[n + (d + 1) / 2, n] = "X";
            matrix[n, n - (d + 1) / 2] = "X";
            matrix[n, n + (d + 1) / 2] = "X";
        }

        else
        {
            for (int i = 0; i < 2 * n + 1; i++) for (int j = 0; j < 2 * n + 1; j++) matrix[i, j] = "#";
        }

        for (int i = 0; i < 2 * n + 1; i++)
        {
            for (int j = 0; j < 2 * n + 1; j++) Console.Write(matrix[i, j]);
            Console.WriteLine();
        }
    }
}
*/