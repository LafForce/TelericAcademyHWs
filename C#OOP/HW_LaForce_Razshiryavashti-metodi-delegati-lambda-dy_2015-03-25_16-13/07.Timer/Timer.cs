using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//    Problem 7. Timer
//Using delegates write a class Timer that can execute certain method at each t seconds.
class Timer
{
    public delegate void DelegateForTimer();

    public DelegateForTimer CertainMethod { get; set; }

    public int t = 0;
    public Timer(int period)
    {
        this.Period = period;
    }

    public int Period
    {
        get { return this.t; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Negative times are toooo coool for this reality!");
            }
            this.t = value;
        }
    }
    public static void TestMethod()
    {
        while (true)
        {
            Console.WriteLine("Certainly a second has passed!");
        }
    }
   
    public static void Main()
    {
        Timer timer = new Timer(11);
        timer.CertainMethod += TestMethod;
        timer.CertainMethod();
    }

    
}
