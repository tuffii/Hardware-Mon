using System;
using System.Collections.Generic;

namespace hardwareMonitor
{
    internal class SensorsAccessor
    {
        public static void getCpuDataToString(ref string buffer)
        {
            if (Parametres.GET_CPU_TEMPERATURE)
            {
                List<Temperature> result = CPU.GetCpuTemperature();
                foreach (Temperature temperature in result)
                {
                    buffer += ComputersManager.Types.CPU + ":   " + temperature.Temp + (Parametres.IS_BIG_MODE ? "\n" : "    ");
                }
            }
            if (Parametres.GET_CPU_LOAD && !Parametres.IS_BIG_MODE)
            {
                int load = (int)Math.Round(CPU.GetCPULoad());
                buffer += load + "%\n";
            }
            else if (!Parametres.IS_BIG_MODE) buffer += '\n';
        }

    }
}
