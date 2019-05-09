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
        }
    }
}
