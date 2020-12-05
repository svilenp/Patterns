using FactoryMethod.Product;
using System;

namespace FactoryMethod.ConcreteProduct
{
    public class OrdersSection : ISection
    {
        public void Include()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Order {i}.");
            }
        }
    }
}
