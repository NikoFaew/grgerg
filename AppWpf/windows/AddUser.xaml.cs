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
using System.Windows.Shapes;

namespace AppWpf.windows
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = new User
                {
                    UserSurname = SurnameTxt.Text,
                    UserName = NameTxt.Text,
                    UserPatronymic = PatronTxt.Text,
                    UserLogin = LoginTxt.Text,
                    UserPassword =  PasswordTxt.Text,
                    UserRole = Int32.Parse(RoleTxt.Text)
                };
                DBContext.trade.User.Add(user);
                DBContext.trade.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
