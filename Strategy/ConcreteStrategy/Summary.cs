
using System;

namespace Strategy.ConcreteStrategy
{
    public class Summary : IOrderType
    {
        public void Export()
        {
            ShowSummary();
        }

        private void ShowSummary()
        {
            Console.WriteLine("Just a summary!");
        }
    }
}
