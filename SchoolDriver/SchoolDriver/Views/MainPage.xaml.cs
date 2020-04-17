using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SchoolDriver.Class;
using Xamarin.Forms.GoogleMaps;

namespace SchoolDriver
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public GeoLocation _GeoLocation = new GeoLocation();
        public MainPage()
        {
            InitializeComponent();
            configMap();
            moveToActualPosition();
        }

        void configMap()
        {
            mapa.UiSettings.CompassEnabled = true;
            mapa.UiSettings.MyLocationButtonEnabled = true;
            mapa.UiSettings.MapToolbarEnabled = true;
            mapa.MyLocationEnabled = true;
            mapa.FlowDirection = FlowDirection.LeftToRight;
            mapa.MapType = MapType.Street;
        }

        void moveToActualPosition()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await _GeoLocation.getLocationGPS();
                Position _position = new Position(GeoLocation.lat, GeoLocation.lng);
                mapa.MoveToRegion(MapSpan.FromCenterAndRadius(_position, Distance.FromMeters(500)), true);
            });
        }
    }
}
