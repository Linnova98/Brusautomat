using System;
namespace Kodetime09._05
{
     public class Brus : IBrus
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }
        public int Id { get; set; }
        public Brus(string name, int price, int inventory, int id)
        {
            Name = name;
            Price = price;
            Inventory = inventory; 
            Id = id;
        }
        

        public void Print()
        {
            Console.WriteLine($"Knapp:{Id} - {Name} - {Price}kr - {Inventory} antall igjen i brusautomaten");
        }

    }
}