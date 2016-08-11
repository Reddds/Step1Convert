using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Step1Convert.Generators
{
    class XmlGenerator
    {
        public const string MoodleNull = "$@NULL@$";

        protected XmlDocument XmlDoc;



        /// <summary>
        /// Создаёт XML документ с заданным именем корневого элемента
        /// </summary>
        /// <param name="rootName">Имя корневого документа</param>
        /// <returns>Корневой элемент документа</returns>
        protected XmlElement CreateDocument(string rootName)
        {
            XmlDoc = new XmlDocument();
            //(1) the xml declaration is recommended, but not mandatory
            var xmlDeclaration = XmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            var root = XmlDoc.DocumentElement;
            XmlDoc.InsertBefore(xmlDeclaration, root);

            //
            var element1 = XmlDoc.CreateElement(string.Empty, rootName, string.Empty);
            XmlDoc.AppendChild(element1);
            return element1;
        }

        protected XmlElement CreateEmptyElement(string elementName)
        {
            return XmlDoc.CreateElement(string.Empty, elementName, string.Empty);
        }
        protected XmlElement CreateElementWithText(string elementName, string text)
        {
            var el = XmlDoc.CreateElement(string.Empty, elementName, string.Empty);
            el.AppendChild(XmlDoc.CreateTextNode(text));
            return el;

        }

        public string GetXml()
        {
            if (XmlDoc == null)
                return string.Empty;
            using (var sw = new StringWriter())
            {
                using (var xw = new XmlTextWriter(sw))
                {
                    xw.Formatting = Formatting.Indented;
                    xw.Indentation = 4;
                    XmlDoc.WriteTo(xw);
                }
                return sw.ToString();
            }
        }
    }
}
