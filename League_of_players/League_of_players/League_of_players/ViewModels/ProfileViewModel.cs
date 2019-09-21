using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace League_of_players.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {

        public ProfileViewModel()
        {
            Title = "Profile";

            NavButtonCommand = new Command(async () => await NavigateTo(), () => !IsBusy);

        }
        public Command NavButtonCommand { get; }
        async Task NavigateTo() => await Shell.Current.GoToAsync("///home");

    }
}
