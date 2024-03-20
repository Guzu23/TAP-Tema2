using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console
{
    public class ProcessOrderUnknown : ProcessOrder
    {
        public ProcessOrderUnknown(Order order) : base(order)
        {

        }

        override
        public decimal process()
        {
            _logger.Log("Processing unknown order...");

            _logger.Log("-This order is unknown!");

            return 0;
        }
    }
}
