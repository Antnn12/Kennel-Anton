using Kennel_Anton.Entities;
using Kennel_Anton.Factories;
using System.Linq;
using System;

namespace Kennel_Anton.Menu
{
    public class AnimalManager : IAnimalManager
    {
        public IDBLists DB { get; set; }
        public IAnimal Animal { get; set; }
        public AnimalManager(IDBLists db)
        {
            DB = db;
        }

        public void RegisterAnimal()
        {
            IAnimal animal = AnimalFactory.Create();
            Console.WriteLine("Ange djurets namn.");
            animal.AnimalName = Console.ReadLine();
            Console.WriteLine("Ange art.");
            animal.Species = Console.ReadLine();
            while(true)
            {
                Console.WriteLine("Ange ägare.");
                animal.Owner = Console.ReadLine();
                bool clientExists = DB.Clients.Any(item => item.Name == animal.Owner);
                if (clientExists == true)
                {
                    DB.Animals.Add(animal);
                    return;
                }
                else
                {
                    Console.WriteLine("Kund finns ej registrerad hos oss. Försök igen.");
                }
            }



        }

        public void ViewRegisteredAnimals()
        {
            foreach (var animal in DB.Animals)
            {
                Console.WriteLine("Namn: " + animal.AnimalName + " - Art: " + animal.Species);
            }
        }

        public void ViewOwnersOfAnimals()
        {
            foreach (var animal in DB.Animals)
            {
                Console.WriteLine("Namn: " + animal.AnimalName + " - Ägare: " + animal.Owner);
            }
        }

        public void DropOffAnimal()
        {
            while (true)
            {
                Console.WriteLine("Vilket djur vill du lämna in?");
                //var animal = DB.Animals;
                string animalName = Console.ReadLine();
                bool animalExists = DB.Animals.Any(item => item.AnimalName == animalName);
                if (animalExists == true)
                {
                    foreach (var animal in DB.Animals.Where(i => i.AnimalName == animalName))
                    {
                        animal.IsAnimalDroppedOff = true;
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Djur finns ej registrerat hos oss. Försök igen.");
                }
            }

        }

        public void PickUpAnimal()
        {
            while (true)
            {
                Console.WriteLine("Vilket djur vill du hämta?");
                //var animal = DB.Animals;
                string animalName = Console.ReadLine();
                bool animalExists = DB.Animals.Any(item => item.AnimalName == animalName);
                bool animalIsDroppedOff = DB.Animals.Any(item => item.IsAnimalDroppedOff == true);
                if (animalExists == true && animalIsDroppedOff == true)
                {
                    foreach (var animal in DB.Animals.Where(i => i.AnimalName == animalName))
                    {
                        int totalCost = 100;
                        Console.WriteLine("Kostnad för besöket - 100kr");
                        if (animal.GettingClawsClipped == true)
                        {
                            totalCost += 50;
                            Console.WriteLine("Kostnad för kloklippning - 50kr");
                        }
                        if (animal.BeingWashed == true)
                        {
                            totalCost += 100;
                            Console.WriteLine("Kostnad för tvätt - 100kr");
                        }
                        Console.WriteLine("Din totala kostnad är " + totalCost);
                        animal.IsAnimalDroppedOff = false;
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Djur finns ej hos oss. Försök igen.");
                }
            }

        }

        public void ShowServices()
        {
            Console.WriteLine("1. Kloklippning - 50kr");
            Console.WriteLine("2. Tvätt - 100kr");
            Console.WriteLine("3. Gå tillbaka");
            switch (Console.ReadLine())
            {
                case "1":
                    while (true)
                    {
                        Console.WriteLine("Vilket djur ska vi klippa klorna på?");
                        //var animal = DB.Animals;
                        string animalName = Console.ReadLine();
                        bool animalExists = DB.Animals.Any(item => item.AnimalName == animalName);
                        bool animalIsDroppedOff = DB.Animals.Any(item => item.IsAnimalDroppedOff == true);
                        if (animalExists == true)
                        {
                            foreach (var animal in DB.Animals.Where(i => i.AnimalName == animalName))
                            {
                                animal.GettingClawsClipped = true;
                                Console.WriteLine("Vi klipper " + animal.AnimalName + "s klor. Tryck enter för att gå tillbaka");
                            }
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Djur finns ej registrerat hos oss. Försök igen.");
                        }
                    }
                case "2":
                    while (true)
                    {
                        Console.WriteLine("Vilket djur ska vi tvätta?");
                        //var animal = DB.Animals;
                        string animalName = Console.ReadLine();
                        bool animalExists = DB.Animals.Any(item => item.AnimalName == animalName);
                        bool animalIsDroppedOff = DB.Animals.Any(item => item.IsAnimalDroppedOff == true);
                        if (animalExists == true)
                        {
                            foreach (var animal in DB.Animals.Where(i => i.AnimalName == animalName))
                            {
                                animal.BeingWashed = true;
                                Console.WriteLine("Vi tvättar " + animal.AnimalName + ". Tryck enter för att gå tillbaka");
                            }
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Djur finns ej registrerat hos oss. Försök igen.");
                        }
                    }
                case "3":
                    break;
                default:
                    break;
            }

        }

        public void ViewDroppedOffAnimals()
        {
            var animals = DB.Animals;
            foreach (var animal in DB.Animals.Where(i => i.IsAnimalDroppedOff == true))
            {
                Console.WriteLine("Namn: " + animal.AnimalName + " - Ägare: " + animal.Owner);
            }
        }

    }
}