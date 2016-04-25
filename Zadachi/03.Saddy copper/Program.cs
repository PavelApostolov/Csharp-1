using System;
using System.Numerics;

namespace SaddyCopper
{
    class Program
    {
        static void Main()
        {
            string strNum = Console.ReadLine(); //resulted number --> string!
            int transCount = 0;//брой трансформации

            while (strNum.Length > 1 && transCount < 10) //output condition
            {
                BigInteger product = 1;
                while (strNum.Length > 0)
                {
                    strNum = strNum.Substring(0, strNum.Length - 1); // step 2 вадим последната цифра
                    int sum = 0;
                    for (int i = 0; i < strNum.Length; i += 2) //нечетни числа (но на четни позиции)
                    {
                        sum += (strNum[i] - '0'); //винаги вадим стринга 0
                    }

                    product *= sum != 0 ? sum : 1; //with if else -->
                }

                transCount++;
                strNum = product.ToString(); //!
            }

            // output
            if (transCount < 10)
            {
                Console.WriteLine(transCount);
            }

            Console.WriteLine(strNum);
        }
    }
}
