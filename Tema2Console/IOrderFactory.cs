using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console
{
    public interface IOrderFactory
    {
        ProcessOrder Create(Order order);
    }
}
