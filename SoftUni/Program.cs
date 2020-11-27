using System;
using System.Collections.Generic;
using Adapter.Adapters;
using Adapter.Concrete;
using Adapter.Contracts;

namespace Adapter
{
    class Program
    {
        private static void Main()
        {
            var developersCollection = new List<IDeveloper>();

            IDeveloper suzi = new SeniorDevSuzi();
            developersCollection.Add(suzi);

            Console.WriteLine("First attempt to build the group:");
            DevelopersGroup(developersCollection);

            #region Add a person - Stavri
            //IPerson stavri = new Stavri();
            //stavri.Work();

            //developersCollection.Add(stavri);
            #endregion

            #region Adapt Stavri as developer
            //IDeveloper stavriAsDeveloper = new PersonAdapter(stavri);
            //developersCollection.Add(stavriAsDeveloper);

            //Console.WriteLine("Second attempt:");
            //DevelopersGroup(developersCollection);
            #endregion
        }

        private static void DevelopersGroup(List<IDeveloper> developers)
        {
            if (developers.Count < 2)
            {
                Console.WriteLine("Need more developers!");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("The Developers Group has been formed successfully " +
                              $"with { developers.Count } members!" +
                              Environment.NewLine);

            foreach (var developer in developers)
            {
                developer.Code();
                developer.Sleep();
            }
        }
    }
}
