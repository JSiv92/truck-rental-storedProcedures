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
    /// Interaction logic for BottomFive.xaml
    /// </summary>
    public partial class BottomFive : Window
    {
        public BottomFive()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            this.Hide();
            form.Show();
        }

        private void getBottomFiveBtn_Click(object sender, RoutedEventArgs e)
        {
            bottomFiveDataGrid.ItemsSource = DAO.getBottomFiveModels();
        }
    }
}
