/*
2.  Write program that extracts all different artists which are found in the `catalog.xml`.
    * For each author you should print the number of albums in the catalogue.
     * Use the DOM parser and a hash-table.
 */

namespace _02AuthorAndAlbumNumberLister
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class Runner
    {
        private static void Main()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../CatalogHolder/catalogue.xml");
            var rootNode = xmlDoc.DocumentElement;
            var artistIcCatalogue = ArtistExtractor(rootNode);

            Console.WriteLine("The Catalog consist of albums of the following authors: \n");
            foreach (var entrie in artistIcCatalogue)
            {
                Console.WriteLine(entrie);
            }

            Console.WriteLine("\n" + new string('=', 50) + "\n");
            foreach (var keyValuePair in ArtistNameAndNumberOfAlbumsExtractor(rootNode))
            {
                Console.WriteLine("The artist {0} has {1} album(s) in this catalogue!", keyValuePair.Key, keyValuePair.Value);
            }
        }

        private static IDictionary<string, int> ArtistNameAndNumberOfAlbumsExtractor(XmlElement rootNode)
        {
            var artistsVSnumberOfAlbums = new Dictionary<string, int>();

            var albums = rootNode.GetElementsByTagName("album");
            foreach (XmlNode album in albums)
            {
                var artist = album["artist"].InnerText;
                if (!artistsVSnumberOfAlbums.ContainsKey(artist))
                {
                    artistsVSnumberOfAlbums[artist] = 0;
                }

                artistsVSnumberOfAlbums[artist]++;
            }

            return artistsVSnumberOfAlbums;
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