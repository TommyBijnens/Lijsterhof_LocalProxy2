using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public static class RPIParameterService
    {
        public const bool canWrite = true;
        public static Dictionary<string, RPIParameter> parameterDictionary()
        {
            return new Dictionary<string, RPIParameter>(StringComparer.OrdinalIgnoreCase)
            {
                {"temp1", new RPIParameter("Temperatuur Keuken", ConfigurationManager.AppSettings["RPI01Address"], Parameter.DisplayType.Gauge)},
                {"temp2", new RPIParameter("Temperatuur Salon", ConfigurationManager.AppSettings["RPI02Address"], Parameter.DisplayType.Gauge)},
            };
        }
    }
}