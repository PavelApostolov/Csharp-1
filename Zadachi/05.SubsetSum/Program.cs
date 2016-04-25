using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SubsetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long s = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long[] nums = new long[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = long.Parse(Console.ReadLine());
            }
            int maxI = 1;
            for (int i = 0; i < n; i++)
			{
                maxI *= 2;
			}
            maxI -= 1;
            //equals maxI = (int)Math.Pow((double)2,n) -1;

            int count = 0;
            for (int i = 1; i <= maxI; i++)
            {
                long currentSum = 0;
                for (int j = 0; j < n; j++)
                {
                    int mask = 1 << j;
                    int nMask = i & mask;
                    int bit = nMask >> j;
                    if (bit==1)
                    {
                        currentSum += nums[j];
                    }
                    if (currentSum == s)
                    {
                        count++;
                    }
                }
            }
        }
    }
}
