using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Dictionar_explicativ
{
    class CategorieVM
    {
        public ObservableCollection<string> Categorii { get; set; }
        public CategorieVM()
        {
            Categorii = new ObservableCollection<string>();
            Categorii.Add("mobila");
            Categorii.Add("fructe");
            Categorii.Add("legume");
            Categorii.Add("dispozitive electronice");
            Categorii.Add("vesela");
        }

        public void adaugareCategorie(string categorie)
        {
            Categorii.Add(categorie);
            Console.WriteLine("categorie adaugata");
        }
    }
}
