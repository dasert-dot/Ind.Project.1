using WpfApp1.Core;
using WpfApp1;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Core.Core.Connection = MainFrame;
            MainFrame.Navigate(new Page1());
        }

        private void BtnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            Core.Core.Connection.Navigate(new Page1());
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnContacts_Click(object sender, RoutedEventArgs e)
        {
            Core.Core.Connection.Navigate(new Pages.Page3());
        }

        private void BtnCondition_Click(object sender, RoutedEventArgs e)
        {
            Core.Core.Connection.Navigate(new Pages.Page4());
        }

        private void BtnServices_Click(object sender, RoutedEventArgs e)
        {
            Core.Core.Connection.Navigate(new Pages.Page2());
        }
    }
}
