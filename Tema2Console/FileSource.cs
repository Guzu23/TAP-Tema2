using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console
{
    public class FileSource : IFileSource
    {
        public string GetOrderSource()
        {
            return File.ReadAllText("orders.json");
        }
    }
}
