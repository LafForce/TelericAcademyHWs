/*
13.  Create an XSL stylesheet, which transforms the file `catalog.xml` into HTML document, formatted for viewing in a standard Web-browser.
*/



namespace _13XMLtiHTML
{
    using System;
    using System.Xml.Xsl;

    class ProgrXMLtoHTMLam
    {
        static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../style.xslt");
            xslt.Transform("../../../CatalogHolder/catalogue.xml", "../../catalogue.html");
            Console.WriteLine("result saved as catalogue.html");
        }
    }
}
