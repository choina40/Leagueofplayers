using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using League_of_players.Views;

namespace League_of_players.ViewModels
{

    
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public LoginViewModel()
        {
          
        }
        private string loginusernameEntry;
        public string LoginusernameEntry
        {
            get { return loginusernameEntry; }
            set
            {
                loginusernameEntry = value;
                PropertyChanged(this, new PropertyChangedEventArgs("LoginusernameEntry"));
            }
        }
        
        public Command LoginCommand
        {
            get
            {
                return new Command(Login);
            }
        }
        private void Login()
        {
            if (LoginusernameEntry == "user1")
            {
                App.username = "Dragonslayer32";

                App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
            else if (LoginusernameEntry == "user2")
            {
                App.username = "Nagune";

                App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Wrong username", "Please enter user1 or user2", "OK");
            }

        }
    }
}
