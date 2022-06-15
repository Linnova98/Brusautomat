using System;
using System.Collections.Generic;

namespace Kodetime09._05 //mangler bare en ekstra del av oppgaven for nå kan man kun kjøpe med index
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
           
            if (index < 0 || index >= BrusListe.Count)
            {
                Console.WriteLine("Brusen finnes ikke");
                return null;
            }
            var brus = BrusListe[index];
            if (brus.Inventory == 0)
            {
                Console.WriteLine($"Det er ikke mer igjen av {brus.Name}");
                return null;
            }

            if (Saldo < brus.Price)
            {
                Console.WriteLine($"Du har ikke lagt på nok for {brus.Name}, den koster {brus.Price}kr");
                return null;
            }

            Saldo -= brus.Price;
            brus.Inventory--;
            return brus;
        }

        
        public void KjopBrusPrompt()
        {
            Console.WriteLine("Index av brus:");
            var index = Convert.ToInt32(Console.ReadLine());
            var brus = KjopBrus(index);
            if(brus is null)return;
            Console.WriteLine($"Du kjøpte {brus.Name}");
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