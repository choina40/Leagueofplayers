using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using League_of_players.Models;

namespace League_of_players.Services
{
    public class MockDataStore : IDataStore<Team>
    {
        List<Team> items;

        public MockDataStore()
        {
            items = new List<Team>();
            var mockItems = new List<Team>
            {
                new Team { Id = Guid.NewGuid().ToString(), Name = "ProTeam", Description="Not one to brag but yeah", Mode="Normal", Size = 3},
                new Team { Id = Guid.NewGuid().ToString(), Name = "WeakTeam", Description="Please carry us", Mode="ARAM", Size = 1},
                new Team { Id = Guid.NewGuid().ToString(), Name = "AveragePeeps", Description="Just button mash with us", Mode="Normal", Size = 3}
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Team item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Team item)
        {
            var oldItem = items.Where((Team arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Team arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Team> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Team>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}