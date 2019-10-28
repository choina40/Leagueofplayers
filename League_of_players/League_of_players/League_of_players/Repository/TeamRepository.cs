using League_of_players.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace League_of_players.Repository
{
    public class TeamRepository
    {
        private SQLiteAsyncConnection database;

        public TeamRepository(SQLiteAsyncConnection dbinstance)
        {
            database = dbinstance;
        }

        public Task<List<Team>> GetItemsAsync()
        {
            var Teamdb = database.Table<Team>().ToListAsync();

            return Teamdb;
        }

        public async Task<Team> GetItemAsync(long id)
        {
            var Teamdb = await database.Table<Team>().ToListAsync();

            return Teamdb.Find(i => i.Id == id);
        }


        public Task<int> DeleteItemAsync(Team item)
        {
            return database.DeleteAsync(item);
        }

        public Task<int> SaveItemAsync(Team item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public async void DeleteAllItemsAsync()
        {
            var AllItems = database.Table<Team>().ToListAsync().Result;

            foreach (var item in AllItems)
            {
                if (item != null)
                {
                    await database.DeleteAsync(item);
                }
            }

        }

    }
}
