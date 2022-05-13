using System;
using System.Diagnostics.CodeAnalysis;

namespace Kodetime09._05  //Funker som den skal men mangler mynt delen 
{
    public class Coin
    {
        public static int CoinBalance { get; set; }

        public Coin(int coinBalance)
        {
            //int coinBalance = 0;
            CoinBalance = coinBalance;
        }

        public static void CoinInput()
        {
            Console.WriteLine("Legg på mynter:");
            //Mangler mynt
            int input = Convert.ToInt32(Console.ReadLine());
            CoinBalance += input;
        }

        public static void ReturnBalance()
        {
            Console.WriteLine($"Du får nå tilbake: {CoinBalance}");
            CoinBalance = 0;
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
*/