using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


using SQLite;
using System;
using BikeBlock.models;

namespace BikeBlock.Persistence
{
    public class SQLiteWalletStore : IWalletStore
    {
		private SQLiteAsyncConnection _connection;

		public SQLiteWalletStore(ISQLiteDb db)
		{
			_connection = db.GetConnection();


		}
		
		
		public async Task<List<Wallet>> GetWallets()
		{
			await _connection.CreateTableAsync<Wallet>();
			return await _connection.Table<Wallet>().ToListAsync();
		}

		public async Task DeleteWallet(Wallet ticket)
		{
			await _connection.DeleteAsync(ticket);
		}

		public async Task AddWallet(Wallet ticket)
		{
			await _connection.InsertAsync(ticket);
		}

		public async Task UpdateWallet(Wallet ticket)
		{
			await _connection.UpdateAsync(ticket);
		}

		public async Task<Wallet> GetWallet(int id)
		{
			return await _connection.FindAsync<Wallet>(id);
		}
		
		
	}
}

