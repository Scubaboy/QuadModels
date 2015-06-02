using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadModels
{
    public class ActiveQuad
    {
        public ActiveQuad(int entityId)
        {
            this.Id = entityId;
        }

        public int Id { get; private set; }
        public string QuadId { get; set; }
        public CommsOptions SupportedComms { get; set; }
        public IMUOpions SupportedIMU { get; set; }
        public GPSOptions SupportGPS { get; set; }
        public AltimeterOptions SupportedAlt { get; set; }
        public bool InUse { get; set; }
    }
}
