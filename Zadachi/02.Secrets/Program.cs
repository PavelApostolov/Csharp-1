using System;
using System.Numerics;

class SecretsOfNumbers
{
    static void Main()
    {
        BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger number = inputNumber;
        if (number < 0)
        {
            number = -number;
        }

        int specialSum = 0;
        int currentDigitPosition = 1;
        while (number > 0)
        {
            int currentDigit = (int)(number % 10);
            number /= 10;
            if (currentDigitPosition % 2 == 1)
            {
                specialSum += currentDigit * currentDigitPosition * currentDigitPosition;
            }
            else
            {
                specialSum += currentDigit * currentDigit * currentDigitPosition;
            }
            currentDigitPosition++; 
            
        }
        Console.WriteLine(specialSum);

        int secretSequenceLength = specialSum % 10;
        if (secretSequenceLength != 0)
        {
            //int start = specialSum % 26;
            //for (int i = 0; i < secretSequenceLength; i++)
            //{
            //  Console.Write((char)('A' + (start + i) % 26));
            //}
            
            char firstSecretLetter = (char)(specialSum % 26 + 'A');
            for (int offset = 0; offset < secretSequenceLength; offset++)
            {
                char secretLetter = (char)(firstSecretLetter + offset);
                if (secretLetter > 'Z')
                {
                    secretLetter = (char)(secretLetter - 'Z' + 'A' - 1);
                }

                Console.Write(secretLetter);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("{0} has no secret alpha-sequence", inputNumber);
        }
    }
}