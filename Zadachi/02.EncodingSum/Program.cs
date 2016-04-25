namespace EncodingSum
{
    using System;

    public class Sum
    {
        public static void Main()
        {
            // read input
            int M = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            // setup result
            int result = 0;

            // @ is always the last symbol, therefore we skip it - hence the iteration from 0 to text.Length - 1
            for (int i = 0; i < text.Length - 1; i++)
            {
                char symbol = text[i];

                if (char.IsDigit(symbol))
                {
                    // convert digit as char to digit as int
                    // can also be done with char.GetNumericValue(symbol);
                    result *= symbol - '0';
                }
                else if (char.IsLetter(symbol))
                {
                    // convert the character to lowercase, so we can handle all characters the same, independent of their case
                    // (char)(symbol | ' ');
                    char symbolToLower = char.ToLower(symbol);

                    // this is how we find the index of a letter in the latin alphabet and add it to result
                    result += symbolToLower - 'a';
                }
                else
                {
                    result %= M;
                }
            }

            // print the answer
            Console.WriteLine(result);
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TextToNumber.Solution
{
    class TextToNumberApp
    {
        static void Main()
        {
            BigInteger result = 0;

            int module = int.Parse(Console.ReadLine());

            var ch = (char)Console.Read();
            //string resultAsString = string.Empty;

            while (ch != '@')
            {
                if (ch == '@')
                {
                    break;
                }
                if (char.IsDigit(ch))
                {
                    //resultAsString += "RESULT = " + result + " * " + (ch - '0') + "(" + ch + ") = ";
                    result *= ch - '0';
                    //resultAsString += result;
                }
                else if (char.IsLetter(ch))
                {
                    if ('A' <= ch && ch <= 'Z')
                    {
                        //resultAsString += "RESULT = " + result + " + " + (ch - 'A') + "(" + ch + ") = ";
                        result += ch - 'A';
                        //resultAsString += result;
                    }
                    else
                    {
                        //resultAsString += "RESULT = " + result + " + " + (ch - 'a') + "(" + ch + ") = ";
                        result += ch - 'a';
                        //resultAsString += result;
                    }
                }
                else
                {
                    //resultAsString += "RESULT = " + result + " % " + module + "(" + ch + ") = ";
                    result %= module;
                    //resultAsString += result;
                }
                ch = (char)Console.Read();
                //resultAsString += Environment.NewLine;
            }
            Console.WriteLine("{0}", result);
            //Console.WriteLine(resultAsString);
        }
    }
}
*/