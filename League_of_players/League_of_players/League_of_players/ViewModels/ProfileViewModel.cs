using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using League_of_players.Models;

namespace League_of_players.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {

        public ProfileViewModel()
        {
            Title = "Profile";

            // vNavButtonCommand = new Command(async () => await NavigateTo(), () => !IsBusy);

        }

        string name = "DragonSlayer32";

       

        public string Name
        {
            get => name; //same as get { return name; }
            set
            {
                SetProperty(ref name, value); //MvvmHelpers Implementation
                OnPropertyChanged(nameof(Name));
            }
        }
        string bio = "Bio: I am a good player who steals kills";
        public string Bio
        {
            get => bio; //same as get { return name; }
            set
            {
                SetProperty(ref bio, value); //MvvmHelpers Implementation
                OnPropertyChanged(nameof(Bio));
            }
        }
        public async void GetChampions()
        {
            var client = new HttpClient();
            var chaptions =  await client.GetAsync("URI");

            if (chaptions.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<List<Champion>>(await chaptions.Content.ReadAsStringAsync());
            }
        }
        List<Champion> champs;
        public MockChampion()
        {
            champs = new List<Champion>();
            var mockChamps = new List<Champion>
            {
                new Team { Name = "ProTeam", Description="This is an item description.", Mode="Normal", Size = 3},
                new Team { Name = "WeakTeam", Description="This is an item description.", Mode="ARAM", Size = 1}
            };

            foreach (var champ in mockChamps)
            {
                champs.Add(champ);
            }
        }
        // public Command NavButtonCommand { get; }
        // async Task NavigateTo() => await Shell.Current.GoToAsync("///home");

    }
}
