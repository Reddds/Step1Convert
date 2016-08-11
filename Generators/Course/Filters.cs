using System.Xml;

namespace Step1Convert.Generators.Course
{
    class Filters : XmlGenerator
    {
        public Filters()
        {
            var filters = CreateDocument("filters");

            // Содержимое по умолчанию
            var filterActives = XmlDoc.CreateElement(string.Empty, "filter_actives", string.Empty);
            filters.AppendChild(filterActives);

            var filterConfigs = XmlDoc.CreateElement(string.Empty, "filter_configs", string.Empty);
            filters.AppendChild(filterConfigs);

        }
    }
}
