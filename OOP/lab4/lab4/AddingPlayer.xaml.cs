using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
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
using Microsoft.Win32;

namespace lab4
{
    /// <summary>
    /// Логика взаимодействия для AddingPlayer.xaml
    /// </summary>
    public partial class AddingPlayer : Window
    {
        public AddingPlayer()
        {
            InitializeComponent();
            var sri = Application.GetResourceStream(new Uri("arrow.cur", UriKind.Relative));
            var customCursor = new Cursor(sri.Stream);
            Cursor = customCursor;
            this.DataContext = new Player();
        }
        Player player = new Player();
        private bool ComboCheckers()
        {
            if (PositionPlayer.Text == "")
            {
                MessageBox.Show("Select position!");
                return false;
            }
            return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var res = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            player = new Player(((ImageBrush)photo.Background).ImageSource.ToString(), name.Text,player.Country,PositionPlayer.Text,Convert.ToInt32(age.Text),Convert.ToDouble(height.Text),Convert.ToDouble(weight.Text));
            var cont = new ValidationContext(player);
            if (Validator.TryValidateObject(player, cont, res, true)&&ComboCheckers()&&this.ToString()!="Wrong country")
            {
                ListOfPlayers.listOfFA.Add(player);
                MessageBox.Show("Player is added");
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
            switch (countryPlayer.SelectedIndex)
            {
                case 0: player.Country = "USA"; break;
                case 1: player.Country = "Slovakia"; break;
                case 2: player.Country = "Canada"; break;
                case 3: player.Country = "Sweden"; break;
                case 4: player.Country = "Finland"; break;
                case 5: player.Country = "Czechia"; break;
                default: return "Wrong country";
            }
            return player.Country;
        }
    }
}
