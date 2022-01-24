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
        //test 2 :
        Console.WriteLine(FindMax.FindMaxIntValue(9, 0, 99));
    }
}