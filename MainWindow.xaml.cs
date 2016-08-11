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




            SaveZip();
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
