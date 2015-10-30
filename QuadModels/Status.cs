using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadModels
{
    public class Status
    {
        public Status(int quadId, DateTime timeLastHeartbeatReceived, bool heartbeatWithinThreshold)
        {
            this.HeartbeatWithinThreshold = heartbeatWithinThreshold;
            this.TimeLastHeartbeatReceived = timeLastHeartbeatReceived;
            this.QuadId = quadId;

        }

        public int QuadId { get; private set; }
        public DateTime TimeLastHeartbeatReceived { get; private set; }
        public bool HeartbeatWithinThreshold { get; private set; }
    }
}
