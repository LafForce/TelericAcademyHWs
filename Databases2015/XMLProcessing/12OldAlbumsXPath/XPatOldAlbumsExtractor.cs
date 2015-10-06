/*11.  Write a program, which extract from the file `catalog.xml` the prices for all albums, published 5 years ago or earlier.
  * Use XPath query.*/

namespace _12OldAlbumsXPath
{
    using System;
    using System.Xml;

    class XPatOldAlbumsExtractor
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../CatalogHolder/catalogue.xml");
            var query = "/music/album[year<2010]/name";

            var albumNames = doc.SelectNodes(query);

            foreach (XmlNode name in albumNames)
            {
                Console.WriteLine(name.InnerText);
            }
        }
    }
}

