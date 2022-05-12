using System;
using System.Collections.Generic;

namespace Kodetime09._05
{
    public class VendingMachine : IVendingMachine
    {
        public List<ISoda> SodaList { get; }
        public int Balance { get; set; }

        public VendingMachine()
        {
            SodaList = new List<ISoda>();
        }

        // Helper method for adding soda
        public void AddSoda(string name, int price, int inventory)
        {
            SodaList.Add(new Soda(name, price, inventory));
        }

        // Logic for buying soda
        public ISoda BuySoda(int index)
        {
            // Is index out of range?
            if (index < 0 || index >= SodaList.Count)
            {
                Console.WriteLine("There is no such soda");
                return null;
            }
            var soda = SodaList[index];
            // Is inventory empty?
            if (soda.Inventory == 0)
            {
                Console.WriteLine($"We are out of {soda.Name}");
                return null;
            }
            // Not enough balance?
            if (Balance < soda.Price)
            {
                Console.WriteLine($"Not enough balance for {soda.Name}");
                return null;
            }
            // Everything is fine, let's proceed
            Balance -= soda.Price;
            soda.Inventory--;
            return soda;
        }

        // Prompt for buying soda
        public void BuySodaPrompt()
        {
            // Write + ReadLine + BuySoda
            Console.Write("Index of soda: ");
            var index = Convert.ToInt32(Console.ReadLine());
            var soda = BuySoda(index);
            if (soda is not null)
            {
                Console.WriteLine($"You bought {soda.Name}");
            }
        }

        // Prints all available soda
        public void PrintAll()
        {
            foreach (var soda in SodaList)
            {
                soda.Print();
            }
        }
    }
}