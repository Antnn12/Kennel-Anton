using System.Collections.Generic;

namespace Kennel_Anton.Entities
{
    interface IClientList
    {
        List<IClient> ListOfClients { get; set; }
    }
}