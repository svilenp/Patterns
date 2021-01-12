using FactoryMethod.Product;
using System.Collections.Generic;

namespace FactoryMethod.Creator
{
    public abstract class ExportType
    {
        public List<ISection> Sections { get; set; }

        public ExportType()
        {
            Sections = new List<ISection>();

            CreateExportDocument();
        }

        // The Factory Method
        public abstract void CreateExportDocument();
    }
}
