namespace Step1Convert.Generators
{
    class GradeHistory : XmlGenerator
    {
        public GradeHistory()
        {
            var groups = CreateDocument("grade_history");
            groups.AppendChild(CreateEmptyElement("grade_grades"));
        }
    }
}
