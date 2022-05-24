using System;
using static Kodetime09._05.Coin;

namespace Kodetime09._05
{
    public class Display
    {
        public Display()
        {
            var automat = new BrusAutomat();

            automat.AddBrus("Fanta", 19, 5, 0);
            automat.AddBrus("Fanta Exotic", 20, 3, 1);
            automat.AddBrus("Fanta Sukkerfri", 18, 5, 2);
            automat.AddBrus("Cola", 23, 5, 3);
            automat.AddBrus("Cola Zero", 17, 2,4);
            automat.AddBrus("Urge", 23, 5, 5);
            automat.AddBrus("Julebrus", 23, 5, 6);

            var Coin = new Coin(0);
            
            bool run = true;
            while (run) 
            {
                PrintChoices();
                var userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("sette inn penger");
                       bool mer = true;
                        while (mer)
                        {
                            Console.WriteLine("Vil du sette inn penger sett inn '+' hvis ikke trykke enter");
                            string merPenger = Console.ReadLine();
                            if(merPenger == "+")
                                { 
                                    Coin.CoinBalance = automat.Saldo;
                                Console.WriteLine("Legg på mynter:");
                                int input = Convert.ToInt32(Console.ReadLine());
                                Coin.CoinInput(input);
                                automat.Saldo = Coin.CoinBalance;
                                Console.WriteLine($"Dette er hvor mye du har: {automat.Saldo}kr");
                                }
                            else
                            {
                                mer = false;
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Velg hvilken brus du vil kjøpe: \n");
                        automat.PrintAll();
                        automat.KjopBrusPrompt();

                        break;
                    case "3":
                        Console.WriteLine("Se saldo");
                        Console.WriteLine(automat.Saldo + "kr");
                        break;
                    case "4":
                        Console.WriteLine("Ta ut penger");
                        Coin.CoinBalance = automat.Saldo;
                        Coin.ReturnBalance();
                        automat.Saldo = Coin.CoinBalance;
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

            void PrintChoices()
            {
                Console.WriteLine("Valgmeny: ");
                Console.WriteLine("1: Sett inn penger");
                Console.WriteLine("2: Kjøp brus");
                Console.WriteLine("3: Se saldo");
                Console.WriteLine("4: Ta ut penger");
                Console.WriteLine("5: Exit");
            }

            /*int valgtBrus()
            {
                var valgteBrus = Console.ReadLine();
                var BrusListe = automat.BrusListe;
                foreach (var brus in BrusListe)
                {
                    if (valgteBrus == brus.Name)
                    {
                        var brusId = brus.Id;
                    }
                }

                return.
            }*/
        }

        
    }
}