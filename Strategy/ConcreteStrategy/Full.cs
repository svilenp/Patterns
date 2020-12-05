
using System;

namespace Strategy.ConcreteStrategy
{
    public class Full : IOrderType
    {
        public void Export()
        {
            AddOrders();
            AddClientInfo();
            AddHeaders();
            AddTotals();
        }

        private void AddOrders()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Order {i}.");
            }
        }

        private void AddClientInfo()
        {
            Console.WriteLine("Clinet info.");
        }

        private void AddHeaders()
        {
            Console.WriteLine("Headers applied");
        }

        private void AddTotals()
        {
            Console.WriteLine("Total: ###");
        }
    }
}
