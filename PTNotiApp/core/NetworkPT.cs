using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PTNotiApp.core
{
    class NetworkPT
    {
        private IPAddress _serverIP = IPAddress.Parse("127.0.0.1");
        private int _serverPort = 5000;
        private TcpClient _client;

        public StreamWriter _writer;
        public StreamReader _reader;
        public async Task ConnectToServer()
        {
            try
            {
                _client = new TcpClient();
                await _client.ConnectAsync(_serverIP, _serverPort);
                var stream=_client.GetStream();
                _writer=new StreamWriter(stream) { AutoFlush=true};
                _reader=new StreamReader(stream);

            }catch(Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
