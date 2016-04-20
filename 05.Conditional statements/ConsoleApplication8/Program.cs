using System;

    class Variables
    {
        static void Main()
        {
            Console.WriteLine("Please choose:\n1- for Int Variable\n2- for Double Variable\n3- for String Variable\n... and then enter the variable.");
            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    int number = int.Parse(Console.ReadLine());
                    number++;
                    Console.WriteLine("{0}", number);
                    break;

                case 2:
                    double number2 = double.Parse(Console.ReadLine());
                    number2++;
                    Console.WriteLine("{0}", number2);
                    break;

                case 3:
                    string str = Console.ReadLine();
                    Console.WriteLine("{0}*", str);
                    break;

                default: Console.WriteLine("Wrong Choice");
                    break;
        }
    }
}
