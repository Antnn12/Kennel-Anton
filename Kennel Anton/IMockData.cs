namespace Kennel_Anton
{
    interface IMockData
    {
        IDBLists DB { get; set; }

        void GenerateAnimals();
    }
}