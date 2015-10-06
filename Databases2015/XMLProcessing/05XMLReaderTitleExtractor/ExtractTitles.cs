//5.  Write a program, which using `XmlReader` extracts all song titles from `catalog.xml`.

namespace _05XMLReaderTitleExtractor
{
    using System;
    using System.Xml;

    class ExtractTitles
    {
        static void Main()
        {
            Console.WriteLine("Song titles in the catalogue by order: \n");

            using (var reader = XmlReader.Create("../../../CatalogHolder/catalogue.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
