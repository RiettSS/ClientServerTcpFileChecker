using Server.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        //public static bool Working = true;
        public static Socket Listener;

        public static void Start(string ipAddress, string port)
        {
            string ip = ipAddress;
            int pport;
            int.TryParse(port, out pport);
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), pport);
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpSocket.Bind(tcpEndPoint);
            tcpSocket.Listen(5);
            while (true)
            {
                
                var listener = tcpSocket.Accept();
                Listener = listener;
                byte[] data = new byte[5000];

                try
                {
                    listener.Receive(data);

                }
                catch (Exception e)
                {
                    ConsoleOut.WriteLine("dataReceiving:");
                    ConsoleOut.WriteLine(e.Message);
                }
                
                var dataStructure = Converter<Data>.ToData(data);

                try
                {
                    CommandProcessor.Process(listener, dataStructure);
                }
                catch(Exception e)
                {
                    ConsoleOut.WriteLine(e.Message);
                }

                listener.Shutdown(SocketShutdown.Both);
                listener.Close();
            }
        }
    }
}
