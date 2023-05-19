using JonathanSivananthanDADPartB.Models.DB;
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

namespace JonathanSivananthanDADPartB
{
    /// <summary>
    /// Interaction logic for SalesBetweenDate.xaml
    /// </summary>
    public partial class SalesBetweenDate : Window
    {
        public SalesBetweenDate()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            this.Hide();
            form.Show();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //parse datepicker selections
                DateTime date1 = DatePicker1.SelectedDate.GetValueOrDefault();
                DateTime date2 = DatePicker2.SelectedDate.GetValueOrDefault();
                saleDatesDataGrid.ItemsSource = DAO.getBetweenDates(date1, date2);
            }
            catch
            {
                MessageBox.Show("Please select 2 date values");
            }

        }
    }
}
