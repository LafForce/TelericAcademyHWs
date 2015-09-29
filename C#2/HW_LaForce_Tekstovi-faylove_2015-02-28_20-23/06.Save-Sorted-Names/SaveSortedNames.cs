using System;
using System.Collections.Generic;
using System.IO;

class SaveSortedNames
{
    static readonly List<string> strings = new List<string>();

    static void Main()
    {
        Console.WriteLine(@"Problem 6. Save sorted names
Write a program that reads a text file containing a list of strings, 
sorts them and saves them to another text file.
Example:
input.txt	output.txt
Ivan 
Peter 
Maria 
George	 
Ivan 
Maria 
Peter
============================================================================
Solution:");

	
		const string pathInput = "../../unsorted.txt";
		const string pathOutput = "../../sorted.txt";

		SeparateStringsFromTextFile(pathInput);

		Console.WriteLine("Names: {0}", string.Join(", ", strings));

		strings.Sort();
		SaveSortedStringsToTextFile(pathOutput);

		Console.WriteLine("\nSorted names: {0}\n", string.Join(", ", strings));
        Console.WriteLine();
        Console.WriteLine("The sorted file can be found in the project's folder.");
	}

	static void SeparateStringsFromTextFile(string pathText)
	{
		using (StreamReader reader = new StreamReader(pathText))
		{
			while (!reader.EndOfStream)
			{
				string[] tokens = reader.ReadLine().Split(new[] { ' ', ',', '\n' },
					StringSplitOptions.RemoveEmptyEntries);

				foreach (string t in tokens)
				{
					strings.Add(t);
				}
			}
		}
	}

	static void SaveSortedStringsToTextFile(string pathResult)
	{
		using (StreamWriter result = new StreamWriter(pathResult))
		{
			foreach (string t in strings)
			{
				result.WriteLine(t);
			}
		}
	}
}