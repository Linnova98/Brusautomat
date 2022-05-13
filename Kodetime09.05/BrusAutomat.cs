using System;
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
            if (index < 0 || index >= BrusListe.Count)
            {
                Console.WriteLine("Det er ikke igjen mer av den brusen");
                return null;
            }
            var brus = BrusListe[index];
            if (brus.Inventory == 0)
            {
                Console.WriteLine($"Du har ikke lagt på nok for {brus.Name}");
                return null;
            }

            if (Saldo <= brus.Price)
            {
                Console.WriteLine();
                return null;
            }

            Saldo -= brus.Price;
            brus.Inventory--;
            return brus;
        }

        public void KjopBrusPrompt()
        {
            Console.WriteLine("Index av brus:");
            //legge inn noe sånn at man skriver fant så sjekker den med fanta navnet også gir den id'n til fanta som vi legger inn en linje ned
            var index = Convert.ToInt32(Console.ReadLine()); //legge inn index = id
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