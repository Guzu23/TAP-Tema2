using Lab3Console;

namespace Tema2Console
{
    public class HotelReception : IHotelReception
    {
        private ILogger _logger;
        private IOrderGetter _orderGetter;
        public decimal FinalPrice { get; set; } = decimal.Zero;

        public HotelReception()
        {
            this._logger = new Logger();
            this._orderGetter = new OrderGetter();
        }

        public void ProcessOrder()
        {
            Order order = _orderGetter.GetOrder();

            if (order == null)
            {
                _logger.Log("Order type not parsed successfully.");
                return;
            }

            OrderFactory factory = new OrderFactory();

            var processOrder = factory.Create(order);
            
            decimal orderPrice = processOrder.process();

            FinalPrice += orderPrice;

            _logger.Log($"Order completed ({orderPrice} RON).");
        }
    }
}
