using Kennel_Anton.Entities;
using Kennel_Anton.Factories;
using System;

namespace Kennel_Anton.Menu
{
    public class ClientManager : IClientManager
    {
        public IDBLists DB { get; set; }
        public IClient Client { get; set; }
        public ClientManager(IDBLists db)
        {
            DB = db;
        }
        public void RegisterClient()
        {
            IClient client = ClientFactory.Create();
            Console.WriteLine("Ange kundens namn.");
            client.Name = Console.ReadLine();
            DB.Clients.Add(client);
        }
        public void ViewRegisteredClients()
        {
            foreach (var client in DB.Clients)
            {
                Console.WriteLine("Namn: " + client.Name);
            }
        }
    }
}