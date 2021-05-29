using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
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
    /// Interaction logic for OpenFileDialog.xaml
    /// </summary>
    public partial class OpenFileDialog : Window
    {

        public OpenFileDialog()
        {
            InitializeComponent();
        }

        public string FileName { get; private set; }
        public string Filter { get; private set; }
        public string InitialDirectory { get; private set; }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg files(.jpg)|.jpg| PNG files(.png)|.png| GIF files(.gif)|.gif| ";
           // if (openFileDialog.ShowDialog() == true)
             //  txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            openFileDialog.InitialDirectory = @"c:\temp\";
        }
    }
}
