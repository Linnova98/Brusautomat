using System;

namespace Kodetime09._05
{
    public class Coin
    {
        public static int CoinBalance { get; set; }

        public Coin(int coinBalance)
        {
            CoinBalance = coinBalance;
        }

        public static void CoinInput()
        {
            Console.WriteLine("Legg på mynter:");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input != 1 && input != 5 && input != 10 && input != 20)
                {Console.WriteLine("Du kan kun legge på mynter for 1kr, 5kr, 10kr og 20kr");}
            else
            {
                CoinBalance += input;
                Console.WriteLine("Du har lagt på " + CoinBalance + " kroner");
            }
        }

        public static void ReturnCoinValues()
        {
            double tilbake = Convert.ToDouble(CoinBalance);
            int tjueKrone = 20;
            int tiKrone = 10;
            int femKrone = 5;

            double tjueKroner = Math.Floor(tilbake / tjueKrone);
            double reaminder = tilbake % tjueKrone;

            double tiKroner = Math.Floor(reaminder / tiKrone);
            reaminder = reaminder % tiKrone;

            double femKroner = Math.Floor(reaminder / femKrone);
            reaminder = reaminder % femKrone;

            if (tjueKroner > 0)
            {
                Console.WriteLine($"Du får tilbake {tjueKroner} tjue kronerstykker");
            }

            if (tiKroner > 0)
            {
                Console.WriteLine($"Du får tilbake {tiKroner} ti kronestykker");
            }

            if (femKroner > 0)
            {
               Console.WriteLine($"Du får tilbake {femKroner} fem kronestykker"); 
            }

            if (reaminder > 0)
            {
                Console.WriteLine($"Du får tilbake {reaminder} en kronestykker");
            }
            


        }

        public static void ReturnBalance()
        {
            if (CoinBalance <= 0)
            {
                Console.WriteLine($"Det er {CoinBalance}kr igjen. Du kan ikke ta ut penger.");
            }
            else
            {
                Console.WriteLine($"Du får nå tilbake: {CoinBalance}kr");
                ReturnCoinValues();
                CoinBalance = 0;
            }
        }
    }
}