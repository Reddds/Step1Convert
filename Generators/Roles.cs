using System.Xml;

namespace Step1Convert.Generators
{
    class Roles : XmlGenerator
    {
        public Roles()
        {
            var users = CreateDocument("roles_definition");

            // Содержимое по умолчанию
            var role = XmlDoc.CreateElement(string.Empty, "role", string.Empty);
            role.SetAttribute("id", "5");
            users.AppendChild(role);

            role.AppendChild(CreateEmptyElement("name"));
            role.AppendChild(CreateElementWithText("shortname", "student"));
            role.AppendChild(CreateElementWithText("nameincourse", MoodleNull));
            role.AppendChild(CreateEmptyElement("description"));
            role.AppendChild(CreateElementWithText("sortorder", "5"));
            role.AppendChild(CreateElementWithText("archetype", "student"));
        }
    }
}
