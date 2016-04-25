using System;

namespace _03.Expression
{
    class Program
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            decimal result = 0;
            decimal currentBracketResult = 0;
            char currentOperator = '+';
            char currentBracketOperator = '+';
            bool inBracket = false;

            foreach (var symbol in expression)
            {
                if (symbol == '(')
                {
                    inBracket = true;
                    continue;
                }
                if (symbol == ')')
                {
                    inBracket = false;
                    switch (currentOperator)
                    {
                        case '+': result += currentBracketResult; break;
                        case '-': result -= currentBracketResult; break;
                        case '*': result *= currentBracketResult; break;
                        case '/': result /= currentBracketResult; break;
                    }
                    currentBracketResult = 0;
                    currentBracketOperator = '+';
                }

                if (symbol == '+' ||
                    symbol == '-' ||
                    symbol == '*' ||
                    symbol == '/' )             
                {
                    if (inBracket)
                    {
                        currentBracketOperator = symbol;
                    }
                    else
                    {
                        currentOperator = symbol;
                    }
                }

                if (char.IsDigit(symbol))
                {
                    int currentNumber = symbol - '0';

                    if (inBracket)
                    {
                        switch (currentBracketOperator)
                        {
                            case '+': currentBracketResult += currentNumber; break;
                            case '-': currentBracketResult -= currentNumber; break;
                            case '*': currentBracketResult *= currentNumber; break;
                            case '/': currentBracketResult /= currentNumber; break;

                        }
                    }
                    else
                    {
                        switch (currentOperator)
                        {
                            case '+': result += currentNumber; break;
                            case '-': result -= currentNumber; break;
                            case '*': result *= currentNumber; break;
                            case '/': result /= currentNumber; break;

                        }
                    }

                }
            }
            Console.WriteLine("{0:F2}", result);
        }

    }
}

/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExpressionSolution
{
    static void Main()
    {
        int symbol = Console.Read();
        decimal sum = 0;
        int o = '+';

        while (symbol != '=')
        {
            if (symbol == '(')
            {
                decimal innerSum = 0;
                int innerO = '+';
                symbol = Console.Read();

                while (symbol != ')')
                {
                    if (0 <= symbol - '0' && symbol - '0' <= 9)
                    {
                        switch (innerO)
                        {
                            case '+':
                                innerSum += symbol - '0';
                                break;
                            case '-':
                                innerSum -= symbol - '0';
                                break;
                            case '*':
                                innerSum *= symbol - '0';
                                break;
                            case '/':
                                innerSum /= symbol - '0';
                                break;
                        }
                    }
                    else if (symbol == '+' ||
                             symbol == '-' ||
                             symbol == '/' ||
                             symbol == '*')
                    {
                        innerO = symbol;
                    }
                    symbol = Console.Read();
                }

                switch (o)
                {
                    case '+':
                        sum += innerSum;
                        break;
                    case '-':
                        sum -= innerSum;
                        break;
                    case '*':
                        sum *= innerSum;
                        break;
                    case '/':
                        sum /= innerSum;
                        break;
                }
            }
            else if (0 <= symbol - '0' && symbol - '0' <= 9)
            {
                switch (o)
                {
                    case '+':
                        sum += symbol - '0';
                        break;
                    case '-':
                        sum -= symbol - '0';
                        break;
                    case '*':
                        sum *= symbol - '0';
                        break;
                    case '/':
                        sum /= symbol - '0';
                        break;
                }
            }
            else if (symbol == '+' ||
                     symbol == '-' ||
                     symbol == '/' ||
                     symbol == '*')
            {
                o = symbol;
            }
            symbol = Console.Read();
        }

        Console.WriteLine("{0:0.00}", sum);
    }
}
*/
