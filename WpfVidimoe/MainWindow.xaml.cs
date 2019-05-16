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
        Service1Client client = new Service1Client();
        List<int> searcShow = new List<int>();
        public MainWindow(SingInUser user)
        {
            InitializeComponent();
            _user = user;
            ShowTvar();
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
            search.ShowDialog();
            searcShow = search.GetListSearc();

            LB_showMain.Items.Clear();
            foreach (var items in searcShow)
            {
                foreach (var item in client.GetTvar())
                {
                    if (item.Id == items)
                    {
                        LB_showMain.Items.Add("Type : " + item.Type);
                        LB_showMain.Items.Add("Breed : " + item.Breed);
                        LB_showMain.Items.Add("Color : " + item.Color);
                        LB_showMain.Items.Add("Nick : " + item.Nick);
                        LB_showMain.Items.Add("Age : " + item.Age);
                        LB_showMain.Items.Add("Width : " + item.Kg);
                        LB_showMain.Items.Add("Vaccination : " + item.Vaccination);
                        LB_showMain.Items.Add("Castration : " + item.Castration);
                        LB_showMain.Items.Add("Information : " + item.Information);
                        LB_showMain.Items.Add("Data of Publication: " + item.DateTime);
                        LB_showMain.Items.Add("");
                    }
                }
            }
        }

        private void Menu_addAnimal(object sender, RoutedEventArgs e)
        {
            AddAnimals addAnimals = new AddAnimals(_user);
            addAnimals.ShowDialog();
            LB_showMain.Items.Clear();
            ShowTvar();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MyAnimals myAnimals = new MyAnimals(_user);
            myAnimals.ShowDialog();
            LB_showMain.Items.Clear();
            ShowTvar();
        }

        public void ShowTvar()
        {
            LB_showMain.Items.Clear();
            foreach (var item in client.GetTvar())
            {
                LB_showMain.Items.Add("Type : " + item.Type);
                LB_showMain.Items.Add("Breed : " + item.Breed);
                LB_showMain.Items.Add("Color : " + item.Color);
                LB_showMain.Items.Add("Nick : " + item.Nick);
                LB_showMain.Items.Add("Age : " + item.Age);
                LB_showMain.Items.Add("Width : " + item.Kg);
                LB_showMain.Items.Add("Vaccination : " + item.Vaccination);
                LB_showMain.Items.Add("Castration : " + item.Castration);
                LB_showMain.Items.Add("Information : " + item.Information);
                LB_showMain.Items.Add("Data of Publication: " + item.DateTime);
                LB_showMain.Items.Add("");
            }
        }

        private void BTN_showall(object sender, RoutedEventArgs e)
        {
            ShowTvar();
        }
    }
}
