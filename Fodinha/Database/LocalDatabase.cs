using System.Collections.Generic;
using Fodinha.Models;
using SQLite;
using Xamarin.Forms;

namespace Fodinha.Database
{
    public class LocalDatabase
    {
        private readonly SQLiteConnection connection;

        public LocalDatabase()
        {
            var dependencyService = DependencyService.Get<IDatabasePath>();
            string path = dependencyService.GetDatabasePath("database.sqlite");

            connection = new SQLiteConnection(path);
            connection.CreateTable<Player>();
        }

        public List<Player> GetPlayers()
        {
            return connection.Table<Player>().ToList();
        }

        public void AddPlayer(Player player)
        {
            connection.Insert(player);
        }

        public void AddAllPlayers(List<Player> players)
        {
            connection.InsertAll(players);
        }

        public void UpdatePlayer(Player player)
        {
            connection.Update(player);
        }

        public void UpdateAllPlayers(List<Player> players)
        {
            connection.UpdateAll(players);
        }

        public void DeleteAllPlayers()
        {
            connection.DeleteAll<Player>();
        }
    }
}
