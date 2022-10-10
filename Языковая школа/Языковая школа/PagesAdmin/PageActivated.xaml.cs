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
    /// Логика взаимодействия для PageActivated.xaml
    /// </summary>
    public partial class PageActivated : Page
    {
        public PageActivated()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (Cod.Password == "0000")
            {
                AppFrame.frameMain.Navigate(new PageMainAdmin());
            }
            else
            {
                MessageBox.Show("Введен неверный код", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }
    }
}
