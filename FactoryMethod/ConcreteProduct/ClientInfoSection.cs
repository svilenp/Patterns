using FactoryMethod.Product;
using System;

namespace FactoryMethod.ConcreteProduct
{
    public class ClientInfoSection : ISection
    {
        public void Include()
        {
            Console.WriteLine("Clinet info.");
        }
    }
}
