using System;

public class PrintDeck
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        int n = 0;

        switch (input)
        {
            case "2": n = 2; break;
            case "3": n = 3; break;
            case "4": n = 4; break;
            case "5": n = 5; break;
            case "6": n = 6; break;
            case "7": n = 7; break;
            case "8": n = 8; break;
            case "9": n = 9; break;
            case "10": n = 10; break;
            case "J": n = 11; break;
            case "Q": n = 12; break;
            case "K": n = 13; break;
            case "A": n = 14; break;
            default:
                break;
        }
        for (int i = 1; i < n; i++)
        {
            if (i > cards.Length)
            {
                break;
            }
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cards[i - 1]);
        }
    }
}

/*using System;

class PrintADeck
{
    static void Main()
    {
        string sign = Console.ReadLine();

        int n = 0;
        switch (sign)
        {
            case "J":
                n = 11;
                break;
            case "Q":
                n = 12;
                break;
            case "K":
                n = 13;
                break;
            case "A":
                n = 14;
                break;
            default:
                n = int.Parse(sign);
                break;
        }

        string[] deck = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        for (int i = 0; i <= n - 2; i++)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", deck[i]);
        }

    }
}
*/