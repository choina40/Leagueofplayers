using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace League_of_players.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        public ICommand GoCommand { get; set; }

        public HomeViewModel()
        {
            Title = "About";
            GoCommand = new Command(go);
        }
        private void go()
        {
            //Navigate code. 
            //NavigationService.NavigateTo<NextViewModel>();
            //NavigationService.NavigateToAsync<AboutViewModel>();
        }
    }
}