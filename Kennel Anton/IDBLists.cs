using Kennel_Anton.Entities;
using System.Collections.Generic;

namespace Kennel_Anton
{
    public interface IDBLists
    {
        List<IAnimal> Animals { get; set; }
        List<IClient> Clients { get; set; }
    }
}