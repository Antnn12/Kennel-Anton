using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel_Anton.Entities
{
    class ClientList : IClientList
    {
        public List<IClient> ListOfClients { get; set; }
    }
}
