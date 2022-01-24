using System;

namespace FindMaximum;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Max Int Value:");
        //test 1 :
        Console.WriteLine(FindMax.FindMaxIntValue(99, 9, 0));
        //test 2 :
        Console.WriteLine(FindMax.FindMaxIntValue(0, 99, 9));
        //test 3 :
        Console.WriteLine(FindMax.FindMaxIntValue(9, 0, 99));

        //test 1 :
        Console.WriteLine(FindMax.FindMaxFloatValue(99.9F, 9.9F, 0.9F));
        //test 2 :
        Console.WriteLine(FindMax.FindMaxFloatValue(9.9F, 99.9F, 0.9F));
        //test 3 :
        Console.WriteLine(FindMax.FindMaxFloatValue(9.9F, 0.9F, 99.9F));

        //test 1:
        Console.WriteLine(FindMax.FindMaxStringValue("where", "how", "when"));
        //test 2:
        Console.WriteLine(FindMax.FindMaxStringValue("when", "where", "how"));
        //test 3:
        Console.WriteLine(FindMax.FindMaxStringValue("when", "how", "where"));
    }
}