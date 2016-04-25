/*The summer is coming. Birds are singing, trees are green, girls wear short skirts… Yeah, right, in your dreams! Even though it is June, the weather is awful. To warm ourselves, we need fire. Lots of fire! Lots of lots of FIRE!!!
And since we are living in the Matrix, the super-duper-human rescuer Neo will need to write a program about creating big torches of fire. Unfortunately Neo is just a simple Kung-Fu master, who likes to fly in the sky. You will have to help him otherwise people will freeze!
Your task is to print on the console a torch of fire with width N following the examples below.
Input 
The input data is being read from the console.
On the only line will hold an integer number N, indicating the width of the fire in the torch.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
You should print the fire on the console. Use the symbol “#” (number sign) to mark the fire, “-“ (dash) to show the top of the torch and “/” (slash) or “\” (backslash) to illustrate the torch.
Constraints
•	N will be a positive integer in the range [4…76] and will always be divisible by 4.
•	Allowed working time for your program: 0.25 second.
 * */


using System;

public class Fire
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        // Top part of fire
        for (int i = 1; i <= N / 2; i++)
        {
            Console.Write(new string('.', N / 2 - i));
            Console.Write('#');
            Console.Write(new string('.', (i - 1) * 2));
            Console.Write('#');
            Console.WriteLine(new string('.', N / 2 - i));
        }

        // Bottom part of fire
        for (int i = 1; i <= N / 4; i++)
        {
            Console.Write(new string('.', i - 1));
            Console.Write('#');
            Console.Write(new string('.', (N / 2 - i) * 2));
            Console.Write('#');
            Console.WriteLine(new string('.', i - 1));
        }

        // Top part of torch
        Console.WriteLine(new string('-', N));

        // Torch
        for (int row = 1; row <= N / 2; row++)
        {
            Console.Write(new string('.', row - 1));
            Console.Write(new string('\\', N / 2 - (row - 1)));
            Console.Write(new string('/', N / 2 - (row - 1)));
            Console.WriteLine(new string('.', row - 1));
        }
    }
}

