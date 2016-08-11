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
        public string GetXml()
        {
            if (XmlDoc == null)
                return string.Empty;
            using (var sw = new StringWriter())
            {
                using (var xw = new XmlTextWriter(sw))
                {
                    XmlDoc.WriteTo(xw);
                }
                return sw.ToString();
            }
        }
    }
}
