using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2Console;

namespace Lab3Console
{
    public class OrderFactory : IOrderFactory
    {
        private ILogger _logger;

        public OrderFactory()
        {
            this._logger = new Logger();
        }
        public ProcessOrder Create(Order order)
        {
            switch (order.Type)
            {
                case OrderType.Room:
                    return new ProcessOrderRoom(order);

                case OrderType.Product:
                    return new ProcessOrderProduct(order);

                case OrderType.Breakfast:
                    return new ProcessOrderBreakfast(order);

                case OrderType.Sauna:
                    return new ProcessOrderSauna(order);

                default:
                    return new ProcessOrderUnknown(order);
            }
        }
    }
}
