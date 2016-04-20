using System;

class ComparingFloats
{
    static void Main()
    {
        double firstValue = double.Parse (Console.ReadLine());
        double secondValue = double.Parse (Console.ReadLine());
        bool nearlyEqual = Math.Abs(firstValue - secondValue) < 0.000001;
        Console.WriteLine("{0}", nearlyEqual);
    }
}
