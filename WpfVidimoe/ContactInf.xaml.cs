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

namespace WpfVidimoe
{
    public partial class ContactInf : Window
    {
        public ContactInf()
        {
            InitializeComponent();
        }

        private void BTN_close_contInf(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
