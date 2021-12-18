namespace Kennel_Anton.Menu
{
    interface IMainMenu
    {
        IAnimalManager AnimalManager { get; set; }
        IClientManager ClientManager { get; set; }

        void GetInput();
        void Show();
    }
}