namespace Step1Convert.Generators.Course.Blocks
{
    class Block : XmlGenerator
    {
        public Block(int id, int contextid, int version, string name,
            int parentcontextid,
            int showinsubcontexts = 0,
            string pagetypepattern = "course-view-*",
            string subpagepattern = MoodleNull,
            string defaultregion = "side-post",
            int defaultweight = 0,
            string configdata = "",
            string blockPositions = ""
            )
        {
            var block = CreateDocument("block");
            block.SetAttribute("id", id.ToString());
            block.SetAttribute("contextid", contextid.ToString());
            block.SetAttribute("version", version.ToString());

            block.AppendChild(CreateElementWithText("blockname", name));
            block.AppendChild(CreateElementWithText("parentcontextid", parentcontextid.ToString()));
            block.AppendChild(CreateElementWithText("showinsubcontexts", showinsubcontexts.ToString()));
            block.AppendChild(CreateElementWithText("pagetypepattern", pagetypepattern));
            block.AppendChild(CreateElementWithText("subpagepattern", subpagepattern));
            block.AppendChild(CreateElementWithText("defaultregion", defaultregion));
            block.AppendChild(CreateElementWithText("defaultweight", defaultweight.ToString()));
            block.AppendChild(CreateElementWithText("configdata", configdata));
            block.AppendChild(CreateElementWithText("block_positions", blockPositions));

        }
    }
}
