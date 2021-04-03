using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Client;

namespace Server
{
    public static class CommandProcessor
    {
        public static void Process(Socket listener, Data data)
        {
            ConsoleOut.WriteLine("Command is processing...");

            switch (data.Command)
            {
                case CommandType.SayHello:
                    {
                        ConsoleOut.WriteLine("User connected");
                        var arr = Encoding.UTF8.GetBytes("Connected");
                        try
                        {
                            Server.Listener.Send(arr);
                        }
                        catch (Exception e)
                        {
                            ConsoleOut.WriteLine(e.Message);
                        }
                    }
                    break;
                case CommandType.GetDirectory:
                    {
                        ConsoleOut.WriteLine("Getting directory...");
                        var directories = Directory.GetDirectories(data.Arguments[0]);
                        var files = Directory.GetFiles(data.Arguments[0]);

                        var result = directories.Concat(files);

                        var builder = new StringBuilder();
                        foreach (var file in result)
                        {
                            builder.Append(file);
                            builder.Append(Environment.NewLine);
                        }

                        var response = builder.ToString();
                        //ConsoleOut.WriteLine(response);

                        var arr = Encoding.UTF8.GetBytes(response);
                        //var arr = Encoding.UTF8.GetBytes("Connected");

                        listener.Send(arr);
                    }
                    break;
                case CommandType.DownloadFile:
                    {
                        ConsoleOut.WriteLine("Sending file " + data.Arguments[0]);
                        var path = data.Arguments[0];
                        var bytes = File.ReadAllBytes(path);

                        listener.Send(bytes);
                    }
                    break;
                case CommandType.DownloadFileToServer:
                    {
                        ConsoleOut.WriteLine("Downloading file to " + data.Arguments[0]);
                        var path = data.Arguments[0];
                        var bytes = new byte[10000];
                        var size = listener.Receive(bytes);
                        var bytesFinal = new byte[size];
                        for (var i = 0; i < size; i++)
                        {
                            bytesFinal[i] = bytes[i];
                        }

                        File.WriteAllBytes(path, bytesFinal);
                    }
                    break;
                case CommandType.CheckHash:
                    {
                        var path = data.Arguments[0];
                        var hash = MD5HashComputer.ComputeMD5Checksum(path);

                        var bytes = Encoding.UTF8.GetBytes(hash);
                        listener.Send(bytes);
                    }
                    break;
            }
        }
    }
}
