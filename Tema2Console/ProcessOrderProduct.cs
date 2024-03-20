using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console
{
    public class ProcessOrderProduct : ProcessOrder
    {
        public ProcessOrderProduct(Order order) : base(order)
        {
            
        }

        override
        public decimal process()
        {
            _logger.Log("Processing Product order...");

            _logger.Log("Validating order parameters...");

            if (string.IsNullOrEmpty(order.Name))
            {
                _logger.Log("-Product order must specify Name");
                return 0;
            }

            if (order.Quantity == 0)
            {
                _logger.Log("-Product order must specify Quantity");
                return 0;
            }

            if (order.Price == 0)
            {
                _logger.Log("-Product order must specify Price");
                return 0;
            }

            var price = order.Quantity * order.Price;
            if (order.Name == "Fanta")
            {
                price *= 0.75m;
            }

            return price;
        }
    }
}
