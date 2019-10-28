using League_of_players.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace League_of_players.Database
{
    public class LeagueOfPlayersDB
    {
        public readonly SQLiteAsyncConnection database;

        public LeagueOfPlayersDB(string dbPath)
        {
            try
            {
                database = new SQLiteAsyncConnection(dbPath);

                //Creating Tables
                database.CreateTableAsync<Team>().Wait();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
