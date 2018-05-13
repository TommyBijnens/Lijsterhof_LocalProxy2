using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using WebApplication2.Models.General;

namespace WebApplication2.Models
{
    public static class EXT
    {
        private static Dictionary<string, EXTParameter> parameterList = EXTParameterService.parameterDictionary();

        public static IEnumerable<ExportParameter> GetList()
        {
            List<EXTParameter> result = new List<EXTParameter>();
            foreach (var item in parameterList)
            {
                EXTParameter p = item.Value;
                p.key = item.Key;
                result.Add(p);
            }
            return result.Select(p => p.ForExport());
        }

        public static ExportParameter GetParameter(string key)
        {
        if (parameterList.TryGetValue(key, out EXTParameter result))
            {
                result.key = key;
                string response = WebService.getFromWebService(result.url);
                Weather currentWeather = JsonConvert.DeserializeObject<Weather>(response);
                result.Value = float.Parse(currentWeather.main.temp.Replace(".", ","));
                return result.ForExport();
            }
        else
            {
                return null;
            }

        }
    }


}