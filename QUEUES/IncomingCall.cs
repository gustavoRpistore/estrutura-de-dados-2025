using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace QUEUES
{
    public class IncomingCall
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Calltime { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime Endtime { get; set; }
        public string Consultant { get; set; } = null!;
    }
}