using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;

namespace FactoryMethod.ConcreteCreator
{
    public class SummaryFactory : OrderType
    {
        public override void CreateExportDocument()
        {
            Sections.Add(new SummarySection());
        }
    }
}
