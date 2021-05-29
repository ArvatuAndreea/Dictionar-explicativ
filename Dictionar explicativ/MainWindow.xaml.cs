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

namespace Dictionar_explicativ
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CuvantVM cuvinte = new CuvantVM();
            WindowAdmin wa = new WindowAdmin();
            wa.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowSearch ws = new WindowSearch();
            ws.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowGame wg = new WindowGame();
            wg.Show();
        }
    }
}
