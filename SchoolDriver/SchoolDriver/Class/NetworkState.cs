using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace SchoolDriver.Class
{
    public class NetworkState
    {
        public static bool isConnect = false;

        public void iHaveInternet()
        {
            NetworkAccess current = Connectivity.NetworkAccess;
            determineState(current);

            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChaged;
        }

        private void Connectivity_ConnectivityChaged(object sender, ConnectivityChangedEventArgs e)
        {
            determineState(e.NetworkAccess);
        }

        public void determineState(NetworkAccess state)
        {
            if (state == NetworkAccess.Internet)
            {
                isConnect = true;
            }
            else if (state == NetworkAccess.Local)
            {
                isConnect = true;
            }
            else if (state == NetworkAccess.ConstrainedInternet)
            {
                isConnect = false;
            }
            else
            {
                isConnect = false;
            }
        }
    }
}
