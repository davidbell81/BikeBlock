using System;
using BikeBlock.models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BikeBlock.Persistence
{
    public interface IWalletStore
    {
        Task<List<Wallet>> GetWallets();
        Task<Wallet> GetWallet(int id);
        Task AddWallet(Wallet wallet);
        Task UpdateWallet(Wallet wallet);
        Task DeleteWallet(Wallet Wallet);
      
    }
}
