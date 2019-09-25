using System;

namespace League_of_players.Models
{
    public class Team
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mode { get; set; }
        public int Size { get; set; }
        public string Color { get; set; } 
    }
}