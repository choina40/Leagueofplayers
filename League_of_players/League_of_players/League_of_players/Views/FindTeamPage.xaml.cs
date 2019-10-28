using League_of_players.Models;
using League_of_players.Repository;
using League_of_players.ViewModels;
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
    public partial class FindTeamPage : ContentPage
    {
        private TeamRepository teamRepository { get; set; }

        public List<Team> Teams { get; set; }

        public FindTeamPage()
        {
            InitializeComponent();
            teamRepository = new TeamRepository(App.Database.database);

            FindTeamPageInit();
        }

        private async void FindTeamPageInit()
        {
            //var items = await App.mockDataStore.GetItemsAsync();

            var items = await teamRepository.GetItemsAsync();
            Teams = items.ToList();
            BindingContext = this;
        }

        private void OnTeamSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedTeam = (Team)TeamList.SelectedItem;
            Navigation.PushAsync(new TeamDetailPage(selectedTeam));
        }
    }
}