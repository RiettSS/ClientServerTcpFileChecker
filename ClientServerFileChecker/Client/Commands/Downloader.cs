using Server.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Commands
{
    [Serializable]
    public class Downloader : ICommand
    {
        public string Path;
        public IResponse Perform()
        {
            var response = new DownloaderResponse();
            response.bytes = new byte[1];
            response.bytes[0] = 12;

            return response;
        }
    }
}
