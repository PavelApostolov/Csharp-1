using System;

internal class OnesAndZeros
{
    private static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int row = 0; row < 5; row++)
        {
            for (int bit = 15; bit >= 0; bit--)
            {
                bool isOne = ((1 << bit) & N) > 0;

                if (isOne)
                {
                    // The current bit is one
                    switch (row)
                    {
                        case 0:
                        case 2:
                        case 3:
                            Console.Write(".#.");
                            break;
                        case 1:
                            Console.Write("##.");
                            break;
                        case 4:
                            Console.Write("###");
                            break;
                    }
                }
                else
                {
                    switch (row)
                    {
                        case 0:
                        case 4:
                            Console.Write("###");
                            break;
                        case 1:
                        case 2:
                        case 3:
                            Console.Write("#.#");
                            break;
                    }
                }

                if (bit > 0)
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
    }
}

/*
int num = int.Parse(Console.ReadLine());
//string bin = Convert.ToString(num, 2).PadLeft(32, '0'); --> ако искаме да рабогим с chars

string oneRow0 = ".#.";
string oneRow1 = "##.";
string oneRow2 = ".#.";
string oneRow3 = ".#.";
string oneRow4 = "###";

or

string[] one =   {".#.",
		= "##.",
		= ".#.",
		= ".#.",
		= "###"};

string zeroRow0 = "###";
string zeroRow1 = "#.#";
string zeroRow2 = "#.#";
string zeroRow3 = "#.#";
string zeroRow4 = "###";

//extract bits
for (int i = 15; i>=0; i--)
{
int bit = num & (1 << i);
}
if (bit>0)
...

if i!= 0

...

//for (int i=16; i < bin.Length; i>=0; i++)
//if(bin[i] == '1' { Console.Write(oneRow0); }
//else { Console.Write (zeroRow0); }
//if (i !=bin.Length -1) Console.Write(".\n.\n.\n.\n."); 

//foreach (char sym in binary)
//{
// if (sym == '1')
//  { Console.Write.(one); }
// else Console.Write(zero) }
// Console.Write(".\n.\n.\n.\n.");

*/