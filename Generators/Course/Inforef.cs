using System.Xml;

namespace Step1Convert.Generators.Course
{
    class Inforef : XmlGenerator
    {
        public Inforef()
        {
            var roles = CreateDocument("inforef");

            // Содержимое по умолчанию
            var roleref = XmlDoc.CreateElement(string.Empty, "roleref", string.Empty);
            roles.AppendChild(roleref);

            var role = XmlDoc.CreateElement(string.Empty, "role", string.Empty);
            role.AppendChild(CreateElementWithText("id", "5"));
            roleref.AppendChild(role);

        }
    }
}
