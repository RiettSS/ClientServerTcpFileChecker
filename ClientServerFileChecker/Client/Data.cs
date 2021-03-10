using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [Serializable]
    public struct Data
    {
        public ICommand Command;
        public IResponse Response;
    }
}
