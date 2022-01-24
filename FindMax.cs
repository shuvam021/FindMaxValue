using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum;

internal class FindMax
{
    public static int FindMaxIntValue(int first, int second, int third)
    {
        if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
        {
            return first;
        }
        else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
        {
            return second;
        }
        else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
        {
            return third;
        }
        else
        {
            return 0;
        }
    }
    public static float FindMaxFloatValue(float first, float second, float third)
    {
        if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
        {
            return first;
        }
        else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
        {
            return second;
        }
        else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
        {
            return third;
        }
        else
        {
            return 0;
        }
    }
}
