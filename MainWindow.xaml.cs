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
using JonathanSivananthanDADPartB.Models.DB;

namespace JonathanSivananthanDADPartB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void topfiveNavBtn_Click(object sender, RoutedEventArgs e)
        {
            TopFive form = new TopFive();
            this.Hide();
            form.Show();
        }

        private void selectedMonthNavBtn_Click(object sender, RoutedEventArgs e)
        {
            SalesByMonth form = new SalesByMonth();
            this.Hide();
            form.Show();
        }

        private void bottomfiveNavBtn_Click(object sender, RoutedEventArgs e)
        {
            BottomFive form = new BottomFive();
            this.Hide();
            form.Show();

        }

        private void dateRangeNavBtn_Click(object sender, RoutedEventArgs e)
        {
            SalesBetweenDate form = new SalesBetweenDate();
            this.Hide();
            form.Show();
        }
    }
}
