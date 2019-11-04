using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Wallet
    {
        //member variables (Has A)
        private double walletTotal = 20.00;
        public double WalletTotal;
        public double walletTransfers;

        //constructor (Spawner)
        public Wallet()
        {
            WalletTotal = walletTotal;
        }


        //member methods (Can Do)
        public void MakeWalletCalculation()
        {
            walletTransfers = WalletTotal - walletTotal;
        }
    }
}
