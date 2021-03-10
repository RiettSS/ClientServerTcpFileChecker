using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public static class ConsoleOut
    {
        public static void WriteLine(TextBox serverConsole, string text)
        {
            string temp = serverConsole.Text;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(temp);
            strBuilder.Append(text);
            strBuilder.Append(Environment.NewLine);
            serverConsole.Text = strBuilder.ToString();
        }

        public static void WriteLine(TextBox serverConsole)
        {
            string temp = serverConsole.Text;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(temp);
            strBuilder.Append(Environment.NewLine);
            serverConsole.Text = strBuilder.ToString();
        }

        public static void Write(TextBox serverConsole, string text)
        {
            string temp = serverConsole.Text;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(temp);
            strBuilder.Append(text);
            serverConsole.Text = strBuilder.ToString();
        }
    }
}
