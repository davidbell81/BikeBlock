using System;
using CardanoSharp.Wallet;
using CardanoSharp.Wallet.Enums;
using CardanoSharp.Wallet.Models.Keys;
namespace BikeBlock.models
{
    public class Wallet
    {
        public Mnemonic Mnemonic { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public PrivateKey MasterKey { get; set; }

        public Wallet()
        {
        }

        
    }
}
