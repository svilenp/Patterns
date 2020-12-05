using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;

namespace FactoryMethod.ConcreteCreator
{
    public class FullFactory : OrderType
    {
        public override void CreateExportDocument()
        {
            Sections.Add(new OrdersSection());
            Sections.Add(new ClientInfoSection());
            Sections.Add(new HeaderSection());
            Sections.Add(new TotalsSection());
        }
    }
}
