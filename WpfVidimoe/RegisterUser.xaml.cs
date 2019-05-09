using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
    
    public partial class RegisterUser : Window
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void BTN_reg_reg(object sender, RoutedEventArgs e)
        {
            Service1Client client = new Service1Client();
            RegUser regUser = new RegUser();

            if(string.IsNullOrEmpty(TB_Us_Name.Text))
            {
                MessageBox.Show("User name is null");
                TB_Us_Name.Focus();
                return;
            }
            else if(string.IsNullOrEmpty(TB_Us_Surname.Text))
            {
                MessageBox.Show("User surname is null");
                TB_Us_Name.Focus();
                return;
            }

            regUser.Name = TB_Us_Name.Text;
            regUser.SurName = TB_Us_Surname.Text;

            if (Regex.IsMatch(TB_Us_Telephone.Text, @"^(\+[0-9]{12})$"))
            {
                regUser.Tel = TB_Us_Telephone.Text;
            }
            else
            {
                MessageBox.Show("Telephone not valid");
                TB_Us_Telephone.Focus();
                return;
            }

            try
            {
                MailAddress m = new MailAddress(TB_Us_Email.Text);
                regUser.Email = TB_Us_Email.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Email not valid");
                TB_Us_Email.Focus();
                return;
            }

            if(Regex.IsMatch(TB_Us_Pass1.Text, @"(?=^.{6,12}$)(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?!.*\s).*$"))
            {
            }
            else
            {
                MessageBox.Show("Password not valid");
                TB_Us_Email.Focus();
                return;
            }

            if (TB_Us_Pass1.Text == TB_Us_Pass2.Text)
            {
                regUser.Password = TB_Us_Pass1.Text;
            }
            else
            {
                MessageBox.Show("Password and Second password no repeat");
                TB_Us_Pass1.Focus();
                return;
            }

            client.SetUser(regUser);
            Login login = new Login();
            login.Show();
            Hide();
        }
    }
}
