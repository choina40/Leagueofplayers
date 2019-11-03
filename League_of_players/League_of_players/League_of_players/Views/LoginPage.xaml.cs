using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using League_of_players.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace League_of_players.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel loginViewModel;
        public LoginPage()
        {
            loginViewModel = new LoginViewModel();
            InitializeComponent();
            BindingContext = loginViewModel;
        }
        
        private void Handle_Clicked(object sender, System.EventArgs e)
        { 
            if (LoginusernameEntry.Text == "user1") 
            {
                App.username = "Dragonslayer32";
                
                Navigation.PushAsync(new HomePage()); 
            }
            else if (LoginusernameEntry.Text == "user2")
            {
                App.username = "Nagune";
                
                Navigation.PushAsync(new SignUpPage());
            }
            else 
            {
                DisplayAlert ("Wrong username", "Please enter user1 or user2", "OK");
            }
            
        }
        void SignUp_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}