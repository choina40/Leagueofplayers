using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace League_of_players.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public static class Usernumber
        {
            public static string Global1 = "User";
        }
        private async void Handle_Clicked(object sender, System.EventArgs e)
        { 
            if (loginusernameEntry.ToString() == "user1") 
            {
                Usernumber.Global1 = loginusernameEntry.ToString();
                await Navigation.PushAsync(new HomePage()); 
            }
            else if (loginusernameEntry.ToString() == "user2")
            {
                Usernumber.Global1 = loginusernameEntry.ToString();
                await Navigation.PushAsync(new SignUpPage());
            }
            else 
            {
                await DisplayAlert ("Wrong username", "Please enter user1 or user2", "OK");
            }
            
        }
        void SignUp_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}