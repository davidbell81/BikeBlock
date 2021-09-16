using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using BikeBlock.Droid;

[assembly: Dependency(typeof(SQLiteDb))]

namespace BikeBlock.Droid
{
	public class SQLiteDb : ISQLiteDb
	{
		public SQLiteAsyncConnection GetConnection()
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var path = Path.Combine(documentsPath, "BikeBlock.db3");

			return new SQLiteAsyncConnection(path);
		}
	}
}

