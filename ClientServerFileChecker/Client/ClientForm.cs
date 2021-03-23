
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
            
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
