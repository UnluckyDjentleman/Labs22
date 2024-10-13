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
        private bool styleCheck = false;
        public MainWindow()
        {
            InitializeComponent();
            listView.ItemsSource = ListOfPlayers.listOfFA;
            this.Cursor = Cursors.Wait;
            App.LanguageChanged += languageChanged;
            CultureInfo currLang = App.Language;
        }
        Stack<Player> st = new Stack<Player>();
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

        private void Theme_Change(object sender, RoutedEventArgs e)
        {
            if (styleCheck)
            {
                var uri = new Uri("SimpleTheme.xaml", UriKind.Relative);
                var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
                styleCheck = false;
            }
            else
            {
                var uri = new Uri("DarkTheme.xaml", UriKind.Relative);
                var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
                styleCheck = true;
            }
        }

        private void undo_Click(object sender, RoutedEventArgs e)
        {
            if (ListOfPlayers.listOfFA.Count > 0)
            {
                st.Push(ListOfPlayers.listOfFA.Last());
                ListOfPlayers.listOfFA.RemoveAt(ListOfPlayers.listOfFA.Count - 1);
            }
            else
            {
                MessageBox.Show("You're kidding?");
            }
        }

        private void redo_Click(object sender, RoutedEventArgs e)
        {
            if (st.Count > 0)
            {
                var returned = st.Pop();
                ListOfPlayers.listOfFA.Add(returned);
            }
            else
            {
                MessageBox.Show("Cannot");
            }
        }

        private void bubble_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("sender: " + sender.ToString() + "\n" + "source: "+e.Source.ToString() + "\n");
        }

        private void tunnel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("sender: " + sender.ToString() + "\n" + "source: " + e.Source.ToString() + "\n");
        }

        private void direct_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sender: " + sender.ToString() + "\n" + "source: " + e.Source.ToString() + "\n");
        }
    }
}
