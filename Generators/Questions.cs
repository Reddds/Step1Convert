namespace Step1Convert.Generators
{
    class Questions : XmlGenerator
    {
        public Questions()
        {
            var users = CreateDocument("question_categories");
        }
    }
}
