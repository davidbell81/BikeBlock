using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using BikeBlock.iOS;

[assembly: Dependency(typeof(SQLiteDb))]

namespace BikeBlock.iOS
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

