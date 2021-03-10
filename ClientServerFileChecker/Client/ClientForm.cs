using Server;
using Server.Commands;
using Server.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            ipInputField.ReadOnly = true;
            portInputField.ReadOnly = true;
            int.TryParse(portInputField.Text, out var port);
            var socket = Client.Connect(ipInputField.Text, port);
            var command = new MessagePrinter();
            var data = new Data();
            data.Command = command;
            var receivedData = Client.Send(socket, data);
            var a = (MessagePrinterResponse)receivedData.Response;
            ipInputField.Text = a.responseMessage;
        }
    }
}
