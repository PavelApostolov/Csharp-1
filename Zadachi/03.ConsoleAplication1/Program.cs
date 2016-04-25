/*Your task is to create a program named “ConsoleApplication1” which solves the following task. You will receive N numbers from the input. You will have to select those who are in odd positions (starting from zero) and calculate the product of their digits. If one of the digits is zero, ignore it in the calculations. If the number itself is zero, consider the product of its digits to be 1. Afterwards find the product of all previously found products as the final result.
Let’s make it more interesting. If the input numbers are more than 10, calculate the result from the formula above for the first 10 numbers and then calculate it again for all other numbers after the 10th. If the numbers are less or equal to 10, calculate the result for all numbers of the input.
*/
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int index = 0;
        BigInteger globalProduct = 1;
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "END")
            {
                break;
            }
            if (index == 10)
            {
                Console.WriteLine(globalProduct);
                globalProduct = 1;
            }
            int num = int.Parse(line);
            if (index % 2 == 1)
            {
                BigInteger product = 1;
                while (num > 0)
                {
                    //listOfInts.Add(num % 10);
                    //num = num / 10;
                    BigInteger digit = num % 10;
                    if (digit !=0)
	                {
                        product = product * digit;
	                }   
                    num /= 10;

                }
                globalProduct = globalProduct * product;
            }

            int idex = index + 1;
        }
        Console.WriteLine(globalProduct);
    }
}

/*using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int position = 0;
        string line = Console.ReadLine();

        BigInteger productOfFirstTen = 1;
        BigInteger productOfOthers = 1;

        bool hasTenNumbers = false;

        while (line != "END")
        {
            if (position % 2 == 1)
            {
                string currentNumber = line;
                BigInteger product = 1;

                foreach (var symbol in currentNumber)
                {
                    if (symbol != '0')
                    {
                        product *= symbol - '0';
                    }
                }

                if (hasTenNumbers)
                {
                    productOfOthers *= product;
                }
                else
                {
                    productOfFirstTen *= product;
                }
            }

            position++;

            if (position == 10)
            {
                hasTenNumbers = true;
            }

            line = Console.ReadLine();
        }

        if (hasTenNumbers)
        {
            Console.WriteLine(productOfFirstTen);
            Console.WriteLine(productOfOthers);
        }
        else
        {
            Console.WriteLine(productOfFirstTen);
        }
    }
}
*/