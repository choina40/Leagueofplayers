using League_of_players.Models;
using League_of_players.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;


namespace League_of_players.ViewModels
{
    public class FindTeamViewModel : BaseViewModel
    {
        // Objects in a list
        private ObservableCollection<Team> teams;

        public ObservableCollection<Team> Teams
        {
            get { return teams; }
            set { SetProperty(ref teams, value); }
        }

        public FindTeamViewModel()
        {
            Teams = new ObservableCollection<Team>();
            // Cloud or localdata
            //Teams = new ObservableCollection<Team>(DependencyService.Resolve<ITeamService>().GetTeams());
            Title = "Teams";
        }
    }
}