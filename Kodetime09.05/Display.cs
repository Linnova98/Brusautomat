using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kodetime09._05.Wallet;

namespace Kodetime09._05
{
    public class Display
    {
        public Display()
        {
            var machine = new VendingMachine();
            // Add all soda here
            machine.AddSoda("Fanta", 23, 5);
            machine.AddSoda("Cola", 25, 3);
            machine.AddSoda("Cola Zero", 28, 8);
            machine.AddSoda("Fanta Exotic", 26, 2);
            machine.AddSoda("Urge", 30, 1);
            // Continue
            bool run = true;
            while (run) 
            {
                printChoices();
                var userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("sette inn penger");
                           //CoinInput();
                        Console.WriteLine("Dette er hvor mye du har: " + WalletBalance);
                        machine.Balance = WalletBalance;
                        //sette inn penger
                        break;
                    case "2":
                        //kjøp brus
                        Console.WriteLine("Velg hvilken brus du vil kjøpe: \n");
                        //Brus.PrintBrus();
                        machine.PrintAll();
                        machine.BuySodaPrompt();
                        WalletBalance = machine.Balance;
                        //kan ikke velge brus og kjøpe den enda
                       
                        break;
                    case "3":
                        Console.WriteLine("Se saldo");
                        Console.WriteLine(WalletBalance);
                        //se saldo
                        break;
                    case "4":
                        Console.WriteLine("Ta ut penger");
                        //ReturnCoins();
                        //ta ut penger
                        break;
                    case "5":
                        Console.WriteLine("EXIT");
                        run = false;
                        break;

                }
            }

            void printChoices()
            {
                Console.WriteLine("1: Sett inn penger");
                Console.WriteLine("2: Kjøp brus");
                Console.WriteLine("3: Se saldo");
                Console.WriteLine("4: Ta ut penger");
                Console.WriteLine("5: Exit");
            }
        }

        
    }
}
