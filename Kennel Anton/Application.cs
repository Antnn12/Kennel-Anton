using Kennel_Anton.Entities;
using Kennel_Anton.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel_Anton
{
    class Application : IApplication
    {
        public IMockData MockData { get; set; }
        public IDBLists DB { get; set; }

        public IMainMenu MainMenu { get; set; }

        public Application(IMainMenu mainMenu, IDBLists lists, IMockData mockData)
        {
            DB = lists;
            MockData = mockData;
            MainMenu = mainMenu;
        }
        public void Run()
        {
            MockData.GenerateAnimals();

            while (true)
            {
                MainMenu.Show();
                MainMenu.GetInput();
            }
        }

    }
}
