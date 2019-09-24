using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using League_of_players.Models;

namespace League_of_players.ViewModels
{
    public class TeamViewModel : BaseViewModel
    {
        public Team Team { get; set; }
        public TeamViewModel()
        {
            Title = "Team";

            NavButtonCommand = new Command(async () => await NavigateTo(), () => !IsBusy);

        }
        public Command NavButtonCommand { get; }
        async Task NavigateTo() => await Shell.Current.GoToAsync("///team");

        string name = "ProGamers101";

      
        public string Name
        {
            get => name; //same as get { return name; }
            set
            {
                SetProperty(ref name, value); //MvvmHelpers Implementation
                OnPropertyChanged(nameof(Name));
            }
        }
        string description = "Plenty of fun for all, using the best of tackics to beat all who stand in the way. Join the team which knows best";
        public string Description
        {
            get => description; //same as get { return name; }
            set
            {
                SetProperty(ref description, value); //MvvmHelpers Implementation
                OnPropertyChanged(nameof(Description));
            }
        }

        int size = 2;
        public int Size
        {
            get => size; //same as get { return name; }
            set
            {
                SetProperty(ref size, value); //MvvmHelpers Implementation
                OnPropertyChanged(nameof(Size));
            }
        }

        string mode = "Normal";


        public string Mode
        {
            get => mode; //same as get { return name; }
            set
            {
                SetProperty(ref mode, value); //MvvmHelpers Implementation
                OnPropertyChanged(nameof(Mode));
            }
        }


    }
}
