using System;

namespace Strategy.ConcreteStrategy
{
    public class Limited : IOrderType
    {
        public void Export()
        {
            AddOrders();
        }

        private void AddOrders()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Order {i}.");
            }

            Console.WriteLine();
        }
    }
}
