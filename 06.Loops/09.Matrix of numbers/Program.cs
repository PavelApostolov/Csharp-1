using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int num = row; num < row + n; num++)    // num <= (row + n - 1)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

/*
using System;
 
class MatrixOfNums
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int i = 1;
        int y = 1;
        int x = 1;
        while (i <= N )
        {
            if (y <= N)
            {
                Console.Write("{0} ", x++);
                y++;
            }
            else
            {
                Console.Write("\n");
                i++;
                x = i;
                y = 1;
            }
        }
       
    }
}

*/