using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using League_of_players.Models;

namespace League_of_players.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class CreateTeamPage : ContentPage
    {
        public Item Item { get; set; }

        public CreateTeamPage()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void AddTeam(object sender, EventArgs e)
        {
            bool validate = true;
            string Message = string.Empty;

            if (Mode.SelectedIndex == -1)
            {
                validate = false;
                Message = "Mode is required\n";
            }
            if (MinimumTier.SelectedIndex == -1)
            {
                validate = false;
                Message = Message + "Minimum Tier is required\n";
            }
            if (MaximumTier.SelectedIndex == -1)
            {
                validate = false;
                Message = Message + "Maximum Tier is required\n";
            }

            if (validate)
            {
                await App.mockDataStore.AddItemAsync(new Team
                {
                    Name = Title.Text,
                    Description = Description.Text,
                    Mode = Mode.SelectedItem.ToString(),
                    Size = 1,
                    MinTier = MinimumTier.SelectedItem.ToString(),
                    MaxTier = MaximumTier.SelectedItem.ToString()
                });

                Title.Text = Description.Text = string.Empty;
                Mode.SelectedIndex = MinimumTier.SelectedIndex = MaximumTier.SelectedIndex = -1;

                await Navigation.PopAsync();            
            }
            else
            {
                await DisplayAlert("", Message, "OK");
            }
        }
    }
}