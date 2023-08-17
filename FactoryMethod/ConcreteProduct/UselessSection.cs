using FactoryMethod.Product;
using System;

namespace FactoryMethod.ConcreteProduct
{
    public class UselessSection : ISection
    {
        public void Include()
        {
            Console.WriteLine("Something useless here!");
        }
    }
}
