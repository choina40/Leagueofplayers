using System;
using Newtonsoft.Json;
namespace League_of_players.Models
{
    public class Summoner
    {
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }
        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("accountId")]
        public string AccountId { get; set; }
    }
}