using System;
using CardanoSharp.Wallet;
using CardanoSharp.Wallet.Enums;
using CardanoSharp.Wallet.Models.Keys;
using SQLite;
namespace BikeBlock.models
{
    public class Wallet
    {
        [Ignore]
        public Mnemonic Mnemonic { get; set; }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public String Name { get; set; }

        [Ignore]
        public String Password { get; set; }

        public String SecureKeyBlob { get; set; }

        [Ignore]
        public PrivateKey MasterKey { get; set; }

        public Wallet()
        {
        }

        
    }
}
