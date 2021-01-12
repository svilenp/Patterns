namespace Strategy.Context
{
    public class Order
    {
        private readonly IExportType _exportType;

        public Order(IExportType exportType)
        {
            _exportType = exportType;
        }

        public void Export()
        {
            _exportType.Export();
        }
    }
}
