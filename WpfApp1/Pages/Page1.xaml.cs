using System;
using System.Collections.Generic;
using System.Data.Common;
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
using WpfApp1.Core;
using WpfApp1.SQL;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private DataContext? _db = new DataContext();
        private Users _users = new Users();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(emailTB.Text) && string.IsNullOrEmpty(phoneTB.Text) && string.IsNullOrEmpty(nameTB.Text))
            {
                MessageBox.Show("У вас есть не заполненые поля", "Eror", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
            else
            {
                _users.email = emailTB.Text;
                _users.phone = phoneTB.Text;
                _users.name = nameTB.Text;
                _db?.User.Add(_users);
                _db?.SaveChanges();
                MessageBox.Show("Спасибо, что выбрали нас, ожидайте звонка оператора!)", "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
