using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum;

internal class FindMax<T> where T: IComparable
{
    public T first, second, third;

    public FindMax(T firstValue, T secondValue, T thirdValue)
    {
        this.first = firstValue;
        this.second = secondValue;
        this.third = thirdValue;
    }
    public T FindMaxValue()
    {
        if (this.first.CompareTo(this.second) > 0 && first.CompareTo(this.third) > 0) return this.first;
        else if (this.second.CompareTo(this.first) > 0 && this.second.CompareTo(this.third) > 0) return this.second;
        else if (third.CompareTo(this.first) > 0 && third.CompareTo(this.second) > 0) return this.third;
        else return default;
    }
}
