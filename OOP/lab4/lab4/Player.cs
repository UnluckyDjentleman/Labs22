using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using lab4.Models;
using Microsoft.Win32;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace lab4
{
    [DataContractAttribute]
    public class Player:Objects
    {
        [DataMember]
        public string Image { get; set; }
        [DataMember]
        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+(-'[A-Z][a-z]+)?$", ErrorMessage = "Wrong name")]
        public string Name { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Position { get; set; }
        [DataMember]
        [Range(17,50,ErrorMessage="Wrong age")]
        public int Age { get; set; }
        [DataMember]
        [Range(165,210,ErrorMessage ="Wrong height")]
        public double Height { get; set; }
        [DataMember]
        [Range(60,125, ErrorMessage = "Wrong weight")]
        public double Weight { get; set; }
        public Player()
        {

        }
        public Player(string image,string name,string country, string position, int age,double height,double weight)
        {
            this.Image = image;
            this.Name = name;
            this.Country = country;
            this.Position = position;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
        }
        #region CommandToRemove
        private readonly RelayCommand _remover;
        public RelayCommand Remover
        {
            get
            {
                return _remover ?? (new RelayCommand(obj =>
                {
                   ListOfPlayers.listOfFA.Remove(this);
                }));
            }
        }
        #endregion
        #region CommandToEdit
        private readonly RelayCommand _editor;
        public RelayCommand Editor
        {
            get
            {
                return _editor ?? (new RelayCommand(obj =>
                {
                    UpdatePlayer updPlayer = new UpdatePlayer();
                    updPlayer.DataContext = this;
                    ImagePath = this.Image;
                    switch (this.Country)
                    {
                        case "USA": updPlayer.countryPlayer.SelectedItem=updPlayer.usa; break;
                        case "Slovakia": updPlayer.countryPlayer.SelectedItem = updPlayer.svk; break;
                        case "Canada": updPlayer.countryPlayer.SelectedItem = updPlayer.can; break;
                        case "Sweden": updPlayer.countryPlayer.SelectedItem = updPlayer.swe; break;
                        case "Finland": updPlayer.countryPlayer.SelectedItem = updPlayer.fin; break;
                        case "Czechia": updPlayer.countryPlayer.SelectedItem = updPlayer.cze; break;
                        default: break;
                    }
                    updPlayer.Show();
                }));
            }
        }
        #endregion
        #region Image
        private string _imagePath;
        public string ImagePath
        {
            get
            {
                return _imagePath;
            }
            set
            {
                if (!(value is string))
                    return;

                _imagePath = value.ToString();
                OnPropertyChanged("ImagePath");
            }
        }
        #endregion
        #region CommandForPhoto
        private readonly RelayCommand _openFileDialog;
        public RelayCommand ChoosePhoto
        {
            get
            {
                return _openFileDialog ?? (new RelayCommand(obj =>
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Multiselect = false;
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.apng;*.avif;*.gif;*.jfif;*.pjpeg";
                    ofd.ShowDialog();
                    ImagePath = ofd.FileName;
                }));
            }
        }
        #endregion
    }
}
