// UsbEject version 1.0 March 2006
// written by Simon Mourier <email: simon [underscore] mourier [at] hotmail [dot] com>

using System;

namespace UsbEject.Library
{
    /// <summary>
    /// The device class for disk devices.
    /// </summary>
    public class DiskDeviceClass : DeviceClass
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the DiskDeviceClass class.
        /// </summary>
        /// <param name="logger">Logger.</param>
        /// <param name="loggerOwner">Indicates whether the device class instance owns <paramref name="logger"/>.</param>
        public DiskDeviceClass(ILogger logger = null, bool loggerOwner = false)
            : base(new Guid(Native.GUID_DEVINTERFACE_DISK), logger, loggerOwner)
        {
        }

        #endregion
    }
}
