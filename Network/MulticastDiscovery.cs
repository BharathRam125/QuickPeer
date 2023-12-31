using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace QuickPeer.Network
{
    internal class MulticastDiscovery
    {
        private const int MulticastPort = 52100;
        private const string MulticastAddress = "224.0.0.125";
        private static List<string> _nearbyDevices = [];

         public static List<string> NearbyDevices()
        {
            _nearbyDevices.Add("Test 1");
            _nearbyDevices.Add("Test 2");

            return _nearbyDevices;
        }

    }
}
