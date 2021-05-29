using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dictionar_explicativ
{
    class Cuvant : INotifyPropertyChanged
    {
        public Cuvant()
        {
            Denumire = "";
            Descriere = "";
            Categorie = "";
        }

        private string denumire;
        public string Denumire
        {
            get
            {
                return denumire;
            }
            set
            {
                denumire = value;
                NotifyPropertyChanged("Denumire");
            }
        }

        private string descriere;
        public string Descriere
        {
            get
            {
                return descriere;
            }
            set
            {
                descriere = value;
                NotifyPropertyChanged("Descriere");
            }
        }

        private string categorie;
        public string Categorie
        {
            get
            {
                return categorie;
            }
            set
            {
                categorie = value;
                NotifyPropertyChanged("Categorie");
            }
        }

      /*  public string imagine; //calea catre imagine
        public string Imagine
        {
            get
            {
                return imagine;
            }
            set
            {
                imagine = value;
                NotifyPropertyChanged("Imagine");
            }
        }  */

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
           if (PropertyChanged != null)
                PropertyChanged(this,
           new PropertyChangedEventArgs(propertyName));
        }

        public void afisareCuvant()
        {
            Console.WriteLine(denumire + " " + "Categoria: " + categorie);
            Console.WriteLine(descriere);
        }
    }
}
