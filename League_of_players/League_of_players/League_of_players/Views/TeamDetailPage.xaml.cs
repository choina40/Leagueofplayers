using League_of_players.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace League_of_players.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeamDetailPage : ContentPage
    {
        public TeamDetailPage(Team team)
        {
            InitializeComponent();

            TeamName.Text = team.Name;
            Master.Text = team.TeamMaster;
            TeamDescription.Text = team.Description;
            Mode.Text = team.Mode;
            MinTier.Text = team.MinTier;
            MaxTier.Text = team.MaxTier;
        }
    }
}