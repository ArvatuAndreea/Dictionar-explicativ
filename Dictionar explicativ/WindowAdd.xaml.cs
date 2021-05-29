using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public WindowAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CategorieVM categorii = this.DataContext as CategorieVM;
            string categorie = textBoxAddCategory.Text;
            categorii.adaugareCategorie(categorie);
        }

        private void txtEditor_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Open_File_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CuvantVM cuvinte = this.DataContext as CuvantVM;
            cuvinte = new CuvantVM();
            string cuv=textBoxAddWord.Text, descriere=textBoxAddDescription.Text, categorie=Categorie.Text;
            cuvinte.adaugareCuvant(cuv, descriere, categorie);
            Console.WriteLine("cuvant adaugat.");
        }
    }
}
