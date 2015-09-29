using System;

namespace GSM
{
    //    Problem 7. GSM test
    //Write a class GSMTest to test the GSM class:
    //Create an array of few instances of the GSM class.
    //Display the information about the GSMs in the array.
    //Display the information about the static property IPhone4S.

    public static class GSMTest
    {
        private static GSM[] arrayOfGSM =
        {
            new GSM("Micro Nokia", "Lunia"),
            new GSM("HTC", "One", 0.5M, "Neo"),
            new GSM("Yota","YotaPhone 2" , 700M ,"Barack Hussein Obama II", new Battery(), new Display()),
            new GSM("Ericsson", "1018", 79.99M, "Bai Ivan", new Battery("800mAh", BatteryType.NiMH, 80, 4), new Display(2F,2)),
            new GSM("Sony", "Walkmen", 1234M, "Some Guy", new Battery("nl12", BatteryType.NiCd, 150, 30), new Display(5.3F, 1024))
        };

        public static void DisplayGSMTestResults()
        {
            Console.WriteLine("Test GSM info:");
            Console.WriteLine();
            foreach (var gsm in arrayOfGSM)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Iphone info:");
            Console.WriteLine();
            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
