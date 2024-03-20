using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console
{
    public class OrderSerializer
    {
        public static Order DeserializeFromJsonString(string dataJson)
        {
            return JsonConvert.DeserializeObject<Order>(dataJson, new StringEnumConverter()); ;
        }
    }
}
