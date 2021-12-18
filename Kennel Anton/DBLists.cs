using Kennel_Anton.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel_Anton
{
    public class DBLists : IDBLists
    {
        public List<IAnimal> Animals { get; set; }
        public List<IClient> Clients { get; set; }

        public DBLists()
        {
            Animals = new List<IAnimal>();
            Clients = new List<IClient>();
        }
    }
}
