using Strategy.ConcreteStrategy;
using Strategy.Context;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullOrder = new Order(new Full());
            var limitedOrder = new Order(new Limited());
            var orderSummary = new Order(new Summary());

            DoTheExport(fullOrder, "Full Order Export");
            DoTheExport(limitedOrder, "Limited Order Export");
            DoTheExport(orderSummary, "Summary Export");
        }

        private static void DoTheExport(Order orderType, string title)
        {
            Console.WriteLine(title);

            orderType.Export();

            Console.WriteLine();
        }
    }
}
