using Server.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Commands
{
    [Serializable]
    public class MessagePrinter : ICommand
    {
        public string messageToPrint;
        public IResponse Perform()
        {
            var response = new MessagePrinterResponse();
            response.responseMessage = "Success";
            return response;
        }
    }
}
