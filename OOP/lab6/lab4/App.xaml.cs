using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Globalization;

namespace lab4
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static List<CultureInfo> m_Languages = new List<CultureInfo>();

        public static List<CultureInfo> Languages
        {
            get
            {
                return m_Languages;
            }
        }

        public App()
        {
            m_Languages.Clear();
            m_Languages.Add(new CultureInfo("en-US"));
            m_Languages.Add(new CultureInfo("be-BY")); //Neutral
        }

        //Event for all windows of app
        public static event EventHandler LanguageChanged;

        public static CultureInfo Language
        {
            get
            {
                return System.Threading.Thread.CurrentThread.CurrentUICulture;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                if (value == System.Threading.Thread.CurrentThread.CurrentUICulture) return;

                //1. Change language:
                System.Threading.Thread.CurrentThread.CurrentUICulture = value;

                //2. Create ResourceDictionary
                ResourceDictionary dict = new ResourceDictionary();
                switch (value.Name)
                {
                    case "be-BY":
                        dict.Source = new Uri(String.Format("BelarusianDictionary.xaml", value.Name), UriKind.Relative);
                        break;
                    default:
                        dict.Source = new Uri("EnglishDictionary.xaml", UriKind.Relative);
                        break;
                }

                //3. Found old and replace it
                ResourceDictionary oldDict = (from d in Application.Current.Resources.MergedDictionaries
                                              where d.Source != null
                                              select d).FirstOrDefault();
                if (oldDict != null)
                {
                    int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
                    Application.Current.Resources.MergedDictionaries.Remove(oldDict);
                    Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
                }
                else
                {
                    Application.Current.Resources.MergedDictionaries.Add(dict);
                }

                //4. event for all windows
                LanguageChanged(Application.Current, new EventArgs());
            }
        }
    }
}