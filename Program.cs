using System;

namespace FindMaximum;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Max Int Value:");
        Console.WriteLine("\nIntegers:");
        Console.WriteLine(new FindMax<int>(99, 9, 0).FindMaxValue()); //test 1
        Console.WriteLine(new FindMax<int>(0, 99, 9).FindMaxValue()); //test 2
        Console.WriteLine(new FindMax<int>(9, 0, 99).FindMaxValue()); //test 3
        Console.WriteLine("\nFloats:");
        Console.WriteLine(new FindMax<float>(99.9f, 9.9f, 0.9f).FindMaxValue()); //test 1 :
        Console.WriteLine(new FindMax<float>(9.9f, 99.9f, 0.9f).FindMaxValue()); //test 2 :
        Console.WriteLine(new FindMax<float>(9.9f, 0.9f, 99.9f).FindMaxValue()); //test 3 :
        Console.WriteLine("\nStrings:");
        Console.WriteLine(new FindMax<string>("where", "how", "when").FindMaxValue()); //test 1:
        Console.WriteLine(new FindMax<string>("when", "where", "how").FindMaxValue()); //test 2:
        Console.WriteLine(new FindMax<string>("when", "how", "where").FindMaxValue()); //test 3:
    }
}