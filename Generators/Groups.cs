namespace Step1Convert.Generators
{
    class Groups : XmlGenerator
    {
        public Groups()
        {
            var groups = CreateDocument("groups");
            groups.AppendChild(CreateEmptyElement("groupings"));
        }
    }
}
