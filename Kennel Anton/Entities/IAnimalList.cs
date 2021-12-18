using System.Collections.Generic;

namespace Kennel_Anton.Entities
{
    interface IAnimalList
    {
        List<IAnimal> ListOfAnimals { get; set; }
    }
}