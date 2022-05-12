using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodetime09._05
{
    public class Wallet
    {
        public static int WalletBalance { get; set; }

        public  Wallet(int walletBalance)
        {
            WalletBalance = walletBalance;
        }

        public static void ReturnCoins()
        {
            Console.WriteLine($"Du får tilbake {WalletBalance}");
            WalletBalance = 0;
        }

        public static void ShowWallet()
        {
            Console.Write($"Du har {WalletBalance} kr på saldo.");
        }

        public static void Pay(int Price)
        {
            WalletBalance =- Price;
            Console.WriteLine("Du har betalt");
        }

        public static void CoinInput()
        {
            Console.WriteLine("Legg på mynter:");
            int input = Convert.ToInt32(Console.ReadLine());
            WalletBalance += input;
        }
    }
}
