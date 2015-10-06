/*4.  Using the DOM parser write a program to delete from `catalog.xml` all albums having price > 20.*/

using System.Xml;

namespace _04ExpensiveMusicDeliter
{
    using System;
    using System.Collections.Generic;

    class DeleteEm
    {
        private static void Main()
        {
            const double TriggerPrice = 20.0;

            var xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../CatalogHolder/catalogue.xml");
            var rootNode = xmlDoc.DocumentElement;
            var artistIcCatalogue = ArtistExtractor(rootNode);

            CatalogPrinter(artistIcCatalogue, "The Catalog consist of albums of the following authors:");

            ExpensiveMusicDeletor(TriggerPrice, rootNode);

            var xmlDocumentNEW = new XmlDocument();
            xmlDocumentNEW.Load("../../../CatalogHolder/catalogueNEW.xml");
            var newArtistCatalogue = ArtistExtractor(xmlDocumentNEW.DocumentElement);

            CatalogPrinter(newArtistCatalogue, "After the deletion the catalog consist of albums of the following authors:");
        }

        private static void ExpensiveMusicDeletor(double TriggerPrice, XmlElement rootNode)
        {
            var albums = rootNode.SelectNodes("album");
            foreach (XmlElement album in albums)
            {
                if (double.Parse(album["price"].InnerText) > TriggerPrice)
                {
                    rootNode.RemoveChild(album);

                }
            }
        }

        private static void CatalogPrinter(IEnumerable<string> artistIcCatalogue, string msg)
        {
            Console.WriteLine("{0} \n", msg);
            foreach (var entrie in artistIcCatalogue)
            {
                Console.WriteLine(entrie);
            }
            Console.WriteLine(new string('=', 50) + "\n");
        }

        private static IEnumerable<string> ArtistExtractor(XmlElement rootNode)
        {
            var setOfArtists = new HashSet<string>();

            var albums = rootNode.GetElementsByTagName("album");
            foreach (XmlNode album in albums)
            {
                setOfArtists.Add(album["artist"].InnerText);
            }

            return setOfArtists;
        }
    }
}

