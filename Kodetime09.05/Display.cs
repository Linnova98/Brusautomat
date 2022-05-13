using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kodetime09._05.Coin;

namespace Kodetime09._05
{
    public class Display
    {
        public Display()
        {
            var automat = new BrusAutomat();
            var pengesaldo = automat.Saldo;

            automat.AddBrus("Fanta", 23, 5, 0);
            automat.AddBrus("Cola", 23, 5, 1);
            automat.AddBrus("Urge", 23, 5, 2);
            automat.AddBrus("Julebrus", 23, 5, 3);
            
            bool run = true;
            while (run) 
            {
                printChoices();
                var userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("sette inn penger");
                        CoinInput();
                        automat.Saldo = CoinBalance;
                        CoinBalance = automat.Saldo;
                        Console.WriteLine($"Dette er hvor mye du har: {automat.Saldo}");
                        
                        break;
                    case "2":
                        Console.WriteLine("Velg hvilken brus du vil kjøpe: \n"); 
                        automat.PrintAll();
                        automat.KjopBrusPrompt();
                        
                        break;
                    case "3":
                        Console.WriteLine("Se saldo");
                        Console.WriteLine(automat.Saldo);
                        
                        break;
                    case "4":
                        Console.WriteLine("Ta ut penger");
                        CoinBalance = automat.Saldo;
                        ReturnBalance();
                        automat.Saldo = CoinBalance;
                        
                        break;
                    case "5":
                        Console.WriteLine("EXIT");
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;

                }
            }

            void printChoices()
            {
                Console.WriteLine("Valgmeny: ");
                Console.WriteLine("1: Sett inn penger");
                Console.WriteLine("2: Kjøp brus");
                Console.WriteLine("3: Se saldo");
                Console.WriteLine("4: Ta ut penger");
                Console.WriteLine("5: Exit");
            }
        }

        
    }
}
