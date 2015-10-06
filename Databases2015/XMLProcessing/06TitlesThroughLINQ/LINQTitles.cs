/*6.  Rewrite the same using `XDocument` and LINQ query.*/

using System.Xml;
using System.Xml.Linq;

namespace _06TitlesThroughLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    internal class LINQTitles
    {
        private static void Main()
        {
            var xmlDoc = XDocument.Load("../../../CatalogHolder/catalogue.xml");
            var titles = from song in xmlDoc.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value
                };

            Console.WriteLine("All song titles in catalog:");
            Console.WriteLine(new string('-', 70));
            foreach (var title in titles)
            {
                Console.WriteLine(title.Title);
            }
        }
    }
}
