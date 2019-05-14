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
using WpfVidimoe.ServiceReference1;

namespace WpfVidimoe
{
    public partial class MainWindow : Window
    {
        private ServiceReference1.SingInUser _user = null;
        public MainWindow(SingInUser user)
        {
            _user = user;
            InitializeComponent();
        }

        private void BTN_exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_info(object sender, RoutedEventArgs e)
        {
            ContactInf contactInf = new ContactInf();
            contactInf.Show();
        }

        private void BTN_search(object sender, RoutedEventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void Menu_addAnimal(object sender, RoutedEventArgs e)
        {
            AddAnimals addAnimals = new AddAnimals(_user);
            addAnimals.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MyAnimals myAnimals = new MyAnimals(_user);
            myAnimals.Show();
        }
    }
}
