using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

namespace InternetStatus
{
    enum Connections // Working till ->>
    {
        PC,
        Router,
        Internet
    }
    class Internet
    {
        private const int GatewayTimeout = 2;
        internal const string Default_Host = "8.8.8.8";
        internal const int Default_Timeout = 2000;
        internal const int Default_UpdateFreq = 500;

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

        #region https://stackoverflow.com/questions/13634868/get-the-default-gateway (DefaultGateway Property)
        internal static IPAddress DefaultGateway => NetworkInterface
                .GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up)
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
                .Select(g => g?.Address)
                .FirstOrDefault(a => a != null);
        #endregion
    }
}