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
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = DBContext.trade.User.ToList().Find(x => x.UserID == DBContext.IdUser);
                user.UserSurname = SurnameTxt.Text;
                user.UserName = NameTxt.Text;
                user.UserPatronymic = PatronTxt.Text;
                user.UserLogin = LoginTxt.Text;
                user.UserPassword = PasswordTxt.Text;
                user.UserRole = Int32.Parse(RoleTxt.Text);
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
