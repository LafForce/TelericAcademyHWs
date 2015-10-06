/*11.  Write a program, which extract from the file `catalog.xml` the prices for all albums, published 5 years ago or earlier.
  * Use LINQ.*/


namespace _12OlderThan5years
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class OldAlbumsLINQExtractor
    {
        static void Main()
        {
            var doc = XDocument.Load("../../../CatalogHolder/catalogue.xml");

            var albumNames = from album in doc.Descendants("album")
                             where int.Parse(album.Element("year").Value) < 2010
                             select album.Element("name").Value;

            Console.WriteLine(string.Join(Environment.NewLine, albumNames));
        }
    }
}
