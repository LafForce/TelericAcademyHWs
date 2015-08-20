using System;

internal class SomeLoopTask
{
    private static void Main()
    {
        //I dont really know what kinf of array will be used in this loop so 
        //am using var and dynamic not ot get compiling erors.
        dynamic[] array = new dynamic[] { "value1", "value2", "value3" };
        var expectedValue = "theExpectedValue";
        bool isFound = false;

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);

            if (array[i] == expectedValue)
            {
                isFound = true;
            }

        }
        // More code here
        if (isFound)
        {
            Console.WriteLine("Value found!");
        }
        else
        {
            Console.WriteLine("The array search did not met the high hopes of " +
                              "the greater humanity for finding one such value in " +
                              "this particular set of values!");
        }
    }
}