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

        public Wallet(int walletBalance)
        {
            WalletBalance = walletBalance;
        }


        
       /* public static void ShowWallet()  flytter denne til brusmaskinen i seg selv
        {
            Console.Write($"Du har {WalletBalance} kr på saldo.");
        }

        public static void Pay(int Price)   flytter denne til brusmaskinen i seg selv
        {
            WalletBalance =- Price;
            Console.WriteLine("Du har betalt");
        }*/
    }
}
