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
    /// Interaction logic for TopFive.xaml
    /// </summary>
    public partial class TopFive : Window
    {
        public TopFive()
        {
            InitializeComponent();
        }

        private void getTopFiveBtn_Click(object sender, RoutedEventArgs e)
        {
           topFiveDataGrid.ItemsSource = DAO.getTopFiveTrucks();   
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            this.Hide();
            form.Show();
        }
    }
}
