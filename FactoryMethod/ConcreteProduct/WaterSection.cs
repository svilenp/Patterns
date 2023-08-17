using FactoryMethod.Product;
using System;

namespace FactoryMethod.ConcreteProduct
{
    public class WaterSection : ISection
    {
        public void Include()
        {
            Console.WriteLine("Mineral Water");
        }
    }
}
