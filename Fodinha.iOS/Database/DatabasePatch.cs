using System;
using System.IO;
using Fodinha.Database;
using Fodinha.iOS.Database;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabasePatch))]
namespace Fodinha.iOS.Database
{
    public class DatabasePatch : IDatabasePath
    {
        public string GetDatabasePath(string databaseFileName)
        {
            string folderPatch = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPatch = Path.Combine(folderPatch, "..", "Library");
            string databasePatch = Path.Combine(libraryPatch, databaseFileName);
            return databasePatch;
        }
    }
}
