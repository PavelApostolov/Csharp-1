using System;

namespace Task4.Tower
{
    public class GoikoTower
    {
        public static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int width = h * 2;

            int towerWidth = 2;
            int nextCrossbeamRow = 2;
            int currentStep = 2;
            for (int row = 1; row <= h; row++)
            {
                string sidePoints = new string('.', (width - towerWidth) / 2);
                string middleSymbols;
                if (row % nextCrossbeamRow == 0)
                {
                    middleSymbols = new string('-', width - (sidePoints.Length * 2) - 2);
                    nextCrossbeamRow += currentStep;
                    currentStep++;
                }
                else
                {
                    middleSymbols = new string('.', width - (sidePoints.Length * 2) - 2);
                }

                Console.WriteLine(sidePoints + "/" + middleSymbols + "\\" + sidePoints);

                towerWidth += 2;
            }
        }
    }
}

/*
int update = 2;
int rowToHaveDash = 2

for (inr i = 1; i<=n; i++)

var middleCharacter = '.';

if (i == rowToHaveDash)

middleCharacter = '-';
rowToHaveDash += update;
update++;

string row = 
new string ('.', n - i) + "/" + 
new string('-', 2 * i - 2) + "\\" + 
new string('.', n-i);

Console.WriteLine(row)
*/