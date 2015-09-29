using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        Console.WriteLine(@"Problem 12. Parse URL
Write a program that parses an URL address given in the format: 
[protocol]://[server]/[resource] and extracts from it the [protocol], 
[server] and [resource] elements.
Example:
URL	Information
http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
[server] = telerikacademy.com 
[resource] = /Courses/Courses/Details/212
============================================================================
Solution:");


        Console.Write("Enter URL: ");
        string url = Console.ReadLine();
        //http://telerikacademy.com/Courses/Courses/Details/212

        Uri uri = new Uri(url);
        string protocol = uri.Scheme;
        string server = uri.Host;
        string resource = uri.AbsolutePath;

        Console.WriteLine(@"
[protocol]  {0}
[server]    {1}
[resource]  {2}
", protocol, server, resource);
    }
}
