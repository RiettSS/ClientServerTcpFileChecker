using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses
{
    [Serializable]
    public class DownloaderResponse : IResponse
    {
        public byte[] bytes;
    }
}
