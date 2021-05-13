using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JukkaServer
{
    public class OrderStatus
    {
        public string MachineId { get; set; }
        public int OrderId { get; set; }
        public string Status { get; set; }

        public OrderStatus() { }

        public OrderStatus(string mId, int oId, string status)
        {
            MachineId = mId;
            OrderId = oId;
            Status = status;
        }
  
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
