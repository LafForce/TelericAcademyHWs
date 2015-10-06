/* 16.  Using Visual Studio generate an XSD schema for the file `catalog.xml`.
 * Write a C# program that takes an XML file and an XSD file (schema) and validates the XML file against the schema.
  * Test it with valid XML catalogs and invalid XML catalogs.*/

namespace _14XSLTtransformation
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    internal class ValidatorAgainstSchema
    {
        private static void Main()
        {
            var schema = new XmlSchemaSet();
            schema.Add(string.Empty, "../../../CatalogHolder/catalogue.xsd");

            XDocument doc = XDocument.Load("../../../CatalogHolder/catalogue.xml");
            XDocument invalidDoc = XDocument.Load("../../invalidCatalogue.xml");

            PrintValidationResult(doc, schema, "catalogue.xml");
            PrintValidationResult(invalidDoc, schema, "invalidCatalogue.xml");
        }

        private static void PrintValidationResult(XDocument doc, XmlSchemaSet schema, string file)
        {
            doc.Validate(schema, (obj, ev) =>
            {
                Console.WriteLine("* {0} * {1}", file, ev.Message);
            });
        }
    }
}
