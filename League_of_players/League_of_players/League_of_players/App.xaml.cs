using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using League_of_players.Services;
using League_of_players.Views;
using System.Collections.Generic;
using League_of_players.Models;
using System.Linq;
using League_of_players.Database;
using League_of_players.Repository;

namespace League_of_players
{
    public partial class App : Application
    {
        public static string AzureBackendUrl =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static bool UseMockDataStore = true;

        public static MockDataStore mockDataStore { get; set; }

        public static LeagueOfPlayersDB Database { get; private set; }


        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();
            MainPage = new AppShell();

            mockDataStore = new MockDataStore();

            Database = new LeagueOfPlayersDB(DependencyService.Get<IHelper>()
                .GetLocalFilePath("LPSQLite.db3"));

            //var rep = new TeamRepository(Database.database);
            //rep.DeleteAllItemsAsync();
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
