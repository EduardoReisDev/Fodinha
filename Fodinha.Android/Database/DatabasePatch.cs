using System;
using System.IO;
using Fodinha.Database;
using Fodinha.Droid.Database;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabasePatch))]
namespace Fodinha.Droid.Database
{
    public class DatabasePatch : IDatabasePath
    {
        public string GetDatabasePath(string databaseFileName)
        {
            var folderPatch = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string databasePatch = Path.Combine(folderPatch, databaseFileName);
            return databasePatch;
        }
    }
}
