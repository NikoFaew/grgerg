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

namespace AppWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void order_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void user_button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.UserPage());
        }

        private void product_button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.ProductPage());
        }

        private void role_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
