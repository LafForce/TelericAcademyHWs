/*In a text file we are given the name, address and phone number of given person(each at a single line).
  * Write a program, which creates new XML document, which contains these data in structured XML format.*/


namespace _07XMLPersonalCardCreator
{
    using System;
    using System.IO;
    using System.Xml.Linq;
    class XMLPersonCreator
    {
        static void Main()
        {
            var person = new Person();

            using (StreamReader reader = new StreamReader("../../PersonDetails.txt"))
            {
                person.Name = reader.ReadLine();
                person.Phone = reader.ReadLine();
                person.Address = reader.ReadLine();
            }

            var personElement = new XElement("person",
                new XElement("name", person.Name),
                new XElement("phone", person.Phone),
                new XElement("address", person.Address));

            Console.WriteLine("file can be found in project's directory");
            personElement.Save("../../person.xml");
        }
    }
}
