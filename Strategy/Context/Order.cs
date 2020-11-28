namespace Strategy.Context
{
    public class Order
    {
        private readonly IOrderType _orderType;

        public Order(IOrderType orderType)
        {
            _orderType = orderType;
        }

        public void Export()
        {
            _orderType.Export();
        }
    }
}
