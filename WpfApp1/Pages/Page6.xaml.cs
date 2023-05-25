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
using WpfApp1.SQL;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        DataContext _db = new DataContext();
        Users _user = new Users();
        public Page6()
        {
            InitializeComponent();
            List<Users> users = _db.User.ToList();
            listinf.ItemsSource = users;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Core.Core.Connection.Navigate(new Pages.Page3());
        }
    }
}
