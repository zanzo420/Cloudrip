using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatsonTcp;

namespace Cloudrip
{
    class TcpClient
    {
        public WatsonTcpClient Client { get; private set; }

        public TcpClient()
        {
            Client = new WatsonTcpClient()
        }
    }
}
