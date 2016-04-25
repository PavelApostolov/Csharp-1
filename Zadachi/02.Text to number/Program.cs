/*You are given a text and a number (M). This text can contain digits, Latin letters (both capital and letter case) and any other symbols, except for '@'. The number is used to the parsing of the text.
Your task is to go through all characters of the text and, starting from RESULT = 0, to perform the following operations:
•	If the current character is '@', stop the program and print the RESULT
•	If the current character is a digit (0-9), then multiply the RESULT by this digit
•	If the current character is a letter, add its number from the Latin alphabet to RESULT. 'A' is with number 0
•	If the current character is a symbol, that is different from the ones above, create module of the RESULT by the provided number (M)

 * */

using System;

namespace TextToNumber
{
    class Program
    {
        static void Main()
        {
            // read input
            int module = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            // text = text.ToLower();
            long result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i]; //така се взимат буквичките от текста

                if (ch == '@')
                {
                    break;
                }
                else if ('0' <= ch && ch <= '9')
                {
                    result *= (ch - '0');
                }
                else if ('a' <= ch && ch <= 'z')
                {
                    result += (ch - 'a');
                }
                else if ('A' <= ch && ch <= 'Z')
                {
                    result += (ch - 'A');
                }
                else
                {
                    result %= module;
                }
            }

            // print result
            Console.WriteLine(result);
        }
    }
}
