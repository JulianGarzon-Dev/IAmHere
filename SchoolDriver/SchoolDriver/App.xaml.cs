using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SchoolDriver.Class;

namespace SchoolDriver
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //new GeoLocation().getLocationGPS();
            new NetworkState().iHaveInternet();
            
        }

        protected override void OnStart()
        {
            MainPage = new MainPage();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
