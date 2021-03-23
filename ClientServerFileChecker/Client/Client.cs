using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class Client
    {
        public static Socket Connect(string ip, int port)
        {
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            tcpSocket.Connect(tcpEndPoint);

            return tcpSocket;
        }

        public static void Send(this Socket tcpSocket, Data data)
        {
            var arr = Converter<Data>.ToByteArray(data);
            byte[] receivedArr = new byte[10000];
            try
            {
                tcpSocket.Send(arr);
            } catch(Exception e)
            {
                ConsoleOut.WriteLine("arraySending");
                ConsoleOut.WriteLine(e.Message);
            }
        }

        public static void CloseConnection(Socket socket)
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
