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
    /// Логика взаимодействия для PageEdit.xaml
    /// </summary>
    public partial class PageEdit : Page
    {
        public PageEdit()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }
    }
}
