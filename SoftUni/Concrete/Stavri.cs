using System;
using Adapter.Contracts;

namespace Adapter.Concrete
{
    public class Stavri : IPerson
    {
        public void Work()
        {
            Console.WriteLine($"{ nameof(Stavri) } : I do some stuff to get payed...");
        }

        public void Sleep()
        {
            Console.WriteLine($"{ nameof(Stavri) } : I sleep 10 hours a day.");
        }
    }
}
