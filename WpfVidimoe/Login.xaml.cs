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
            SingInUser singInUser = new SingInUser();

            if (string.IsNullOrEmpty(TB_email_log.Text))
            {
                MessageBox.Show("Email is null");
                TB_email_log.Focus();
                return;
            }
            else if(string.IsNullOrEmpty(PB_password_log.Password))
            {
                MessageBox.Show("Password is null");
                PB_password_log.Focus();
                return;
            }

            singInUser.EmailSingIn = TB_email_log.Text;
            singInUser.PasswordSingIn = PB_password_log.Password;

            bool sing = client.SingIn(singInUser);

            if(sing == true)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Email or Password not valid");
            }
        }
    }
}
