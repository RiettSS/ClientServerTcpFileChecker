using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client;

namespace Server
{
    [Serializable]
    public struct Data
    {
        public CommandType Command;
        public string[] Arguments;
    }
}
