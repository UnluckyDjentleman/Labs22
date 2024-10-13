using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using lab4.Models;

namespace lab4
{
    /// <summary>
    /// Логика взаимодействия для UpdatePlayer.xaml
    /// </summary>
    public partial class UpdatePlayer : Window
    {
        public UpdatePlayer()
        {
            InitializeComponent();
            var sri = Application.GetResourceStream(new Uri("arrow.cur", UriKind.Relative));
            var customCursor = new Cursor(sri.Stream);
            Cursor = customCursor;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var res = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            Player updatedPlayer = ListOfPlayers.listOfFA.Single(n => n == this.DataContext);
            UpdatingPlayer(updatedPlayer);
            var cont = new ValidationContext(updatedPlayer);
            if (Validator.TryValidateObject(updatedPlayer, cont, res, true) && PositionPlayer.Text != "" && this.ToString() != "Wrong country")
            {
                MessageBox.Show("Player is updated");
                this.Close();
            }
            else
            {
                foreach (System.ComponentModel.DataAnnotations.ValidationResult resus1 in res)
                    MessageBox.Show(resus1.ErrorMessage);
            }
        }
        public override string ToString()
        {
            if (countryPlayer.SelectedItem == this.usa)
            {
                return "USA";
            }
            else if(countryPlayer.SelectedItem == this.svk)
            {
                return "Slovakia";
            }
            else if (countryPlayer.SelectedItem == this.can)
            {
                return "Canada";
            }
            else if (countryPlayer.SelectedItem == this.swe)
            {
                return"Sweden";
            }
            else if (countryPlayer.SelectedItem == this.fin)
            {
                return "Finland";
            }
            else if (countryPlayer.SelectedItem == this.cze)
            {
                return "Czechia";
            }
            else
            {
                return "Wrong country";
            }
        }
        private void UpdatingPlayer(Player player)
        {
            player.Image=((ImageBrush)photo.Background).ImageSource.ToString();
            player.OnPropertyChanged("Image");
            player.Name= name.Text;
            player.OnPropertyChanged("Name");
            player.Country= this.ToString();
            player.OnPropertyChanged("Country");
            player.Position= PositionPlayer.Text;
            player.OnPropertyChanged("Position");
            player.Age= Convert.ToInt32(age.Text);
            player.OnPropertyChanged("Age");
            player.Height= Convert.ToDouble(height.Text);
            player.OnPropertyChanged("Height");
            player.Weight= Convert.ToDouble(weight.Text);
            player.OnPropertyChanged("Weight");
        }
    }
}
