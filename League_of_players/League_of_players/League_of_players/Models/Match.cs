using System;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace League_of_players.Models
{
    public class Champion
    {
        [JsonProperty("matches")]
        public List<string> Matches { get; set; }
        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }
        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }
        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }
    }
}