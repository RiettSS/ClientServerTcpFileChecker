
using Server;
using Server.Commands;
using Server.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        public static TextBox dirOut;

        Socket socket;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            dirOut = directoryOutputField;

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            ipInputField.ReadOnly = true;
            portInputField.ReadOnly = true;
            int.TryParse(portInputField.Text, out var port);
            socket = Client.Connect(ipInputField.Text, port);
            var data = new Data();
            data.Command = CommandType.SayHello;
            Client.Send(socket, data);
            byte[] bytes = new byte[10000];
            socket.Receive(bytes);
            var response = Encoding.UTF8.GetString(bytes);
            ConsoleOut.WriteLine(response);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var path = pathInputField.Text.Trim();
            var data = new Data();
            data.Command = CommandType.GetDirectory;
            data.Arguments = new string[1];
            data.Arguments[0] = path;
            int.TryParse(portInputField.Text, out var port);
            socket = Client.Connect(ipInputField.Text, port);
            Client.Send(socket, data);
            var bytes = socket.AcceptBytes();
            var response = Encoding.UTF8.GetString(bytes);
            ConsoleOut.Clear(dirOut);
            ConsoleOut.WriteLine(response);
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            var path = downloadInputField.Text;
            var pathTo = saveToClientInput.Text;
            var data = new Data();
            var args = new string[2];
            args[0] = path;
            args[1] = pathTo;
            data.Command = CommandType.DownloadFile;
            data.Arguments = args;
            InitializeSocket();
            Client.Send(socket, data);
            var bytes = socket.AcceptBytes();
            File.WriteAllBytes(pathTo, bytes);
        }

        private void button1_Click(object sender, EventArgs e) //Кнопка загрузки с клиента на сервер
        {
            var clientPath = downloadFromClient.Text;
            var serverPath = saveToServerInput.Text;

            var bytes = File.ReadAllBytes(clientPath);

            var data = new Data();
            data.Command = CommandType.DownloadFileToServer;
            var args = new string[1];
            args[0] = serverPath;
            data.Arguments = args;

            InitializeSocket();
            Client.Send(socket, data);
            //Thread.Sleep(2000);
            socket.Send(bytes);
        }

        private void testButton_Click(object sender, EventArgs e)
        {


        }

        private void InitializeSocket()
        {
            int.TryParse(portInputField.Text, out var port);
            socket = Client.Connect(ipInputField.Text, port);
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            var clientPath = md5Client.Text;
            var serverPath = md5Server.Text;

            var data = new Data();
            data.Command = CommandType.CheckHash;
            data.Arguments = new string[1] { serverPath };

            InitializeSocket();

            socket.Send(data);
            var bytes = socket.ReceiveBytes();

            var clientHash = MD5HashComputer.ComputeMD5Checksum(clientPath);

            var serverHash = Encoding.UTF8.GetString(bytes);

            if(clientHash == serverHash)
            {
                ConsoleOut.WriteLine("Files are equal");
            } 
            else
            {
                ConsoleOut.WriteLine("Files aren't equal");
            }
            
        }
    }
}
