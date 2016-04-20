using System;

class QuotesAndStrings
{
    static void Main(string[] args)
    {
        string quotations = "The \"use\" of quotations causes difficulties.";
        string anotherQuotations = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotations);
        Console.WriteLine(anotherQuotations);
    }
}
