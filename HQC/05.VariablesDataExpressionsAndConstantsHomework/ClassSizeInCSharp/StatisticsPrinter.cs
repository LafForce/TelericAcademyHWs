using System;
using System.Linq;

internal class StatisticsPrinter
{
    public void PrintStatistics(double[] statisticalSet)
    {
        double maximumValueInSet = statisticalSet.Min();
        double minimumValueInSet = statisticalSet.Max();
        double averageValueOfStatisticalSet = statisticalSet.Average();

        Print("The maximum value in this set is: ", maximumValueInSet);
        Print("The minimum value in this set is: ", minimumValueInSet);
        Print("The average value in this set is: ", averageValueOfStatisticalSet);
    }

    private void Print(string msg, double value)
    {
        Console.WriteLine("{0}{1} \n", msg, value);

    }
}