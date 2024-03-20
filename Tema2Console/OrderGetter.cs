using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console
{
    public class OrderGetter : IOrderGetter
    {
        private ILogger _logger;
        private IFileSource _fileSource;

        public OrderGetter()
        {
            this._logger = new Logger();
            this._fileSource = new FileSource();
        }
        public Order GetOrder()
        {
            _logger.Log("Start processing...");

            _logger.Log("Loading order from file...");
            var dataJson = _fileSource.GetOrderSource();

            _logger.Log("Deserializing Order object from json data...");
            return OrderSerializer.DeserializeFromJsonString(dataJson);
        }
    }
}
