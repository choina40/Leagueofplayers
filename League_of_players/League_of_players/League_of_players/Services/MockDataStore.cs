using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using League_of_players.Models;

namespace League_of_players.Services
{
    public class MockDataStore : IDataStore<Team>
    {
        List<Team> teams;

        public MockDataStore()
        {
            teams = new List<Team>();
            var mockItems = new List<Team>
            {
                new Team { Name = "ProTeam", Description="This is an item description.", Mode="Normal", Size = 3},
                new Team { Name = "WeakTeam", Description="This is an item description.", Mode="ARAM", Size = 1}
            };

            foreach (var team in mockItems)
            {
                teams.Add(team);
            }
        }

        public async Task<bool> AddItemAsync(Team team)
        {
            teams.Add(team);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Team team)
        {
            var oldItem = teams.Where((Team arg) => arg.Name == team.Name).FirstOrDefault();
            teams.Remove(oldItem);
            teams.Add(team);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = teams.Where((Team arg) => arg.Name == id).FirstOrDefault();
            teams.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Team> GetItemAsync(string id)
        {
            return await Task.FromResult(teams.FirstOrDefault(s => s.Name == id));
        }

        public async Task<IEnumerable<Team>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(teams);
        }
    }
}