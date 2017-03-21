using System;
using System.IO;
using SqlcipherIntegration.iOS.Platform_Components;

[assembly: Xamarin.Forms.Dependency(typeof(DbFilePathProvider))]
namespace SqlcipherIntegration.iOS.Platform_Components
{
    public class DbFilePathProvider : DAL.ISqliteDbFilePathProvider
    {
        public const string dbName = "app.db3";
        public string GetDatabasePath()
        {
            string personalDirPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string dbDirPath = Path.Combine(personalDirPath, "Database");
            if (!Directory.Exists(dbDirPath))
            {
                Directory.CreateDirectory(dbDirPath);
            }
            return Path.Combine(dbDirPath, dbName);
        }
    }
}