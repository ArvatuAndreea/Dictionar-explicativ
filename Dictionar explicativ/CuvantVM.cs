using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dictionar_explicativ
{
    class CuvantVM
    {
        public ObservableCollection<Cuvant> Cuvinte { get; set; }
        public CuvantVM()
        {
            Cuvinte = new ObservableCollection<Cuvant>();
            Cuvinte.Add(new Cuvant() { Denumire = "mar", Descriere = "Fruct rosu", Categorie = "Fructe" });
            Cuvinte.Add(new Cuvant() { Denumire = "masa", Descriere = "Mobila formată dintr-o placă sprijinită pe unul sau pe mai multe picioare", Categorie = "Mobila" });
            Cuvinte.Add(new Cuvant() { Denumire = "dulap", Descriere = " Mobila de lemn sau de metal prevazuta cu rafturi", Categorie = "Mobila" });
            Cuvinte.Add(new Cuvant() { Denumire = "farfurie", Descriere = "Obiect de faianta, de portelan etc., de obicei de forma rotunda, în care se serveste mancarea", Categorie = "Mobila" });
        }
        
        public void adaugareCuvant(string cuv, string descriere, string categorie)
        {
            Cuvant cuvantNou = new Cuvant();
            cuvantNou.Denumire = cuv;
            cuvantNou.Descriere = descriere;
            cuvantNou.Categorie = categorie;
            Cuvinte.Add(cuvantNou);

        }

        public void stergereCuvant(string cuv)
        {
            Cuvant c = new Cuvant();
            for(int i=0; i<Cuvinte.Count;i++)
            {
                if (Cuvinte[i].Denumire == cuv)
                    c = Cuvinte[i];
            }
            
            Cuvinte.Remove(c);
            Console.WriteLine("Cuvant sters.");
        }
 

        public void cautareCuvant(string cuv)
        {
            int ok = 0;
            for (int i = 0; i < Cuvinte.Count; i++)
                if (Cuvinte[i].Denumire == cuv)
                {
                    Cuvinte[i].afisareCuvant();
                    ok = 1;
                }
            if (ok == 0)
                Console.WriteLine("Cuvantul nu exista in dictionar.");
        }
    }

}
