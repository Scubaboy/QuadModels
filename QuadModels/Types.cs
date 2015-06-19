using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadModels
{
    public enum CommsOptions
    {
        Xbee = 0,
        GSMModem = 1
    }

    public enum IMUOpions
    {
        DCM = 0,
        MPU1 = 1,
        MPUDCM = 2
    }

    public enum GPSOptions
    {
        GPSShortMsg = 0,
        GPSLongMsg = 1,
        GPSLongShortMsg = 2
    }

    public enum AltimeterOptions
    {
        GPS = 0,
        Altic = 1,
        CGPSALtic = 2
    }

    public enum PlatformConfiguration
    {
        Quad = 0,
        Heli = 1
    };
}
