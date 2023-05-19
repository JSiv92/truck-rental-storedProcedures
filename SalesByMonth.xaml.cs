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
using JonathanSivananthanDADPartB.Models.DB;

namespace JonathanSivananthanDADPartB
{
    /// <summary>
    /// Interaction logic for SalesByMonth.xaml
    /// </summary>
    public partial class SalesByMonth : Window
    {
        public SalesByMonth()
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

            //parse combobox selection


            try
            {
                int month = int.Parse(monthComboBox.Text);
                int year = int.Parse(yearComboBox.Text);
                try
                {
                    monthlySalesDataGrid.ItemsSource = DAO.getSalesByMonth(month, year);
                }
                catch
                {
                    MessageBox.Show("No Sales data for this month and year");
                }
            }
            catch
            {
                MessageBox.Show("Please check date fields");
            }
        }
    }
}
