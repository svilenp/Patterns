using Strategy.ConcreteStrategy;
using Strategy.Context;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IExportType fullStrategy = new Full();
            IExportType limitedStrategy = new Limited();
            IExportType summaryStrategy = new Summary();

            var fullOrder = new Order(fullStrategy);
            var limitedOrder = new Order(limitedStrategy);
            var orderSummary = new Order(summaryStrategy);

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
