using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using WebApplication2.Models.General;

namespace WebApplication2.Models
{
    public static class RPI
    {
        private static Dictionary<string, RPIParameter> rpiList = RPIParameterService.parameterDictionary();

        public static IEnumerable<ExportParameter> GetList()
        {
            List<RPIParameter> result = new List<RPIParameter>();
            foreach (var item in rpiList)
            {
                RPIParameter p = item.Value;
                p.key = item.Key;
                result.Add(p);
            }
            return result.Select(p => p.ForExport());
        }

        public static ExportParameter GetParameter(string key)
        {
            if (rpiList.TryGetValue(key, out RPIParameter result))
            {
                result.key = key;
                string response = WebService.getFromWebService(result.ip);
                result.Value = float.Parse(response.Replace(".", ","));
                return result.ForExport();
            }
            else
            {
                return null;
            }

        }

    }

}
