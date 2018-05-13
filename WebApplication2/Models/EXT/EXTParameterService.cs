using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public static class EXTParameterService
    {
        public const bool canWrite = true;
        public static Dictionary<string, EXTParameter> parameterDictionary()
        {
            return new Dictionary<string, EXTParameter>(StringComparer.OrdinalIgnoreCase)
            {
                      {"temp", new EXTParameter("Temperatuur Buiten",ConfigurationManager.AppSettings["EXTAddress"], Parameter.DisplayType.Gauge)},

            };
        }
    }
}