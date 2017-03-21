using SQLite;

namespace SqlcipherIntegration.DAL
{
    public static class SqliteConnectionFactory
    {
        private const string _dbKey = "my-key";
        private static readonly string _dbPath = Xamarin.Forms.DependencyService.Get<ISqliteDbFilePathProvider>().GetDatabasePath();

        public static void InitiateOnce()
        {
           SQLiteConnection conn = CreateNew();
            try
            {
                conn.Query<int>("SELECT COUNT(*) FROM sqlite_master");
                conn.Query<int>("PRAGMA rekey='?'", _dbKey);
                                 
            }
            catch(SQLiteException)
            {

            }
            finally
            {
                conn.Close();
            }
          
        }
        // This one should be private. Kept public to test encryption
        public static SQLiteConnection CreateNew()
        {
           return new SQLiteConnection(_dbPath, true);
        }

        public static SQLiteConnection Create()
        {
            SQLiteConnection conn = CreateNew();
            conn.Query<int>("PRAGMA key='?'", _dbKey);
            return conn;               

        }
    }
}
