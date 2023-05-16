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
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
            listUser.ItemsSource = DBContext.trade.User.ToList();

        }

        private void add_user_Click(object sender, RoutedEventArgs e)
        {
           new windows.AddUser().Show();
        }

        private void edit_user_Click(object sender, RoutedEventArgs e)
        {
            var item = (User)listUser.SelectedItem;
            if(listUser.SelectedItem != null)
            {
                DBContext.IdUser = item.UserID;
                new windows.EditUser().Show();

            }
            
        }

        private void up_user_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void del_user_Click(object sender, RoutedEventArgs e)
        {
            if(listUser.SelectedItem != null)
            {
                foreach (var item in listUser.SelectedItems)
                {
                    if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    { 
                        DBContext.trade.User.Remove((User)item);
                    }
                   
                }
                DBContext.trade.SaveChanges();
                LoadData();
            }
        }
        public void LoadData()
        {
            listUser.ItemsSource = DBContext.trade.User.ToList();
        }
    }
}
