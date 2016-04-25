using System;

    class Program
    {
        static void Main(string[] args)
        {
            int S = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());

                for (int pos = 0; pos < 26; pos++)
                {
                    bool match = true;
                    for (int j = 0; j <= 3; j ++) // for (int j = pos; j <= pos + 3; j++)
                    {
                        var posInNum = pos + j;
                        var posInS = j;

                        int bitInNum = (num & (1 << posInNum)) >> posInNum; // mask = 1 << p; nAndMask = n & mask; bit = nAndMask >> p
                        int bitInS = (S & (1 << posInNum)) >> posInS;

                        if (bitInNum != bitInS)
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        count++;
                    }
                }
            
            }
            Console.WriteLine(count);
        }
    }

/*using System;

public class SearchInBits
{
    public static void Main()
    {
        const int NumberBits = 30;
        const int SearchBits = 4;

        int search = int.Parse(Console.ReadLine());
        //// string searchAsString = Convert.ToString(search, 2).PadLeft(SearchBits, '0'); // for debugging only
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            //// string numberAsString = Convert.ToString(number, 2).PadLeft(NumberBits, '0'); // for debugging only
            for (int startFromBit = NumberBits - 1; startFromBit >= SearchBits - 1; startFromBit--)
            {
                bool found = true;
                for (int searchBit = SearchBits - 1; searchBit >= 0; searchBit--)
                {
                    int numberBit = startFromBit - (SearchBits - searchBit - 1);
                    int numberMask = 1 << numberBit;
                    int numberAndMask = number & numberMask;
                    int numberBitValue = numberAndMask >> numberBit;

                    int searchMask = 1 << searchBit;
                    int searchAndMask = search & searchMask;
                    int searchBitValue = searchAndMask >> searchBit;

                    if (numberBitValue != searchBitValue)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}
*/