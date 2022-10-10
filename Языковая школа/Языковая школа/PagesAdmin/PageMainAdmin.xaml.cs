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

namespace Языковая_школа.PagesAdmin
{
    /// <summary>
    /// Логика взаимодействия для PageMainAdmin.xaml
    /// </summary>
    public partial class PageMainAdmin : Page
    {
        public PageMainAdmin()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageAdd());
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageEdit());
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ZapisNaYslugi_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageZapNaYsl());
        }

        private void BlizhniyeZapisi_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageBlizZap());
        }
    }
}
