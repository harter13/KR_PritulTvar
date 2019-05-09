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
using WpfVidimoe.ServiceReference1;

namespace WpfVidimoe
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTN_registr_log(object sender, RoutedEventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();
            Hide();
        }

        private void BTN_singIn_log(object sender, RoutedEventArgs e)
        {
            Service1Client client = new Service1Client();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
