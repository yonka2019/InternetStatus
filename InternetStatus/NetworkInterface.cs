using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace InternetStatus
{
    internal enum Connections // Working till ->>
    {
        NoLocal,
        PC,
        Router,
        Internet
    }

    internal class NetworkInterface
    {
        private const int GatewayTimeout = 2;

        internal const string Default_Host = "8.8.8.8";
        internal const int Default_Timeout = 2000;
        internal const int Default_UpdateFreq = 500;
        internal const int Default_BufferBytes = 32;

        internal static bool TryDefaultGateway(Ping ping)
        {
            PingReply reply;

            try
            {
                reply = ping.Send(DefaultGateway, GatewayTimeout);
            }
            catch
            {
                return false;
            }
            return reply.Status == IPStatus.Success;
        }
        //Default Gateway Property
        #region https://stackoverflow.com/questions/13634868/get-the-default-gateway (DefaultGateway Property)
        //internal static IPAddress DefaultGateway => NetworkInterface
        //        .GetAllNetworkInterfaces()
        //        .Where(n => n.OperationalStatus == OperationalStatus.Up)
        //        .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
        //        .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
        //        .Select(g => g?.Address)
        //        .FirstOrDefault(a => a != null);

        internal static string DefaultGateway => "192.168.1.1";
        #endregion


        //Local Address Property
        #region https://stackoverflow.com/questions/6803073/get-local-ip-address (LocalAddress Property)
        internal static IPAddress LocalAddress => System.Net.NetworkInformation.NetworkInterface
        .GetAllNetworkInterfaces()
        .FirstOrDefault(ni =>
            ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet
            && ni.OperationalStatus == OperationalStatus.Up
            && ni.GetIPProperties().GatewayAddresses.FirstOrDefault() != null
            && ni.GetIPProperties().UnicastAddresses.FirstOrDefault(ip => ip.Address.AddressFamily == AddressFamily.InterNetwork) != null
        )
        ?.GetIPProperties()
        .UnicastAddresses
        .FirstOrDefault(ip => ip.Address.AddressFamily == AddressFamily.InterNetwork)
        ?.Address;
        #endregion
    }
}
