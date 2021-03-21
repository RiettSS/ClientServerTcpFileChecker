
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
            var response = Converter<string>.ToData(bytes);
            ConsoleOut.WriteLine(response);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            int.TryParse(portInputField.Text, out var port);
            socket = Client.Connect(ipInputField.Text, port);
            var data = new Data();
            var command = new DirectoryGetter();
            command.Path = pathInputField.Text;
            data.Command = command;
            var responseData = Client.Send(socket, data);

            var response = (DirectoryGetterResponse)responseData.Response;

            ConsoleOut.Clear(directoryOutputField);
            try
            {
                ConsoleOut.WriteLine(response.Response);
            } 
            catch
            {
                ConsoleOut.WriteLine("Wrong path.");
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            var path = downloadInputField.Text;
            var saveTo = saveToClientInput.Text;

            var downloader = new FileDownloader();
            downloader.Path = path;
            var data = new Data();
            data.Command = downloader;
            var responseData = Client.Send(socket, data);
            var response = (FileDownloaderResponse)responseData.Response;
            ConsoleOut.WriteLine("byte array:");
            foreach(var line in response.fileByteArray)
            {
                ConsoleOut.WriteLine("byte array element:");
                ConsoleOut.WriteLine(line.ToString());
            }

            File.WriteAllBytes(saveTo, response.fileByteArray);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            var data = new Data();
            var downloader = new Downloader();
            downloader.Path = "smth";
            data.Command = downloader;
            var responseData = Client.Send(socket, data);
            var response = responseData.Response;
            var r = (DownloaderResponse)response;

            foreach (var line in r.bytes)
            {
                ConsoleOut.WriteLine("byte array element:");
                ConsoleOut.WriteLine(line.ToString());
            }

        }
    }
}
