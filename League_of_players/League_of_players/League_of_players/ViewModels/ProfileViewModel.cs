using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using League_of_players.Models;
using System.Diagnostics;

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
        //List<Summoner> Summoner = new List<Summoner>();
        public List<Summoner> Summoner = new List<Summoner> 
        {
                new Summoner {
                    ProfileIconId = 588,
                    Name= "ItzMii",
                    Puuid= "XUKu-upbHC09t45gJDHANYP9BoGpFgXmUnMlI_MUjl_OQZWpbaOLYtTtpTqN9CPQPJs6qMyl-jwKYQ",
                    SummonerLevel= 38,
                    AccountId= "N9C-mGn8A-kulknl9Aovcb56PmpXvLCh92YB6e_HNOo3d_8",
                    Id= "kgk5xlA8A5Orz3BJgi6SUfP-CGJGGTD-c9c1PXK8U5TU",
                    RevisionDate= 1542627683000 }
        };


        public async void GetSummoner()
        {
            var client = new HttpClient();
            var fromAPI =  await client.GetAsync("https://oc1.api.riotgames.com/lol/summoner/v4/summoners/by-name/ItzMii?api_key=RGAPI-94cb6441-254e-4262-b938-d688aafee23e");
            Debug.Write(fromAPI);

            if (fromAPI.IsSuccessStatusCode)
            {

                var summoner = JsonConvert.DeserializeObject<List<Summoner>>(await fromAPI.Content.ReadAsStringAsync());
            }

        }

        // public Command NavButtonCommand { get; }
        // async Task NavigateTo() => await Shell.Current.GoToAsync("///home");

    }
}
