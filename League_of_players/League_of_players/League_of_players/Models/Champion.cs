using System;
using Newtonsoft.Json;
namespace League_of_players.Models
{
    public class Champion
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("profileIconId")]
        public string ProfileIconId { get; set; }
    }
}