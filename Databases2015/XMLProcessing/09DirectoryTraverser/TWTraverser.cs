/*9.  Write a program to traverse given directory and write to a XML file its
    contents together with all subdirectories and files.
  * Use tags `<file>` and `<dir>` with appropriate attributes.
  * For the generation of the XML document use the class `XmlWriter`.*/

namespace TraverseDirectory
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    class TWTraverser
    {
        static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter("../../dir.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 4;

                string twoDirectoriesBack = "../../../../";

                writer.WriteStartDocument();
                writer.WriteStartElement("Two directories back:");
                Traverse(twoDirectoriesBack, writer);
                writer.WriteEndDocument();
            }

            Console.WriteLine("result saved as dir.xml");
        }

        static void Traverse(string dir, XmlTextWriter writer)
        {
            foreach (var directory in Directory.GetDirectories(dir))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", directory);
                Traverse(directory, writer);
                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", Path.GetFileNameWithoutExtension(file));
                writer.WriteAttributeString("ext", Path.GetExtension(file));
                writer.WriteEndElement();
            }
        }
    }
}
