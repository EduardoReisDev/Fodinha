using SQLite;

namespace Fodinha.Models
{
    [Table("Player")]
    public class Player
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Health { get; set; }
        public int Bet { get; set; }
        public string Name { get; set; }
    }
}
