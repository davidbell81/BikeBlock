using System;
using System.Collections.Generic;
using CardanoSharp.Wallet;
using CardanoSharp.Wallet.Enums;
using CardanoSharp.Wallet.Models.Keys;
using SQLite;
namespace BikeBlock.models
{
    public class Wallet
    {
        

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public String Name { get; set; }

        public String SecureKeyBlob { get; set; }

        [Ignore]
        public String Password { get; set; }

        [Ignore]
        public Mnemonic Mnemonic { get; set; }

        [Ignore]
        public PrivateKey MasterKey { get; set; }

        [Ignore]
        public Dictionary<String, int> Contents { get; set; }

        public Wallet()
        {
        }

        


        
    }
}
