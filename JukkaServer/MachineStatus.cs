using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JukkaServer
{
    public class MachineStatus
    {
        public string MachineId { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public DateTime TimeStamp { get; set; }

        public MachineStatus()
        {

        }

        public MachineStatus(string mId, string status, string reason, DateTime timeStamp)
        {
            MachineId = mId;
            Status = status;
            Reason = reason;
            TimeStamp = timeStamp;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
