using System.Collections.Generic;

namespace Kodetime09._05
{
    public class BrusAutomat : IBrusAutomat

    {
        public List<IBrus> BrusListe { get; }
        public int Saldo { get; set; }

        public BrusAutomat()
        {
            BrusListe = new List<IBrus>();
        }

        public void AddBrus(string name, int price, int inventory, int id)
        {
            BrusListe.Add(new Brus(name,price,inventory, id));
        }

        public IBrus KjopBrus(int index)
        {
            //mer kommer
            var brus = BrusListe[index];
            return brus;
        }

        public void KjopBrusPrompt()
        {

            var brus = KjopBrus(index);
            if(brus is null)return;
        }

        public void PrintAll()
        {
            foreach (var brus in BrusListe)
            {
                brus.Print();
            }
        }
    }
}