namespace Kennel_Anton.Entities
{
    public interface IAnimal
    {
        string AnimalName { get; set; }
        bool GettingClawsClipped { get; set; }
        string Species { get; set; }
        string Owner { get; set; }
        bool BeingWashed { get; set; }
        bool IsAnimalDroppedOff { get; set; }
    }
}