using League_of_players.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace League_of_players
{
    interface ITeamService
    {
        IEnumerable<Team> GetTeams();
        IEnumerable<Player> GetPlayers();
    }
    interface IPlayerService
    {

    }
}
