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
    public partial class Search : Window
    {
        Service1Client client = new Service1Client();
        double vik;
        double ves;
        bool vac;
        bool cas;
        List<int> searchTv = new List<int>();

        public Search()
        {
            InitializeComponent();
        }

        private void Slider_chngedAge(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            vik = ((Slider)sender).SelectionEnd = e.NewValue;
        }

        private void Slider_chngedKg(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ves = ((Slider)sender).SelectionEnd = e.NewValue;
        }

        private void BTN_search(object sender, RoutedEventArgs e)
        {
            vac = VaccinationChoise.IsChecked ?? false;
            cas = CastrationChoise.IsChecked ?? false;
            
            foreach (var item in client.GetTvar())
            {
                if(TB_Searc_type.Text == item.Type || TB_Searc_type.Text == "")
                {
                    if (TB_Searc_breed.Text == item.Breed || TB_Searc_breed.Text == "")
                    {
                        if (TB_Searc_color.Text == item.Color || TB_Searc_color.Text == "")
                        {
                            if(vik > item.Age || vik == 0)
                            {
                                if(ves > item.Kg || ves == 0)
                                {
                                    if(vac == item.Vaccination)
                                    {
                                        if(cas == item.Castration)
                                        {
                                            searchTv.Add(item.Id);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }

            Close();
        }

        public List<int> GetListSearc()
        {
            return searchTv;
        }
    }
}
