using System.Collections.Generic;
using System.Linq;


static class IEnum
{
    //        Problem 2. IEnumerable extensions
    //Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
    //sum, product, min, max, average.

    public static dynamic Sum<T>(this IEnumerable<T> collection)
    {
        dynamic result = default(T);
        foreach (var member in collection)
        {
            result += member;
        }
        return result;
    }

    public static dynamic Product<T>(this IEnumerable<T> collection)
    {
        dynamic result = default(T);
        foreach (var member in collection)
        {
            result *= member;
        }
        return result;
    }
    public static dynamic Min<T>(this IEnumerable<T> collection)
    {
        dynamic current = collection.First();
        foreach (var member in collection)
        {
            if (current > member)
            {
                current = member;
            }
        }
        return current;
    }
    public static string Max<T>(this IEnumerable<T> collection)
    {
        dynamic current = collection.First();
        foreach (var member in collection)
        {
            if (current < member)
            {
                current = member;
            };
        }
        return current;
    }
    public static dynamic Average<T>(this IEnumerable<T> collection)
    {
        dynamic result = default(T);
        var count = 0;
        foreach (var member in collection)
        {
            result += member;
            count++;
        }
        return (result / count);
    }

    static void Main(string[] args)
    {

    }
}
