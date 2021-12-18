namespace Kennel_Anton.Menu
{
    public interface IAnimalManager
    {
        void RegisterAnimal();

        void ViewRegisteredAnimals();

        void ViewOwnersOfAnimals();

        void DropOffAnimal();

        void PickUpAnimal();

        void ShowServices();

        void ViewDroppedOffAnimals();
    }
}