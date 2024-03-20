using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console
{
    public class ProcessOrder : IProcessOrder
    {
        protected ILogger _logger;
        protected Order order;

        public ProcessOrder(Order order)
        {
            this._logger = new Logger();
            this.order = order;
        }

        public virtual decimal process()
        {
            Console.WriteLine("Processing default order...");
            return 0;
        }
    }
}
