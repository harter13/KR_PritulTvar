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
    public partial class MyAnimals : Window
    {
        private ServiceReference1.SingInUser _user = null;
        public MyAnimals( SingInUser user)
        {
            _user = user;
            InitializeComponent();
            Start();
        }

        private void BTN_close(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        private void Start()
        {
            Service1Client client = new Service1Client();
            var tvar = client.GetTvar();
            //var users = GetUserById(tvar)
            int IDuser;
            foreach (var item in users)
            {
                if(_user.EmailSingIn == item.Email)
                {
                    IDuser = item.Id;
                }
            }

            foreach (var item in tvar)
            {
                if (IDuser == item.UserId)
                {
                    LB_MyAnimals.Items.Add(item.Type + " - " + item.Nick);
                }
            }
        }

        private void BTN_delete(object sender, RoutedEventArgs e)
        {

        }
    }
}
