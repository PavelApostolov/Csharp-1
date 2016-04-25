using System;

namespace _02.Decoding
{
    class Program
    {
        static void Main()
        {
            int salt = int.Parse(Console.ReadLine());
            while (true)
            {
                int charCode = Console.Read();
                int position = 0;
                char ch = (char)charCode;

                if (ch == '@')
                {
                    break;
                }
                int newCode = 0; //може без нея, а само с charCode
                //if (ch >= 'a' && ch <= 'z')
                if (char.IsLetter(ch))
                {
                  newCode = charCode * salt + 1000;
                }
                //if ( ch> = '0' && ch <= '9')
                else if (char.IsDigit(ch))
                {
                    newCode = charCode + salt + 500;
                }
                else
                {
                    newCode = charCode - salt;
                }
                if (position % 2 == 0)
                {
                    Console.WriteLine("{0:F2}", newCode/100.0);
                }
                else
                {
                    Console.WriteLine(newCode * 100);
                }
                position++;
            }
        }
    }
}
