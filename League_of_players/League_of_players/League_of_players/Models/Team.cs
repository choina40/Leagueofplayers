using SQLite;
using System;

namespace League_of_players.Models
{
    public class Team
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }
        public string Name { get; set; }
        public string TeamMaster { get; set; }
        public string Description { get; set; }
        public string Mode { get; set; }
        public int Size { get; set; }
        public string MinTier { get; set; }
        public string MaxTier { get; set; }
    }
}