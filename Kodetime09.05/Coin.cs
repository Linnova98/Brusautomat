using System;

namespace Kodetime09._05
{
    public class Coin
    {
        public static int CoinInput()
        {
            Console.WriteLine("Legg på mynter:");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
    }
}


/*
 Legge inn disse her når coin blir laget
   public static void ReturnCoins()
        {
            Console.WriteLine($"Du får tilbake {WalletBalance}");
            //Legge inn mynt modulo her som i codecademy oppgaven
            WalletBalance = 0;
        }

        public static void CoinInput()
        {
            Console.WriteLine("Legg på mynter:");
            int input = Convert.ToInt32(Console.ReadLine());
            WalletBalance += input;
        }
    */