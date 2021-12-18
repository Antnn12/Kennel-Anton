using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel_Anton.Entities
{
    class AnimalList : IAnimalList
    {
        public List<IAnimal> ListOfAnimals { get; set; }
    }
}
