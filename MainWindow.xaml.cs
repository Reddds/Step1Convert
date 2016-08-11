using System.Collections.Generic;
using System.Windows;
using Ionic.Zip;
using Step1Convert.Generators;

namespace Step1Convert
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> _files = new Dictionary<string, string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(FpPathToOutput.FileName))
            {
                MessageBox.Show("Введите имя выходного файла!", "Ошибка генерации курса", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var users = new Users();
            _files.Add("users.xml", users.GetXml());

            var scales = new Scales();
            _files.Add("scales.xml", scales.GetXml());

            var roles = new Roles();
            _files.Add("roles.xml", roles.GetXml());

            var questions = new Questions();
            _files.Add("questions.xml", questions.GetXml());

            var outcomes = new Outcomes();
            _files.Add("outcomes.xml", outcomes.GetXml());

            var groups = new Groups();
            _files.Add("groups.xml", groups.GetXml());

            var files = new Files();
            _files.Add("files.xml", files.GetXml());

            var completion = new Completion();
            _files.Add("completion.xml", completion.GetXml());

            var badges = new Badges();
            _files.Add("badges.xml", badges.GetXml());

            var gradeHistory = new GradeHistory();
            _files.Add("grade_history.xml", gradeHistory.GetXml());

            var gradeBook = new Gradebook();
            _files.Add("gradebook.xml", gradeBook.GetXml());


            // ------- Course -------------------------------------------------

            var courseRoles = new Generators.Course.Roles();
            _files.Add("course/roles.xml", courseRoles.GetXml());

            var courseInforef = new Generators.Course.Inforef();
            _files.Add("course/inforef.xml", courseInforef.GetXml());

            var courseFilters = new Generators.Course.Filters();
            _files.Add("course/filters.xml", courseFilters.GetXml());

            var courseComments = new Generators.Course.Comments();
            _files.Add("course/comments.xml", courseComments.GetXml());

            var courseCalendar = new Generators.Course.Calendar();
            _files.Add("course/calendar.xml", courseCalendar.GetXml());

            // blocks

            var searchForums13Block = new Generators.Course.Blocks.Block(13, 19, 2014111000, "search_forums", 18);
            _files.Add("course/blocks/search_forums_13/block.xml", searchForums13Block.GetXml());



            var newsItems14Block = new Generators.Course.Blocks.Block(14, 20, 2014111000, "news_items", 18, defaultweight: 1);
            _files.Add("course/blocks/news_items_14/block.xml", newsItems14Block.GetXml());



            var calendarUpcoming15Block = new Generators.Course.Blocks.Block(15, 21, 2014111000, "calendar_upcoming", 18, defaultweight: 2);
            _files.Add("course/blocks/calendar_upcoming_15/block.xml", calendarUpcoming15Block.GetXml());



            var recentActivity16Block = new Generators.Course.Blocks.Block(16, 22, 2014111000, "recent_activity", 18, defaultweight: 3);
            _files.Add("course/blocks/recent_activity_16/block.xml", recentActivity16Block.GetXml());


            // ---------------------------------------------------------------------------------------------------
            SaveZip();
            MessageBox.Show("Конвертация завершена!", "Готово!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SaveZip()
        {
            using (var zip = new ZipFile())
            {
                foreach (var file in _files)
                {
                    zip.AddEntry(file.Key, file.Value);
                }
                zip.Save(FpPathToOutput.FileName);
            }
        }
    }
}
