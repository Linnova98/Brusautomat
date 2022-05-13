using System.Collections.Generic;

namespace Kodetime09._05
{
    public interface IBrusAutomat
    {
        List<IBrus> BrusListe { get; }
        int Saldo { get; set; }
        void AddBrus(string name, int price, int inventory, int id);
        IBrus KjopBrus(int index);
        void KjopBrusPrompt();
        void PrintAll();
    }
}