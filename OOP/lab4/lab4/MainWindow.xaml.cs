using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Markup;
using System.Xml.Serialization;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;

namespace lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var sri = Application.GetResourceStream(new Uri("arrow.cur", UriKind.Relative));
            var customCursor = new Cursor(sri.Stream);
            Cursor = customCursor;
            App.LanguageChanged += languageChanged;
            listView.ItemsSource = ListOfPlayers.listOfFA;
            CultureInfo currLang = App.Language;
        }
        private void languageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddingPlayer addingPlayer = new AddingPlayer();
            addingPlayer.Show();
        }
        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            Filtrator filtrator = new Filtrator();
            filtrator.Show();
        }
        private void XML_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<Player>));
            using (FileStream fs = new FileStream("Players.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, ListOfPlayers.listOfFA);
                MessageBox.Show("All players are serialized to XML");
            }
        }

        private void uk_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("en-US");
            App.Language = lang;
        }

        private void bl_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("be-BY");
            App.Language = lang;
        }
    }
}
