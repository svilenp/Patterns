using FactoryMethod.Product;
using System;

namespace FactoryMethod.ConcreteProduct
{
    public class TotalsSection : ISection
    {
        public void Include()
        {
            Console.WriteLine("Total: ###");
        }
    }
}
