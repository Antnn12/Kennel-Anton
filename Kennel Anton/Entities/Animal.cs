using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel_Anton.Entities
{
    public class Animal : IAnimal
    {
        public string AnimalName { get; set; }
        public string Species { get; set; }
        public string Owner { get; set; }

        //public List<Animal> DroppedOffAnimals { get; set; }
        public bool GettingClawsClipped { get; set; }
        public bool BeingWashed { get; set; }
        public bool IsAnimalDroppedOff { get; set; }
    }
}
