using System;

namespace Kodetime09._05
{
    public class Soda : ISoda
    {
        public string Name { get; }
        public int Price { get; }
        public int Inventory { get; set; }

        public Soda(string name, int price, int inventory)
        {
            Name = name;
            Price = price;
            Inventory = inventory;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} - {Price}NOK - {Inventory} available");
        }
    }
}