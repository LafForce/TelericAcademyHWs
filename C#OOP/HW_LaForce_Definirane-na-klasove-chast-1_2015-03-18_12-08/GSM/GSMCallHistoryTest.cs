using System;
using System.Globalization;

namespace GSM
{
    
    //    Problem 12. Call history test
    //Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
    class GSMCallHistoryTest
    {
        
        private const decimal priceOfMinute = 0.37M;

        //Create an instance of the GSM class.

        private static GSM sagem = new GSM("SAGEM", "P9521 PORSHE", 1500.00M, "Vanila Ice",
            new Battery("SAGEM Military Beast", BatteryType.LiIon, 240, 4),
            new Display(2.2F, 256000));

        public static void TestCalls()
        {
            //Add few calls.
            sagem.AddCall(new Call("31.3.2015 9:08:33", "+413 334 123", 60));
            sagem.AddCall(new Call("3.05.2015 22:45:00", "+359 123 120", 112));
            sagem.AddCall(new Call("2.03.2015 03:15:09", "+359 124 554", 122));
            sagem.AddCall(new Call("10.03.2015 06:05:12", "+359 125 098", 2));

            //Display the information about the calls.
            Console.WriteLine();
            Console.WriteLine("Call-list info: ");
            DisplayCalls();

            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine();
            Console.WriteLine("Total price:");
            Console.WriteLine(string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", sagem.Account(0.37M)));

            //Remove the longest call from the history and calculate the total price again.
            int indexOfMaxDuration = 0;
            for (int i = 0; i < sagem.CallHistory.Capacity; i++)
            {
                if (sagem.CallHistory[i].Duration > indexOfMaxDuration)
                {
                    indexOfMaxDuration = i;
                }
            }
            sagem.DeleteCall(sagem.CallHistory[indexOfMaxDuration]);

            Console.WriteLine();
            Console.WriteLine("Reduced call-list info: ");
            DisplayCalls();

            Console.WriteLine();
            Console.WriteLine("Total price after the remove:");
            Console.WriteLine(string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", sagem.Account(priceOfMinute)));
            Console.WriteLine();

            //Finally clear the call history
            Console.WriteLine("Clearing the call history:");            
            sagem.DeleteCallHistory();
            Console.WriteLine();
            Console.WriteLine("Displaying the resulting call history:");
            DisplayCalls();
        }
        private static void DisplayCalls()
        {
            foreach (Call call in sagem.CallHistory)
            {
                Console.WriteLine(call);
            }
        }

    }
}