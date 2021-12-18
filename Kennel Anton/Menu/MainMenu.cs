using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel_Anton.Menu
{
    public class MainMenu : IMainMenu
    {
        public IClientManager ClientManager { get; set; }
        public IAnimalManager AnimalManager { get; set; }
        public MainMenu(IClientManager clientManager, IAnimalManager animalManager)
        {
            ClientManager = clientManager;
            AnimalManager = animalManager;
        }
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("1: Registrera kund");
            Console.WriteLine("2: Registrera djur");
            Console.WriteLine("3: Se registrerade kunder");
            Console.WriteLine("4: Se registrerade djur");
            Console.WriteLine("5: Se ägare till djur");
            Console.WriteLine("6: Lämna djur");
            Console.WriteLine("7: Hämta djur");
            Console.WriteLine("8: Extra tjänster");
            Console.WriteLine("9: Se inlämnade djur och deras ägare");
        }

        public void GetInput()
        {
            var menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    ClientManager.RegisterClient();
                    Console.WriteLine("Kund registrerad. Tryck enter för att gå tillbaka.");
                    Console.ReadLine();
                    break;
                case "2":
                    AnimalManager.RegisterAnimal();
                    Console.WriteLine("Djur registrerat. Tryck enter för att gå tillbaka.");
                    Console.ReadLine();
                    break;
                case "3":
                    ClientManager.ViewRegisteredClients();
                    Console.WriteLine("Tryck enter för att gå tillbaka.");
                    Console.ReadLine();
                    break;
                case "4":
                    AnimalManager.ViewRegisteredAnimals();
                    Console.WriteLine("Tryck enter för att gå tillbaka.");
                    Console.ReadLine();
                    break;
                case "5":
                    AnimalManager.ViewOwnersOfAnimals();
                    Console.WriteLine("Tryck enter för att gå tillbaka.");
                    Console.ReadLine();
                    break;
                case "6":
                    AnimalManager.DropOffAnimal();
                    Console.WriteLine("Djur inlämnat. Tryck enter för att gå tillbaka.");
                    Console.ReadLine();
                    break;
                case "7":
                    AnimalManager.PickUpAnimal();
                    Console.WriteLine("Djur hämtat. Tryck enter för att gå tillbaka.");
                    Console.ReadLine();
                    break;
                case "8":
                    AnimalManager.ShowServices();
                    Console.ReadLine();
                    break;
                case "9":
                    AnimalManager.ViewDroppedOffAnimals();
                    Console.WriteLine("Tryck enter för att gå tillbaka.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Felaktigt val");
                    Show();
                    break;
            }
        }
    }
}
