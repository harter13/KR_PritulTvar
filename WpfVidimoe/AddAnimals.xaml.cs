using System;
using System.Collections.Generic;
using System.Linq;
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
    public partial class AddAnimals : Window
    {
        public AddAnimals()
        {
            InitializeComponent();
        }

        private void BTN_tv_add(object sender, RoutedEventArgs e)
        {
            Service1Client service1Client = new Service1Client();
            Tvar_ADD tvar_ADD = new Tvar_ADD();
            SingInUser singInUser = new SingInUser();

            List<TextBox> TB_Tva = new List<TextBox>() { TB_Tv_type, TB_Tv_breed, TB_Tv_color, TB_Tv_nick, TB_Tv_age, TB_Tv_Kg };

            foreach (var item in TB_Tva)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show("Field is null");
                    item.Focus();
                    return;
                }
            }

            if(double.TryParse(TB_Tv_age.Text,out double s))
            {
            }
            else
            {
                MessageBox.Show("Age not valid");
                TB_Tv_age.Focus();
                return;
            }

            if (double.TryParse(TB_Tv_Kg.Text, out double q))
            {
            }
            else
            {
                MessageBox.Show("Weight not valid");
                TB_Tv_Kg.Focus();
                return;
            }

            tvar_ADD.Type = new ServiceReference1.Type();
            tvar_ADD.Type.NameType = TB_Tv_type.Text;
            tvar_ADD.Breed = new Breed();
            tvar_ADD.Breed.NameBreed = TB_Tv_breed.Text;
            tvar_ADD.Color = new ServiceReference1.Color();
            tvar_ADD.Color.NameColor = TB_Tv_color.Text;
            tvar_ADD.Nick = TB_Tv_nick.Text;
            tvar_ADD.Age = double.Parse(TB_Tv_age.Text);
            tvar_ADD.Kg = double.Parse(TB_Tv_Kg.Text);
            tvar_ADD.Vaccination = VaccinationChoise.IsChecked ?? false;
            tvar_ADD.Castration = CastrationChoise.IsChecked ?? false;
            tvar_ADD.Information = TB_tv_addInf.Text;
            tvar_ADD.DateTime = DateTime.Now;

            service1Client.SetTvarina(tvar_ADD, singInUser);

            Hide();
        }
    }
}
