using System;
using System.Collections.Generic;
using System.Text;
using League_of_players.Models;

namespace League_of_players.Services
{
    public class LocalDatabaseTeamService : ITeamService
    {
        List<Team> team;

        public IEnumerable<Player> GetPlayers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Team> GetTeams()
        {
            //return db.getTeams();
            return team;
        }
    }
}
