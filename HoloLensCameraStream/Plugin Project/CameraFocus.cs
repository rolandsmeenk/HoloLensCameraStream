using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoloLensCameraStream
{
    /// <summary>
    /// Gathers the focal data for a single frame
    /// Refer https://docs.microsoft.com/en-us/uwp/api/windows.media.devices.focuscontrol
    /// </summary>
    public struct  CameraFocus
    {
        public uint Max;
        public uint Min;
        public uint Value;

        public CameraFocus(Windows.Media.Devices.FocusControl focus)
        {
            Max = focus.Max;
            Min = focus.Min;
            Value = focus.Value;
        }
    }
}
