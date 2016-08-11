using System.Xml;

namespace Step1Convert.Generators.Course
{
    class Roles : XmlGenerator
    {
        public Roles()
        {
            var roles = CreateDocument("roles");

            // Содержимое по умолчанию
            var roleOverrides = XmlDoc.CreateElement(string.Empty, "role_overrides", string.Empty);
            roles.AppendChild(roleOverrides);

            var roleAssignments = XmlDoc.CreateElement(string.Empty, "role_assignments", string.Empty);
            roles.AppendChild(roleAssignments);

        }
    }
}
