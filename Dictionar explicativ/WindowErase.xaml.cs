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
    /// Interaction logic for WindowErase.xaml
    /// </summary>
    public partial class WindowErase : Window
    {
        public WindowErase()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CuvantVM cuvinte = this.DataContext as CuvantVM;
            string cuv = textBoxErase.Text;
            cuvinte.stergereCuvant(cuv);
        }
    }
}
