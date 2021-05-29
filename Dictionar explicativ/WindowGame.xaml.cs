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

namespace Dictionar_explicativ
{
    /// <summary>
    /// Interaction logic for WindowGame.xaml
    /// </summary>
    public partial class WindowGame : Window
    {
        public WindowGame()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            CuvantVM cuvinte = this.DataContext as CuvantVM;
            Random random = new Random();
            int maximNumber = cuvinte.Cuvinte.Count;
            int randomNumber = random.Next(0, maximNumber);
            Question.Content = cuvinte.Cuvinte[randomNumber];
        }
    }
}
