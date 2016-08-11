using System.Xml;

namespace Step1Convert.Generators
{
    class Gradebook : XmlGenerator
    {
        public Gradebook()
        {
            var gradebook = CreateDocument("gradebook");

            // Содержимое по умолчанию
            var gradeCategories = XmlDoc.CreateElement(string.Empty, "grade_categories", string.Empty);
            gradebook.AppendChild(gradeCategories);

            var gradeCategory = XmlDoc.CreateElement(string.Empty, "grade_category", string.Empty);
            gradeCategory.SetAttribute("id", "1");
            gradeCategory.AppendChild(CreateElementWithText("parent", MoodleNull));
            gradeCategory.AppendChild(CreateElementWithText("depth", "1"));
            gradeCategory.AppendChild(CreateElementWithText("path", "/1/"));
            gradeCategory.AppendChild(CreateElementWithText("fullname", "?"));
            gradeCategory.AppendChild(CreateElementWithText("aggregation", "13"));
            gradeCategory.AppendChild(CreateElementWithText("keephigh", "0"));
            gradeCategory.AppendChild(CreateElementWithText("droplow", "0"));
            gradeCategory.AppendChild(CreateElementWithText("aggregateonlygraded", "1"));
            gradeCategory.AppendChild(CreateElementWithText("aggregateoutcomes", "0"));
            gradeCategory.AppendChild(CreateElementWithText("timecreated", "1468781855"));
            gradeCategory.AppendChild(CreateElementWithText("timemodified", "1468781856"));
            gradeCategory.AppendChild(CreateElementWithText("hidden", "0"));
            gradeCategories.AppendChild(gradeCategory);



            var gradeItems = XmlDoc.CreateElement(string.Empty, "grade_items", string.Empty);
            gradebook.AppendChild(gradeItems);

            var gradeItem = XmlDoc.CreateElement(string.Empty, "grade_item", string.Empty);
            gradeItem.SetAttribute("id", "1");

            gradeItem.AppendChild(CreateElementWithText("categoryid", MoodleNull));
            gradeItem.AppendChild(CreateElementWithText("itemname", MoodleNull));
            gradeItem.AppendChild(CreateElementWithText("itemtype", "course"));
            gradeItem.AppendChild(CreateElementWithText("itemmodule", MoodleNull));
            gradeItem.AppendChild(CreateElementWithText("iteminstance", "1"));
            gradeItem.AppendChild(CreateElementWithText("itemnumber", MoodleNull));
            gradeItem.AppendChild(CreateElementWithText("iteminfo", MoodleNull));
            gradeItem.AppendChild(CreateElementWithText("idnumber", MoodleNull));
            gradeItem.AppendChild(CreateElementWithText("calculation", MoodleNull));
            gradeItem.AppendChild(CreateElementWithText("gradetype", "1"));
            gradeItem.AppendChild(CreateElementWithText("grademax", ".00000"));
            gradeItem.AppendChild(CreateElementWithText("grademin", ".00000"));
            gradeItem.AppendChild(CreateElementWithText("scaleid", MoodleNull));
            gradeItem.AppendChild(CreateElementWithText("outcomeid", MoodleNull));
            gradeItem.AppendChild(CreateElementWithText("gradepass", ".00000"));
            gradeItem.AppendChild(CreateElementWithText("multfactor", "1.00000"));
            gradeItem.AppendChild(CreateElementWithText("plusfactor", ".00000"));
            gradeItem.AppendChild(CreateElementWithText("aggregationcoef", ".00000"));
            gradeItem.AppendChild(CreateElementWithText("aggregationcoef2", ".00000"));
            gradeItem.AppendChild(CreateElementWithText("weightoverride", "0"));
            gradeItem.AppendChild(CreateElementWithText("sortorder", "1"));
            gradeItem.AppendChild(CreateElementWithText("display", "0"));
            gradeItem.AppendChild(CreateElementWithText("decimals", MoodleNull));
            gradeItem.AppendChild(CreateElementWithText("hidden", "0"));
            gradeItem.AppendChild(CreateElementWithText("locked", "0"));
            gradeItem.AppendChild(CreateElementWithText("locktime", "0"));
            gradeItem.AppendChild(CreateElementWithText("needsupdate", "0"));
            gradeItem.AppendChild(CreateElementWithText("timecreated", "1468781855"));
            gradeItem.AppendChild(CreateElementWithText("timemodified", "1468781856"));
            gradeItem.AppendChild(CreateEmptyElement("grade_grades"));

            gradeItems.AppendChild(gradeItem);


            var gradeLetters = XmlDoc.CreateElement(string.Empty, "grade_letters", string.Empty);
            gradebook.AppendChild(gradeLetters);


            var gradeSettings = XmlDoc.CreateElement(string.Empty, "grade_settings", string.Empty);
            gradebook.AppendChild(gradeSettings);

            var gradeSetting = XmlDoc.CreateElement(string.Empty, "grade_setting", string.Empty);
            gradeSetting.SetAttribute("id", "");

            gradeSetting.AppendChild(CreateElementWithText("name", "minmaxtouse"));
            gradeSetting.AppendChild(CreateElementWithText("value", "1"));


            gradeSettings.AppendChild(gradeSetting);

        }
    }
}
