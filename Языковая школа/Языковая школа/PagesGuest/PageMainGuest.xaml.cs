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
using Языковая_школа.AplplicationData;

namespace Языковая_школа.PageGuest
{
    /// <summary>
    /// Логика взаимодействия для PageMainGuest.xaml
    /// </summary>
    public partial class PageMainGuest : Page
    {
        public PageMainGuest()
        {
            InitializeComponent();
            SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.ToList();
            SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Count() + " из " + AppConnect.modelOdb.Service.Count();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }

        private void SortPoCene_Checked(object sender, RoutedEventArgs e)
        {
            SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.OrderByDescending(x => x.Cost).ToList();
            SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Count() + " из " + AppConnect.modelOdb.Service.Count();
        }

        private void SortPoCene_Unchecked(object sender, RoutedEventArgs e)
        {
            SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.OrderBy(x => x.Cost).ToList();
            SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Count() + " из " + AppConnect.modelOdb.Service.Count();
        }

        private void Skidki_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Skidki.SelectedIndex == 0)
            {
                SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.Where(x => x.Discount >= 0 && x.Discount < 0.05).ToList();
                SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Where(x => x.Discount >= 0 && x.Discount < 0.05).Count() + " из " + AppConnect.modelOdb.Service.Count();
            }
            else if (Skidki.SelectedIndex == 1)
            {
                SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.05 && x.Discount < 0.15).ToList();
                SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.05 && x.Discount < 0.15).Count() + " из " + AppConnect.modelOdb.Service.Count();
            }
            else if (Skidki.SelectedIndex == 2)
            {
                SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.15 && x.Discount < 0.30).ToList();
                SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.15 && x.Discount < 0.30).Count() + " из " + AppConnect.modelOdb.Service.Count();
            }
            else if (Skidki.SelectedIndex == 3)
            {
                SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.30 && x.Discount < 0.70).ToList();
                SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.30 && x.Discount < 0.70).Count() + " из " + AppConnect.modelOdb.Service.Count();
            }
            else if (Skidki.SelectedIndex == 4)
            {
                SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.70 && x.Discount <= 1.00).ToList();
                SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.70 && x.Discount <= 1.00).Count() + " из " + AppConnect.modelOdb.Service.Count();
            }
        }

        private void Sbros_Click(object sender, RoutedEventArgs e)
        {
            SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.ToList();
            SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Count() + " из " + AppConnect.modelOdb.Service.Count();
        }

        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Poisk.Text == null || Poisk.Text == "")
            {
                if (Skidki.SelectedIndex == 0)
                {
                    SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.Where(x => x.Discount >= 0 && x.Discount < 0.05).ToList();
                    SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Where(x => x.Discount >= 0 && x.Discount < 0.05).Count() + " из " + AppConnect.modelOdb.Service.Count();
                }
                else if (Skidki.SelectedIndex == 1)
                {
                    SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.05 && x.Discount < 0.15).ToList();
                    SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.05 && x.Discount < 0.15).Count() + " из " + AppConnect.modelOdb.Service.Count();
                }
                else if (Skidki.SelectedIndex == 2)
                {
                    SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.15 && x.Discount < 0.30).ToList();
                    SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.15 && x.Discount < 0.30).Count() + " из " + AppConnect.modelOdb.Service.Count();
                }
                else if (Skidki.SelectedIndex == 3)
                {
                    SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.30 && x.Discount < 0.70).ToList();
                    SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.30 && x.Discount < 0.70).Count() + " из " + AppConnect.modelOdb.Service.Count();
                }
                else if (Skidki.SelectedIndex == 4)
                {
                    SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.70 && x.Discount <= 1.00).ToList();
                    SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Where(x => x.Discount >= 0.70 && x.Discount <= 1.00).Count() + " из " + AppConnect.modelOdb.Service.Count();
                }
            }
            else
            {
                SpisokYslus.ItemsSource = AppConnect.modelOdb.Service.Where(x => x.Title.ToLower().Contains(Poisk.Text.ToLower())).ToList();
                SkolkoZapisey.Text = "Всего записей: " + AppConnect.modelOdb.Service.Where(x => x.Title.ToLower().Contains(Poisk.Text.ToLower())).Count() + " из " + AppConnect.modelOdb.Service.Count();
            }
        }
    }
}
