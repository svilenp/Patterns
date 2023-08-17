using FactoryMethod.Product;
using System;

namespace FactoryMethod.ConcreteProduct
{
    public class TeaSection : ISection
    {
        public void Include()
        {
            Console.WriteLine("Teas collection.");
        }
    }
}
