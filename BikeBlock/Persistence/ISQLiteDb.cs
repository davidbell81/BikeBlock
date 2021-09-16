using SQLite;

namespace BikeBlock
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}

