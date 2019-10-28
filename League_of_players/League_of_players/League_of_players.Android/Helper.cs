using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using League_of_players.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(Helper))]
namespace League_of_players.Droid
{
    public class Helper : IHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);

        }

    }
}