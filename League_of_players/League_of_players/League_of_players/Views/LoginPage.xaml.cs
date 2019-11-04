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
            if (LoginusernameEntry.Text != "")
            {
                App.username = LoginusernameEntry.Text;

                Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("Wrong username", "Please enter a username", "OK");

            }



        }
        void SignUp_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}