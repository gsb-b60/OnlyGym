using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerment_MVP.NetworkCore
{
    public class NetworkServer
    {
        private TcpListener listener;
        private readonly Idatabasehandler db;
        private Action<String> log;
    }
}
