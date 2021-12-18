using Kennel_Anton.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel_Anton
{
    public class MockData : IMockData
    {
        public IDBLists DB { get; set; }
        public MockData(IDBLists dBLists)
        {
            DB = dBLists;
        }
        public void GenerateAnimals()
        {

        }
    }
}
