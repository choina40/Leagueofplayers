using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace League_of_players.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public ICommand GoCommand { get; set; }

        public ProfileViewModel()
        {
            Title = "Profile";
            GoCommand = new Command(go);
        }

        private void go()
        {
            //Navigate code. 
            //NavigationService.NavigateTo<NextViewModel>();
        }
    }
}
