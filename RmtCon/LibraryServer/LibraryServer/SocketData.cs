using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace TCPprotocol
{
    class SocketData
    {
        public const int BufferSize = 1024;
        public Socket ClientConnection { get; set; }

        byte[] buffer = new byte[BufferSize];

        public byte[] Buffer
        {
            get { return buffer; }
            set { buffer = value; }
        }
    }
}
