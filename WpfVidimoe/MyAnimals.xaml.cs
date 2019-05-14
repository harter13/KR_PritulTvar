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
        Service1Client client = new Service1Client();
        private ServiceReference1.SingInUser _user = null;
        public MyAnimals( SingInUser user)
        {
            _user = user;
            InitializeComponent();
            ShowMyTvar();
        }

        private void BTN_close(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        private void ShowMyTvar()
        {

            foreach (var item in client.GetUser())
            {
                if (_user.EmailSingIn == item.Email)
                {
                    foreach (var itemtv in client.GetTvar())
                    {
                        if (item.Id == itemtv.UserId)
                        {
                            LB_MyAnimals.Items.Add(itemtv.Type + " - " + itemtv.Nick);
                            LB_MyAnimals.Items.Add("");
                        }
                    }
                }
            }
        }

        private void BTN_delete(object sender, RoutedEventArgs e)
        {
            DataGrid x = (DataGrid)this.FindName("myDataGrid");
            var index = x.SelectedIndex;
            //var indexTvar = LB_MyAnimals.item;
            client.RemoveTvar(1);
        }
    }
}
