using MvvmCrossTemplate.Contracts.Services;
using Plugin.Connectivity;

namespace MvvmCrossTemplate.Services.General
{
    public class ConnectionService : IConnectionService
    {
        public bool CheckOnline()
        {
            return CrossConnectivity.Current.IsConnected;
        }
    }
}
