
/*
2.  Write program that extracts all different artists which are found in the `catalog.xml`.
    * For each author you should print the number of albums in the catalogue.
     * Use the XPath.
 */


using System.Collections;

namespace _03XpathExtractor
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    internal class XpathReunner
    {
        static void Main()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../CatalogHolder/catalogue.xml");
            string xPathQuery = "/music/album";

            var albumsList = xmlDoc.SelectNodes(xPathQuery);

            
            foreach (var artist in ArtistAndAlbumsNumberExtractor(albumsList))
            {
                Console.WriteLine("Artist {0} has {1} albums in this catalogue!", artist.Key, artist.Value);
            }

        }

        private static Dictionary<string, int> ArtistAndAlbumsNumberExtractor(IEnumerable albumsList)
        {
            var artistsList = new Dictionary<string, int>();
            foreach (XmlNode album in albumsList)
            {
                var artistName = album.SelectSingleNode("artist").InnerText;
                if (!artistsList.ContainsKey(artistName))
                {
                    artistsList[artistName] = 0;
                }

                artistsList[artistName]++;
            }

            return artistsList;
        }
    }
}
