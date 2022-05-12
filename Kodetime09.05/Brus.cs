using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Kodetime09._05
{
     public class Brus : BrusMaskin
    {
        public static List<Brus> BrusList { get; set; }
        public Brus(string name, int price, int inventory, int id)
        {
            Name = name;
            Price = price;
            Inventory = inventory; 
            Id = id;

            BrusList = new List<Brus>()
            {
                new Brus("Fanta", 23, 5, 0),
                new Brus("Cola", 25, 3, 1),
                new Brus("Cola Zero", 28, 8, 2),
                new Brus("Fanta Exotic", 26, 2, 3),
                new Brus("Urge", 30, 1, 4),
            };
        
            //adde ny brus:
            BrusList.Add(new Brus("Julebrus Hamar", 15, 500, 5));
        }
        public static void PrintBrus()
        {
            foreach (var brus in BrusList)
            {
                Console.WriteLine("En " + brus.Name + " med id: " + brus.Id +  " koster " + brus.Price + " kr. Og det er " + brus.Inventory + " igjen i maskinen.\n");
            }
            Console.WriteLine("\n");
        }
   
        public static void VelgBrus()
        {
            Console.WriteLine($"Velg hvilken brus du vil ha: ");
            var valgtBrus = Console.ReadLine().ToLower();
            Console.WriteLine($"Du har valgt: {valgtBrus}");
            switch (valgtBrus)
            {
                case "cola":
                    //if() valgtBrus == brusId.Name 
                    
                    break;

                case "fanta":
                    break;
                case "urge":
                    break;
                case "julebrus":
                    break;
                default:
                    break;
            }
        }

    }
}