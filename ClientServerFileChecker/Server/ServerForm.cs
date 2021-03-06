using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForm : Form
    {
        public static TextBox serverConsole;
        public ServerForm()
        {
            InitializeComponent();

            serverConsole = ServerConsole;

            FormClosing += Exit;
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            ConsoleOut.WriteLine("Server started...");
            StartServerButton.Enabled = false;
            portInputField.ReadOnly = true;
            ipInputField.ReadOnly = true;

            var ip = ipInputField.Text;
            var port = portInputField.Text;

            Thread serverThread = new Thread(() => { Server.Start(ip, port); });
            serverThread.Start();
        }

        private void Exit(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
