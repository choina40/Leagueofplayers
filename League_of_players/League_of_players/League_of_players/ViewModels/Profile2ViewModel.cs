using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace League_of_players.ViewModels
{
    public class Profile2ViewModel : BaseViewModel
    {

        public Profile2ViewModel()
        {
            Title = "Profile";

            // vNavButtonCommand = new Command(async () => await NavigateTo(), () => !IsBusy);

        }

        string name = "Nagune";

       

        public string Name
        {
            get => name; //same as get { return name; }
            set
            {
                SetProperty(ref name, value); //MvvmHelpers Implementation
                OnPropertyChanged(nameof(Name));
            }
        }
        string bio = "Bio: I am a noisy man who talk more instead of playing hard";
        public string Bio
        {
            get => bio; //same as get { return name; }
            set
            {
                SetProperty(ref bio, value); //MvvmHelpers Implementation
                OnPropertyChanged(nameof(Bio));
            }
        }
        // public Command NavButtonCommand { get; }
        // async Task NavigateTo() => await Shell.Current.GoToAsync("///home");

    }
}
