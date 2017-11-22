using SQLite.Net;
namespace SQLiteSample001
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}