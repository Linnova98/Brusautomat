using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodetime09._05.Trash
{
    public class Wallet
    {
        public static int WalletBalance { get; set; }

        public Wallet(int walletBalance)
        {
            WalletBalance = walletBalance;
        }
        //husk å fjern ligger i coin.cs
        public static void CoinInput()
        {
            Console.WriteLine("Legg på mynter:");
            int input = Convert.ToInt32(Console.ReadLine());
            WalletBalance += input;
        }

    }
}
