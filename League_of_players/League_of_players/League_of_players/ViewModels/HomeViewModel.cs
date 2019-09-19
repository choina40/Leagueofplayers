using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace League_of_players.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        public ICommand GoCommand { set; get; }

        public HomeViewModel()
        {
            Title = "New";
            GoCommand = new Command(go);
            
        }

        private void go()
        {
            //NavigationService.NavigateToAsync<AboutViewModel>();
        }
        
    }
}