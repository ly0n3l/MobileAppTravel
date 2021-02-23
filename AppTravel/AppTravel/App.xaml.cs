using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTravel
{
    public partial class App : Application
    {
        public string Databaselocation = string.Empty;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
        
        public App(string databaselocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            Databaselocation = databaselocation;
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
