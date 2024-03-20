using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console
{
    public class ProcessOrderSauna : ProcessOrder
    {
        public ProcessOrderSauna(Order order) : base(order)
        {
            
        }

        override
        public decimal process()
        {
            _logger.Log("Processing Sauna order...");

            _logger.Log("Validating order parameters...");

            if (order.Quantity == 0)
            {
                _logger.Log("-Sauna order must specify Quantity");
                return 0;
            }

            if (order.Price == 0)
            {
                _logger.Log("-Sauna order must specify Price");
                return 0;
            }

            if (string.IsNullOrEmpty(order.ReservationDate))
            {
                _logger.Log("-Sauna order must specify Reservation Date");
                return 0;
            }

            if (!DateTime.TryParseExact(order.ReservationDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out var pasedReservationDate))
            {
                _logger.Log("-Reservation Date must be a valid date");
                return 0;
            }

            if (pasedReservationDate < DateTime.Now.AddMonths(1))
            {
                return (order.Quantity * order.Price) * 0.9m;
            }
            else if (pasedReservationDate < DateTime.Now.AddMonths(2))
            {
                return (order.Quantity * order.Price) * 0.8m;
            }
            else
            {
                return order.Quantity * order.Price;
            }
        }
    }
}
