using System;

namespace hardwareMonitor
{
    internal class ArduinoInterfaceManager
    {
        public static readonly char START_SEPARATE = '{';
        public static readonly char END_SEPARATE = '}';

        public static void setArduinoInterface()
        {
            try
            {
                SerialPortManager.SerialPortSendMesage(new string(new char[] { START_SEPARATE, LARGE_MODE_MARK, END_SEPARATE }));
            }
            catch (Exception e)
            {
                throw new System.IO.IOException("IOException set interface ARDUINO error: " + e);
            }
        }
    }
}
