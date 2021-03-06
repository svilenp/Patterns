﻿using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;

namespace FactoryMethod.ConcreteCreator
{
    public class LimitedFactory : OrderType
    {
        public override void CreateExportDocument()
        {
            Sections.Add(new OrdersSection());
        }
    }
}
