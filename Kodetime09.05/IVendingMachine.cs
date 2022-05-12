using System.Collections.Generic;

namespace Kodetime09._05
{
    public interface IVendingMachine
    {
        List<ISoda> SodaList { get; }
        int Balance { get; set; }
        void AddSoda(string name, int price, int inventory);
        ISoda BuySoda(int index);
        void BuySodaPrompt();
        void PrintAll();
    }
}