using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kodetime09._05.Trash.Wallet;

namespace Kodetime09._05
{
    public class Display
    {
        public Display()
        {
            var automat = new BrusAutomat();

            automat.AddBrus("Fanta", 23, 5, 0);
            automat.AddBrus("Cola", 23, 5, 1);
            automat.AddBrus("Urge", 23, 5, 2);
            automat.AddBrus("Julebrus", 23, 5, 3);

            // Console.WriteLine("Dette er saldo: "+automat.Saldo);

            bool run = true;
            while (run) 
            {

                printChoices();
                var userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("sette inn penger");
                        automat.Saldo = WalletBalance;
                        
                        CoinInput();
                        Console.WriteLine($"Dette er hvor mye du har: {automat.Saldo}");
                       
                        //sette inn penger
                        break;
                    case "2":
                        //kjøp brus
                        Console.WriteLine("Velg hvilken brus du vil kjøpe: \n");
                        //Brus.PrintBrus();
                        automat.PrintAll();
                        automat.KjopBrusPrompt();
                        WalletBalance = automat.Saldo;
                        //kan ikke velge brus og kjøpe den enda
                       
                        break;
                    case "3":
                        Console.WriteLine("Se saldo");
                        automat.Saldo = WalletBalance;
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
