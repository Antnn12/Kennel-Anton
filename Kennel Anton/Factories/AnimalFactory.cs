using Kennel_Anton.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel_Anton.Factories
{
    public static class AnimalFactory
    {
        public static IAnimal Create()
        {
            return new Animal();
        }
    }
}
