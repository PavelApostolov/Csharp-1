using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MissCat2011
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8=0, c9 = 0, c10 = 0;
            for (int i = 0; i < n; i++)
            {
                byte vote = byte.Parse(Console.ReadLine());
                switch (vote)
                {
                    case 1: c1++; break;
                    case 2: c2++; break;
                    case 3: c3++; break;
                    case 4: c4++; break;
                    case 5: c5++; break;
                    case 6: c6++; break;
                    case 7: c7++; break;
                    case 8: c8++; break;
                    case 9: c9++; break;
                    case 10: c10++; break; 
                    default:
                        break;
                }
            }
            if (c1 >= c1 && c1 >= c2 && c1 >= c3 && c1 >= c4 && c1 >= c5 && c1 >= c6 && c1 >= c7 && c1 >= c8 && c1 >= c9 && c1 >= c10) ;
            //else if (......)
            //2.Way: int max = 0; int maxCat = 0;  if cat1>max --> max = cat1; maxCat = 1
            // if cat2>max --> max = cat2; maxCat = 2
            //Console.WriteLine(maxCat)
        }
    }
}
