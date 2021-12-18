using Autofac;
using Kennel_Anton.Entities;
using Kennel_Anton.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel_Anton
{
    class AFConfig
    {
        public static IContainer Configure()
        {
            //var builder = new ContainerBuilder();



            // Register Main Application


            var builder = new ContainerBuilder();



            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();



            // Register one by one
            builder.RegisterType<MainMenu>().As<IMainMenu>();
            builder.RegisterType<DBLists>().As<IDBLists>().SingleInstance();
            builder.RegisterType<Animal>().As<IAnimal>();
            builder.RegisterType<Client>().As<IClient>();
            builder.RegisterType<MockData>().As<IMockData>();
            builder.RegisterType<AnimalManager>().As<IAnimalManager>();
            builder.RegisterType<ClientManager>().As<IClientManager>();



            return builder.Build();
        }
    }
}
