using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace lab4
{
    /// <summary>
    /// Логика взаимодействия для Filtrator.xaml
    /// </summary>
    public partial class Filtrator : Window
    {
        public Filtrator()
        {
            InitializeComponent();
            listView.ItemsSource = ListOfPlayers.listOfFA;
        }
        private void SearchTermTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox.Text != "")
            {
                SearchText.Visibility = Visibility.Hidden;
            }
            IEnumerable<Player> resultOfSearchByText =ListOfPlayers.listOfFA.Where(n =>n.Name.Contains(SearchTextBox.Text));
            listView.ItemsSource = resultOfSearchByText;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int minA;
            int maxA;
            double minH;
            double maxH;
            double minW;
            double maxW;
            if (MinAge.Text != "") { minA = int.Parse(MinAge.Text); }
            else { minA = 0; }
            if (MaxAge.Text != "") { maxA = int.Parse(MaxAge.Text); }
            else { maxA = 0; }
            if (MinHeight.Text != "") { minH = int.Parse(MinHeight.Text); }
            else { minH = 0; }
            if (MaxHeight.Text != "") { maxH = int.Parse(MaxHeight.Text); }
            else { maxH = 0; }
            if (MinWeight.Text != "") { minW = int.Parse(MinWeight.Text); }
            else { minW = 0; }
            if (MinWeight.Text != "") { maxW = int.Parse(MaxWeight.Text); }
            else { maxW = 0; }
            IEnumerable<Player> resultOfSearchByFieldForSearch = ListOfPlayers.listOfFA.Where(n => 
            n.Country==ToString()||
            n.Position==PositionPlayer.Text||
            (n.Age>=minA&&n.Age <= maxA&&minA!=0&&maxA!=0&&minA<maxA)||
            (n.Height >= minH&& n.Height <= maxH && minH != 0 && maxH != 0 && minH < maxH) ||
            (n.Weight >= minW && n.Weight <= maxW && minW != 0 && maxW != 0 && minW < maxW)
            );
            if (resultOfSearchByFieldForSearch.Count() == 0)
            {
                resultOfSearchByFieldForSearch = ListOfPlayers.listOfFA;
            }
            resultOfSearchByFieldForSearch = SelectedSort(resultOfSearchByFieldForSearch);
            listView.ItemsSource = resultOfSearchByFieldForSearch;
            PositionPlayer.Text = "";
            countryPlayer.SelectedIndex = -1;
            this.MinAge.Text = "";
            this.MaxAge.Text = "";
            this.MinHeight.Text = "";
            this.MaxHeight.Text = "";
            this.MaxWeight.Text = "";
            this.MinWeight.Text = "";
            this.SearchTextBox.Text = "";
        }
        public override string ToString()
        {
            switch (countryPlayer.SelectedIndex)
            {
                case 0: return "USA"; 
                case 1: return "Slovakia"; 
                case 2: return "Canada"; 
                case 3: return "Sweden"; 
                case 4: return "Finland"; 
                case 5: return "Czechia"; 
                default: return "";
            }
        }
        public IEnumerable<Player> SelectedSort(IEnumerable<Player> pl)
        {
            if (Ordering.SelectedItem == ageSort && (bool)!Desc.IsChecked)
            {
                return pl.OrderBy(n => n.Age);
            }
            else if (Ordering.SelectedItem == heightSort && (bool)!Desc.IsChecked)
            {
                return pl.OrderBy(n => n.Height);
            }
            else if (Ordering.SelectedItem == weightSort && (bool)!Desc.IsChecked)
            {
                return pl.OrderBy(n => n.Weight);
            }
            else if (Ordering.SelectedItem == ageSort && (bool)Desc.IsChecked)
            {
                return pl.OrderByDescending(n => n.Age);
            }
            else if (Ordering.SelectedItem == heightSort && (bool)Desc.IsChecked)
            {
                return pl.OrderByDescending(n => n.Height);
            }
            else if (Ordering.SelectedItem == weightSort && (bool)Desc.IsChecked)
            {
                return pl.OrderByDescending(n => n.Weight);
            }
            else
            {
                return pl;
            }
        }
    }
}
