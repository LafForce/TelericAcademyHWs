using System;
using System.Collections.Generic;
using System.Text;
class EncodeDecode
{
    static void Main()
    {
        Console.WriteLine(@"Problem 7. Encode/decode
Write a program that encodes and decodes a string using given encryption 
key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation 
over the first letter of the string with the first of the key, the second
– with the second, etc. When the last key character is reached, the next is 
the first.
============================================================================
Solution:
");

        Console.WriteLine("Enter key, please.");
        string key = Console.ReadLine();

        Console.WriteLine("Enter messege to be ciphered, please.");
        string message = Console.ReadLine();

        StringBuilder ciphered = new StringBuilder();

        for (int i = 0; i <= message.Length - 1; i++)
        {
            ciphered.Append((char)(message[i] ^ key[i % key.Length]));
        }
       
        Console.WriteLine("Encripted msg: {0}", ciphered);
        Console.WriteLine();

        StringBuilder deciphered = new StringBuilder();
        for (int i = 0; i <= ciphered.Length - 1; i++)
        {
            deciphered.Append((char)(ciphered[i] ^ key[i % key.Length]));
        }

        Console.WriteLine("Decripted msg: {0}", deciphered);

    }
}
