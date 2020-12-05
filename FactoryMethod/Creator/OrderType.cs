using FactoryMethod.Product;
using System.Collections.Generic;

namespace FactoryMethod.Creator
{
    public abstract class OrderType
    {
        public List<ISection> Sections { get; set; }

        public OrderType()
        {
            Sections = new List<ISection>();

            CreateExportDocument();
        }

        // The Factory Method
        public abstract void CreateExportDocument();
    }
}
