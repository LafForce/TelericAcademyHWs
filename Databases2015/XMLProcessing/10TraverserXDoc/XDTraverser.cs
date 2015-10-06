/*
10.  Rewrite the last exercises using `XDocument`, `XElement` and `XAttribute`.
*/

namespace _10TraverserXDoc
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    class XDTraverser
    {
        static void Main()
        {
            var twoDirsBack = Traverse("../../../../");
            twoDirsBack.Save("../../dir.xml");
            Console.WriteLine("result saved as dir.xml");
        }

        static XElement Traverse(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(Traverse(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("ext", Path.GetExtension(file))));
            }

            return element;
        }
    }
}
